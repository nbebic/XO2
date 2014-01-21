using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XO2
{
    class NotMyFaultException : Exception
    {
        public NotMyFaultException(string p)
        {
            MessageBox.Show(p, "It's not my fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
