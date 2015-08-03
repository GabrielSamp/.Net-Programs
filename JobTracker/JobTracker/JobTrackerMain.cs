using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JobTracker
{
    public partial class JobTrackerMain : Form
    {
        List<List<string>> jobList = new List<List<string>>();
        string dataLocation;
        public SQLHelper sqlHelper;

        public JobTrackerMain()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
           string folderLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "jobTracker");
            string dbLocation = Path.Combine(folderLocation,"jobTrackerDB.sqlite");
             sqlHelper = new SQLHelper(dbLocation);

             if (!File.Exists(dbLocation))
             {
                 sqlHelper.createDB();
                 sqlHelper.createTable("jobs", createJobsTable.getJobsbasicInfo());
             }

             dataLocation = dbLocation;
           

            txtExportLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

           var jobsColumns = sqlHelper.getColumnNames("jobs");

           foreach (string s in jobsColumns)
           {
               listViewDisplay.Columns.Add(s);
           }
          
            updateList();


            
            

        }

        public void updateList()
        {
            listViewDisplay.Items.Clear();
            listViewDisplay.Sorting = SortOrder.Descending;
            jobList = sqlHelper.getAllRows("jobs");
            ListViewItem lvi;
            for (int row = 0; row < jobList.Count; row++)
            {

                lvi = new ListViewItem(jobList[row].ToArray());
                listViewDisplay.Items.Add(lvi);
            }
            listViewDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtExportLocation.Text = fbd.SelectedPath;
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            string location = Path.Combine( txtExportLocation.Text, txtFileName.Text + ".csv");
            sqlHelper.outputList(location, "jobs");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJob.Clear();
            txtCompany.Clear();
            txtDateApplied.Clear();
            txtJobNumber.Clear();
            txtAltJobNumber.Clear();
            txtLocation.Clear();
            txtDescription.Clear();
            lblSucess.Text = "";
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string[] tempArray;
            lblSucess.Text = "";
            
            List<List<string>> tempList = new List<List<string>>();

            tempArray = new string[] { "job", txtJob.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "company", txtCompany.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "dateApplied", txtDateApplied.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "jobNumber", txtJobNumber.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "altJobNumber", txtAltJobNumber.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "location", txtLocation.Text };
            tempList.Add(new List<string>(tempArray));

            tempArray = new string[] { "description", txtDescription.Text };
            tempList.Add(new List<string>(tempArray));



            bool results = sqlHelper.addRow("jobs", tempList);

            if (results)
            {
                lblSucess.Text = "Commit Sucessful";
                updateList();
                btnClear.PerformClick();
            }
            else
                lblSucess.Text = "Commit Failed";
        }

        private void listViewDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewDisplay_ItemActivate(object sender, EventArgs e)
        {
           
            int selected = Convert.ToInt32(listViewDisplay.Items[listViewDisplay.SelectedIndices[0]].SubItems[0].Text);
            JobDetailsForm jdf = new JobDetailsForm(jobList, ref sqlHelper, selected);
            jdf.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void thisWeeksJobs()
        {
            listViewDisplay.Items.Clear();
            listViewDisplay.Sorting = SortOrder.None;
            var weekStart = DayOfWeek.Sunday;
            DateTime start = DateTime.Today;

            while(start.DayOfWeek != weekStart)
            {
                start = start.AddDays(-1);

            }

            List<List<string>> tempList = sqlHelper.getAllRows("jobs");

            ListViewItem lvi;
            DateTime jobDate;
            for (int row = 0; row < jobList.Count; row++)
            {
                jobDate = Convert.ToDateTime(tempList[row][3]);
                if (jobDate >= start)
                {
                    lvi = new ListViewItem(tempList[row].ToArray());
                    listViewDisplay.Items.Add(lvi);
                }
            }
            listViewDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }//end thisWeeksJobs

        private void lastWeeksJobs()
        {
            listViewDisplay.Items.Clear();
            listViewDisplay.Sorting = SortOrder.None;

            var weekStart = DayOfWeek.Sunday;
            DateTime start = DateTime.Today;

            while (start.DayOfWeek != weekStart)
            {
                start = start.AddDays(-1);

            }

            DateTime startLastWeek = start.AddDays(-7);
            DateTime endLastWeek = start.AddDays(-1);

            List<List<string>> tempList = sqlHelper.getAllRows("jobs");

            ListViewItem lvi;
            DateTime jobDate;
            for (int row = 0; row < jobList.Count; row++)
            {
                jobDate = Convert.ToDateTime(tempList[row][3]);
                if (jobDate >= startLastWeek && jobDate <= endLastWeek)
                {
                    lvi = new ListViewItem(tempList[row].ToArray());
                    listViewDisplay.Items.Add(lvi);
                }
            }
            listViewDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }//end lastWeeksJobs

        private void radioButtonShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonShowAll.Checked)
                updateList();
        }

        private void radioButtonThisWeeksJobs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThisWeeksJobs.Checked)
                thisWeeksJobs();
        }

        private void radioButtonLastWeeksJobs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLastWeeksJobs.Checked)
                lastWeeksJobs();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listViewDisplay.Items[listViewDisplay.SelectedIndices[0]];
            string text = "";
            //ListViewHitTestInfo subItem 
            for (int count = 1; count < lvi.SubItems.Count; count++ )
            {
                text += lvi.SubItems[count].Text;

            }
                Clipboard.SetText(text);
            //ListViewHitTestInfo
        }

        private void listViewDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo click = listViewDisplay.HitTest(e.Location);
            String item = click.SubItem.Text;
            Clipboard.SetText(item);
        }

        private void lblDateApplied_Click(object sender, EventArgs e)
        {
            txtDateApplied.Text = DateTime.Today.ToShortDateString();
        }

    }


}
