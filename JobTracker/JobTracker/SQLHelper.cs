using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace JobTracker
{
     public class SQLHelper
    {
        private string folderLocation;
        private string dbLocation; 
        private SQLiteConnection connection;
        private List<List<string>> tableDate = new List<List<string>>();

         /// <summary>
         /// Constructor for this class requires the location of the database. If the datebase does not exists it will be created.
         /// </summary>
         /// <param name="table"></param>
         /// <param name="dataLocation"></param>
        public SQLHelper(string dataLocation ){

            dbLocation = dataLocation;
            folderLocation = Path.GetDirectoryName(dbLocation);
          //  createDB();
            //initlizeConnection();
            
        }

        private void initlizeConnection(){
         connection = new SQLiteConnection("Data Source=" + dbLocation);
     }
        private void closeConnection()
        {
            if (connection != null)
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {

                }
                finally
                {
                    connection.Dispose();

                }
        }

         //this method checks for the requested table and throws an exception if it is not found
        private void checkForTable(string table)
        {
            SQLiteCommand cmd = null;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbLocation);
            try
            {

                conn.Open();
                string querry = "pragma table_info(" + table + ");";
                cmd = new SQLiteCommand(querry, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.FieldCount < 1)
                {
                    throw new noSuchTableException();
                }
            }
            catch (noSuchTableException)
            {
                throw;
            }
            catch (Exception) { }
            finally
            {
                if(cmd != null)
                cmd.Dispose();
                if (conn != null)
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        conn.Dispose();

                    }
            }
        }


         /// <summary>
        /// This method gets the column names of the selected table. Can throw the noSuchTableException.
         /// </summary>
         /// <param name="table"></param>
         /// <returns></returns>
        public List<string> getColumnNames(string table)
        {
             SQLiteCommand cmd = null;
             SQLiteConnection conn = null;
             List<string> tempList = new List<string>();
            try
            {

                conn = new SQLiteConnection("Data Source=" + dbLocation);
                conn.Open();

                string querry = "pragma table_info(" + table + ");";
                cmd = new SQLiteCommand(querry, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if(reader.FieldCount < 1)
                {
                    throw new noSuchTableException();

                }
                
                while (reader.Read())
                {
                    tempList.Add(reader.GetValue(1).ToString());
                }

                return tempList;

            }
            catch (noSuchTableException)
            {
                throw;
            }
            catch (Exception) {
                return tempList;
            
            }
            finally
            {
                if(cmd != null)
                cmd.Dispose();

                if (conn != null)
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        conn.Dispose();
                    }
            }
        } //end getColumnNames

         /// <summary>
        /// Creates the SQLite db if it is not found
         /// </summary>

        public void createDB()
        {

            if(!Directory.Exists(folderLocation))
                Directory.CreateDirectory(folderLocation);
            if (!File.Exists(dbLocation))
                SQLiteConnection.CreateFile(dbLocation);
        }

        

         /// <summary>
         /// Creates a table with the provided name and takes a List of Lists with the column Name at 0 and the column data type at 1. i.e. list[n][0] = name
         /// list[n][1] = varChar(200)
         /// </summary>
         /// <param name="tableName"></param>
         /// <param name="columns"></param>
         /// <returns></returns>
        public bool createTable(string tableName, List<List<string>> columns )
        {
             SQLiteCommand cmd = null;
            try
            {
                initlizeConnection();
                connection.Open();
                
                string querry =
                    "create table if not exists " + tableName + " (id INTEGER PRIMARY KEY";
                
                    for(int cnt = 0 ; cnt < columns.Count; cnt ++)
                    {
                        querry += " , " + columns[cnt][0] + " " + columns[cnt][1];
                    }

                    querry += ")";

                cmd = new SQLiteCommand(querry, connection);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SQLiteException)
            {
                return false;
            }
            finally
            {
                if(cmd != null)
                {
                    cmd.Dispose();

                }
                if (connection != null)
                    try
                    {
                        connection.Close();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        connection.Dispose();
                        //initlizeConnection();
                    }
          
            }
        }//end create table method

         /// <summary>
         /// Adds a row to the table specified in the table parameter. All rows have an auto incrimented rowId column.
         /// Values should be in the format of column name then value name. i.e. values[n][0] = column Name and values[n][1] = row value "
         /// </summary>
         /// <param name="table"></param>
         /// <param name="values"></param>
         /// <returns></returns>
        public bool addRow(string table, List<List<string>> values)
        {
            //SQLiteConnection connection = null;

            SQLiteCommand cmd = null;
            try
            {
                checkForTable(table);
                initlizeConnection();
                connection.Open();
                cmd = new SQLiteCommand();

                cmd.Connection = connection;
                string querry = "insert into " + table + " (";
                string valueString = " VALUES (";
                

                for (int cnt = 0; cnt < values.Count; cnt++)
                {
                    querry += values[cnt][0] + " , " ;
                    valueString += "@" +  values[cnt][0] + " , ";
                    string temp = values[cnt][1];
                    cmd.Parameters.Add(new SQLiteParameter("@" + values[cnt][0], temp));
                }
                    
                querry = querry.Remove(querry.LastIndexOf(','));
                querry += ")";
                valueString = valueString.TrimEnd(' ');
                valueString = valueString.Remove(valueString.LastIndexOf(' '));
                valueString += ")";

                querry += valueString;
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();
                /* DateTime tempDate;
                if (dateApplied == null)
                    tempDate = DateTime.Today;
                 else
                 {
                     try
                     {
                         tempDate = Convert.ToDateTime(dateApplied);
                     }
                     catch (Exception)
                     {
                         tempDate = DateTime.Today;
                     }
                 }

                string querry = "insert into jobs (job, company, dateApplied, jobNumber, altJobNumber, location, description) VALUES ('" + job + "', '" + company +
                                "' , '" + tempDate + "' , '" + jobNum + "' , '" + altJobNum + "' , '" + location + "' , '" + description + "')";
                cmd = new SQLiteCommand(querry, connection);
                 */



                //cmd.Dispose();
               // connection.Close();

                return true;


            }
            catch (noSuchTableException)
            {
                throw;
            }
            catch(SQLiteException)
            {
                return false;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();

                }
                if (connection != null)
                    try
                    {
                        connection.Close();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        connection.Dispose();
                        //initlizeConnection();
                    }
            }



        }//end addRow method

         /// <summary>
         /// Gets all the rows of the indicated table. Can raise the no such table exception.
         /// </summary>
         /// <param name="table"></param>
         /// <returns></returns>
        public List<List<string>> getAllRows(string table)
        {
            List<List<string>> tempMajorList = new List<List<string>>();
            List<string> aTempList;

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
           // Exception noSuchTableException = new Exception(); 
           
            try
            {
                List<string> columnNames = getColumnNames(table);
                //checkForTable(table);
                conn = new SQLiteConnection("Data Source=" + dbLocation);
                conn.Open();
                string querry = "SELECT * FROM " + table;

                cmd = new SQLiteCommand(querry, conn);

                reader = cmd.ExecuteReader();
                
                
                while (reader.Read())
                {
                    aTempList = new List<string>();
                    foreach (string s in columnNames)
                    {
                        aTempList.Add(Convert.ToString(reader[s]));
                    }
                    /*
                    aTempList = new List<string>();
                    aTempList.Add(Convert.ToString(reader["id"]));
                    aTempList.Add(Convert.ToString(reader["job"]));
                    aTempList.Add(Convert.ToString(reader["company"]));
                    aTempList.Add(Convert.ToString(reader["dateApplied"]));
                    aTempList.Add(Convert.ToString(reader["jobNumber"]));
                    aTempList.Add(Convert.ToString(reader["altJobNumber"]));
                    aTempList.Add(Convert.ToString(reader["location"]));
                    aTempList.Add(Convert.ToString(reader["description"]));
                    */

                    tempMajorList.Add(aTempList);

                   
                }//end reader while
            }//end try
            catch (noSuchTableException)
            {
                throw;
            }
            catch (SQLiteException e)
            {
                aTempList = new List<string>();
                aTempList.Add("ERROR");
                aTempList.Add(e.ToString());
                tempMajorList.Add(aTempList);
            }//end catch
            finally
            {
                cmd.Dispose();
                conn.Close();
            }//end finally
            return tempMajorList;

        }//end get all rows method

         /// <summary>
         /// This method returns all columns in a rows from a table matching specified conditions. The condition should be in the format keyColumn = keyValue.
         /// There is no limit to the number of column/value pairs but more pairs will reduce matches.
         /// </summary>
        /// <param name="table"></param>
        /// <param name="keyPairs"></param>
         /// <returns></returns>
        public List<List<string>> getAllRowsFromTableWhere(string table, List<string> keyPairs)
        {
            List<List<string>> tempMajorList = new List<List<string>>();
            List<string> aTempList = new List<string>();

           
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
           
            try
            {

            List<string> columnNames = getColumnNames(table);
            initlizeConnection();
            connection.Open();
            cmd.Connection = connection;
            string querry = "SELECT * FROM "+ table + " WHERE "; //+keyColumn + " = " + key;
            foreach (string s in keyPairs)
            {
                querry += s + " , ";
            }
            querry = querry.Remove(querry.LastIndexOf(','));
            cmd.CommandText = querry;

           //cmd = new SQLiteCommand(querry, conn);

           reader = cmd.ExecuteReader();


           while (reader.Read())
           {
               aTempList = new List<string>();
               foreach (string s in columnNames)
               {
                   aTempList.Add(Convert.ToString(reader[s]));
               }
               /*
               aTempList.Add(Convert.ToString(reader["id"]));
               aTempList.Add(Convert.ToString(reader["job"]));
               aTempList.Add(Convert.ToString(reader["company"]));
               aTempList.Add(Convert.ToString(reader["dateApplied"]));
               aTempList.Add(Convert.ToString(reader["jobNumber"]));
               aTempList.Add(Convert.ToString(reader["altJobNumber"]));
               aTempList.Add(Convert.ToString(reader["location"]));
               aTempList.Add(Convert.ToString(reader["description"]));
               */

               tempMajorList.Add(aTempList);

               
           }//end reader while
            }//end try
            catch (noSuchTableException)
            {
                throw;
            }
            catch (SQLiteException e)
            {
                throw;
                /*aTempList.Clear();
                aTempList.Add("ERROR");
                aTempList.Add(e.ToString());
                tempMajorList.Add(aTempList);
                  */
            }//end catch
            finally
            {
                if(cmd != null)
                cmd.Dispose();
                if (connection != null)
                    try
                    {
                        connection.Close();
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        connection.Dispose();
                        //initlizeConnection();
                    }
            }//end finally
            return tempMajorList;
        }//end get row method

        public void outputList(string location, string table)
        {
            List<List<string>> tempList = new List<List<string>>();
            List<string> columnList = new List<string>();
            try
            {
                tempList = getAllRows(table);
                columnList = getColumnNames(table);
            }
            catch(noSuchTableException)
            {
                throw;
            }
            string outputString = "";
            outputString = "";  //"Id, Job, Company, Date Applied, Job Number, Alt Job Number, location, Description \n";
                                
            foreach(string s in columnList)
            {
                outputString += s + ",";
            }

            for(int row = 0 ; row < tempList.Count; row ++)
            {
                for(int column = 0; column < tempList[row].Count; column ++)
                {
                    outputString += "\"" + tempList[row][column] + "\",";

                }
                outputString += "\n";

            }

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(location);
                sw.Write(outputString);
            }
            catch(Exception)
            {
              
            }
            finally
            {
                try
                {
                    sw.Close();
                }
                catch (Exception)
                {
                    sw.Dispose();
                }
            }

        }//end output method



         /// <summary>
        /// Deletes a row or rows from a table matching specified conditions. The condition should be in the format keyColumn = keyValue.
        /// There is no limit to the number of column/value pairs but more pairs will reduce matches.
         /// </summary>
         /// <param name="job"></param>
         /// <param name="company"></param>
         /// <param name="jobNumber"></param>
         /// <returns></returns>
        public bool deleteRow(string table, string rowId)//job, string company, string jobNumber)
        {
             SQLiteConnection conn = null;
            SQLiteCommand cmd = null;


            try
            {
                conn = new SQLiteConnection("Data Source=" + dbLocation);
                conn.Open();
                string querry = "DELETE FROM " + table + " WHERE id=" + rowId; //+ job + "' AND company = '" + company + "' AND jobnumber = '" + jobNumber + "'";

                cmd = new SQLiteCommand(querry, conn);
                cmd.ExecuteNonQuery();
            }
            catch(SQLiteException)
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();

            }

            return true;



        }//end delete row


         /// <summary>
         /// Updates a row based on rowId. Values are passed by the combination of columnName = newValue
         /// </summary>
         /// <param name="rowId"></param>
         /// <param name="table"></param>
         /// <param name="values"></param>
         /// <returns></returns>
        public bool updateRow(string rowId, string table, List<string> values)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = new SQLiteCommand();


            try
            {
                conn = new SQLiteConnection("Data Source=" + dbLocation);
                conn.Open();
                string querry = "UPDATE " + table + " SET ";   /*job = '" + job + "' , company = '" + company + "', dateApplied = '" + dateApplied + "' , jobNumber = '" +
                    jobNumber + "' , altJobNumber = '" + altJobNumber+ "' , location = '" + location + "' , description = '" + description + "' WHERE rowid = " + rowId;
                */
                cmd.Connection = conn;
                int cnt = 0;
                string column, value;

                foreach(string s in values)
                {
                    column = s.Substring(0, s.IndexOf('='));
                    value = s.Substring(s.IndexOf("=")+1);
                    querry += column + "=@" + column + ", ";
                    cmd.Parameters.Add(new SQLiteParameter("@" + column, value));
                    cnt++;
                }
                querry = querry.Remove(querry.LastIndexOf(','));
                querry += " where id=" + rowId;
                cmd.CommandText = querry; //= new SQLiteCommand(querry, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();

            }
            return true;
        }

    }//end SQLHelper class

  
    
}// end name space
