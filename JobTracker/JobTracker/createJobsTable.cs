using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker
{
    static class createJobsTable
    {
        static public List<List<string>> getJobsbasicInfo()
        {
            List<List<string>> bigList = new List<List<string>>();
            List<string> smallList = new List<string>();
            smallList.Add("job");
            smallList.Add("varchar(100)");
            bigList.Add(smallList);

            smallList = new List<string>();
            smallList.Add("company");
            smallList.Add("varchar(100)");
            bigList.Add(smallList);

            smallList = new List<string>();
            smallList.Add("dateApplied");
            smallList.Add("varchar(20)");
            bigList.Add(smallList);

            smallList = new List<string>();
            smallList.Add("jobNumber");
            smallList.Add("varchar(50)");
            bigList.Add(smallList);

            smallList = new List<string>();
            smallList.Add("altJobNumber");
            smallList.Add("varchar(50)");
            bigList.Add(smallList);

            smallList = new List<string>();
            smallList.Add("location");
            smallList.Add("varchar(150)");
            bigList.Add(smallList);


            smallList = new List<string>();
            smallList.Add("description");
            smallList.Add("text");
            bigList.Add(smallList);

            return bigList;

        } 


    }
}
