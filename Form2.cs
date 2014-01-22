using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO2
{
    public partial class Form2 : Form
    {
        Form1 mainf;
        public Form2(Form1 par)
        {
            this.mainf = par;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool suc = true;
            int b, r;
            try
            {
                b = int.Parse(txtBlue.Text);
                r = int.Parse(txtRed.Text);
            }
            catch
            {
                suc = false;
                throw new NotMyFaultException("Invalid number format!");
            }

            if (suc) 
            {
                mainf.BlueScore = -mainf.BlueScore + b;
                mainf.RedScore = -mainf.RedScore + r;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
