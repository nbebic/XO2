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
    public partial class Asoc : Form, IGame
    {
        public Asoc()
        {
            InitializeComponent();
        }

        public int BlueModif{get;set;}
        public int RedModif{set;get;}
        private int maxtime;
        private Team cur;
        Form1 par;
        private string[] A = new string[6];
        private string[] B = new string[6];
        private string[] C = new string[6];
        private string[] D = new string[6];
        private string F = "";
        private int scoreA = 7;
        private int scoreB = 7;
        private int scoreC = 7;
        private int scoreD = 7;
        public new void Load(string[] gd, Form1 par)
        {
            maxtime = int.Parse(gd[1]);
            cur = (Team) int.Parse(gd[2]);
            A[1] = gd[3];
            A[2] = gd[4];
            A[3] = gd[5];
            A[4] = gd[6];
            A[5] = gd[7]; 
            B[1] = gd[8];
            B[2] = gd[9];
            B[3] = gd[10];
            B[4] = gd[11];
            B[5] = gd[12];
            C[1] = gd[13];
            C[2] = gd[14];
            C[3] = gd[15];
            C[4] = gd[16];
            C[5] = gd[17];
            D[1] = gd[18];
            D[2] = gd[19];
            D[3] = gd[20];
            D[4] = gd[21];
            D[5] = gd[22];
            F = gd[23];
            this.par = par;
            this.Text = gd[24];
            if (cur == Team.Blue) button22.BackColor = Color.Blue;
            else button22.BackColor = Color.Red;
            dis(true, true, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text != A[(int)s.Tag])
            {
                s.Text = A[(int)s.Tag];
                scoreA--;
                dis(false, true, true);
            }
        }

        private void dis(bool a, bool b, bool c)
        {
            /*
            button1.Enabled = a;
            button2.Enabled = a;
            button3.Enabled = a;
            button4.Enabled = a;
            button5.Enabled = a;
            button6.Enabled = a;
            button7.Enabled = a;
            button8.Enabled = a;
            button9.Enabled = b;
            button10.Enabled = b;
            button11.Enabled = c;
            button12.Enabled = b;
            button13.Enabled = b;
            button14.Enabled = a;
            button15.Enabled = a;
            button16.Enabled = a;
            button17.Enabled = a;
            button18.Enabled = a;
            button19.Enabled = a;
            button20.Enabled = a;
            button21.Enabled = a;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text != B[(int)s.Tag])
            {
                s.Text = B[(int)s.Tag];
                scoreB--;
                dis(false, true, true);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text != C[(int)s.Tag])
            {
                s.Text = C[(int)s.Tag];
                scoreC--;
                dis(false, true, true);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text != D[(int)s.Tag])
            {
                s.Text = D[(int)s.Tag];
                scoreD--;
                dis(false, true, true);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (cur == Team.Blue)
            {
                cur = Team.Red;
                button22.BackColor = Color.Red;
                dis(true, false, false);
            }
            else 
            {
                cur = Team.Blue;
                button22.BackColor = Color.Blue;
                dis(true, false, false);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text == "A")
            {
                if (cur == Team.Blue)
                {
                    par.BlueScore = scoreA;
                    BlueModif += scoreA;
                    button1.ForeColor = Color.Blue;
                    button3.ForeColor = Color.Blue;
                    button5.ForeColor = Color.Blue;
                    button7.ForeColor = Color.Blue;
                    button9.ForeColor = Color.Blue;
                }
                else
                {
                    par.RedScore = scoreA;
                    RedModif += scoreA;
                    button1.ForeColor = Color.Red;
                    button3.ForeColor = Color.Red;
                    button5.ForeColor = Color.Red;
                    button7.ForeColor = Color.Red;
                    button9.ForeColor = Color.Red;
                }
                button1_Click((object)button1, new EventArgs());
                button1_Click((object)button3, new EventArgs());
                button1_Click((object)button5, new EventArgs());
                button1_Click((object)button7, new EventArgs());
                scoreA = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text == "B")
            {
                if (cur == Team.Blue)
                {
                    par.BlueScore = scoreB;
                    BlueModif += scoreB;
                    button2.ForeColor = Color.Blue;
                    button4.ForeColor = Color.Blue;
                    button6.ForeColor = Color.Blue;
                    button8.ForeColor = Color.Blue;
                    button10.ForeColor = Color.Blue;
                }
                else
                {
                    par.RedScore = scoreB;
                    RedModif += scoreB;
                    button2.ForeColor = Color.Red;
                    button4.ForeColor = Color.Red;
                    button6.ForeColor = Color.Red;
                    button8.ForeColor = Color.Red;
                    button10.ForeColor = Color.Red;
                }
                button2_Click((object)button2, new EventArgs());
                button2_Click((object)button4, new EventArgs());
                button2_Click((object)button6, new EventArgs());
                button2_Click((object)button8, new EventArgs());
                scoreB = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text == "C")
            {
                if (cur == Team.Blue)
                {
                    par.BlueScore = scoreC;
                    BlueModif += scoreC;
                    button20.ForeColor = Color.Blue;
                    button14.ForeColor = Color.Blue;
                    button16.ForeColor = Color.Blue;
                    button18.ForeColor = Color.Blue;
                    button12.ForeColor = Color.Blue;
                }
                else
                {
                    par.RedScore = scoreC;
                    RedModif += scoreC;
                    button12.ForeColor = Color.Red;
                    button14.ForeColor = Color.Red;
                    button16.ForeColor = Color.Red;
                    button18.ForeColor = Color.Red;
                    button20.ForeColor = Color.Red;
                }
                button20_Click((object)button20, new EventArgs());
                button20_Click((object)button14, new EventArgs());
                button20_Click((object)button16, new EventArgs());
                button20_Click((object)button18, new EventArgs());
                scoreC = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text == "D")
            {
                if (cur == Team.Blue)
                {
                    par.BlueScore = scoreD;
                    BlueModif += scoreD;
                    button21.ForeColor = Color.Blue;
                    button15.ForeColor = Color.Blue;
                    button17.ForeColor = Color.Blue;
                    button19.ForeColor = Color.Blue;
                    button13.ForeColor = Color.Blue;
                }
                else
                {
                    par.RedScore = scoreD;
                    RedModif += scoreD;
                    button13.ForeColor = Color.Red;
                    button15.ForeColor = Color.Red;
                    button17.ForeColor = Color.Red;
                    button19.ForeColor = Color.Red;
                    button21.ForeColor = Color.Red;
                }
                button15_Click((object)button21, new EventArgs());
                button15_Click((object)button15, new EventArgs());
                button15_Click((object)button17, new EventArgs());
                button15_Click((object)button19, new EventArgs());
                scoreD = 0;
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            ((Button)sender).Enabled = true;
        }
    }
}
