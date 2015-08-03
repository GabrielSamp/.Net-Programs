using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker
{
    public class noSuchTableException : Exception
    {
        public void exceptionMsg()
        {
            MessageBox.Show("The table you entered could not be found");
        }

    }
}
