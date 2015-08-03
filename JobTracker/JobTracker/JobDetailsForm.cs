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
    public partial class JobDetailsForm : Form
    {
        List<List<string>> jobList = new List<List<string>>();
        int currentJob = 0;
         SQLHelper sqlHelper;
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        public JobDetailsForm(List<List<string>> tempJobList, ref SQLHelper sqlHelp, int selectedJob = 0)
        {
            InitializeComponent();
            sqlHelper = sqlHelp; 
            jobList = tempJobList;

            //int selected = 0;
            //int selectedItem = listViewDisplay.SelectedIndices[0];
            for (int count = 0; count < jobList.Count; count++)
            {
                if (selectedJob.ToString() == jobList[count][0])
                {
                    currentJob = count;
                    break;
                }
            }
          //  currentJob = selectedJob;


        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {
            updateJob();
        }

        private void updateJob()
        {
            txtJob.Text = jobList[currentJob][1];
            txtCompany.Text = jobList[currentJob][2];
            txtDateApplied.Text = jobList[currentJob][3];
            txtJobNumber.Text = jobList[currentJob][4];
            txtAltJobNumber.Text = jobList[currentJob][5];
            txtLocation.Text = jobList[currentJob][6];
            txtDescription.Text = jobList[currentJob][7];

        }

        private void updateList()
        {
            //jobList[currentJob][0] = tx
            jobList[currentJob][1] = txtJob.Text;
            jobList[currentJob][2] = txtCompany.Text;
            jobList[currentJob][3] = txtDateApplied.Text;
            jobList[currentJob][4] = txtJobNumber.Text;
            jobList[currentJob][5] = txtAltJobNumber.Text;
            jobList[currentJob][6] = txtLocation.Text;
            jobList[currentJob][7] = txtDescription.Text;
        }
    

    

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentJob == 0)
                currentJob = jobList.Count - 1;
            else
                currentJob--;

            updateJob();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentJob == (jobList.Count - 1))
                currentJob = 0;
            else
                currentJob++;

            updateJob();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Do you really want to delete the job " + txtJob.Text + " at " + txtCompany.Text, "Confirm delete", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                
                sqlHelper.deleteRow("jobs", jobList[currentJob][0]);
                int temp = currentJob;
                btnNext.PerformClick();
                jobList.RemoveAt(temp);
                Program.JobTrackerMainForm.updateList();
            }
             
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var tempList = new List<string>();
            tempList.Add("job=" + txtJob.Text);
            tempList.Add("company=" + txtCompany.Text);
            tempList.Add("dateApplied=" + txtDateApplied.Text);
            tempList.Add("jobNumber=" + txtJobNumber.Text);
            tempList.Add("altJobNumber=" + txtAltJobNumber.Text);
            tempList.Add("location=" + txtLocation.Text);
            tempList.Add("description=" + txtDescription.Text);
            sqlHelper.updateRow(jobList[currentJob][0], "jobs", tempList);
                //"job=" + txtJob.Text,"company=" + txtCompany.Text, txtDateApplied.Text, txtJobNumber.Text, txtAltJobNumber.Text, txtLocation.Text, txtDescription.Text);
            updateList();
            Program.JobTrackerMainForm.updateList();
        }
    }
}
