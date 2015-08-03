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
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] splitOptions = {','};
            ListViewItem lvi;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.csv";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string temp;
                StreamReader sr = new StreamReader(ofd.FileName);
                while(!sr.EndOfStream)
                {
                    temp = sr.ReadLine();

                    var split = temp.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);
                    lvi = new ListViewItem(split);
                    listViewImport.Items.Add(lvi);
                    

                }
            }
        }
    }
}
