using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO2
{
    public partial class Form1 : Form
    {
        private int bScore = 0;
        private int rScore = 0;
        public int BlueScore
        {
            set 
            { 
                bScore += value;
                ScoreBlue.Text = bScore.ToString();
            }
            get
            {
                return bScore;
            }
        }
        public int RedScore
        {
            set
            {
                rScore += value;
                ScoreRed.Text = rScore.ToString();
            }
            get
            {
                return rScore;
            }
        }
        public bool end = true;
        private int i = 0;
        string[] games = new string[100];
        IGame[] history = new IGame[100];
        int gameCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            if (end)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    games = File.ReadAllLines(openFileDialog1.FileName);
                    i = 0;
                    end = false;
                }
            }
            else
            {
                string[] game = games[i].Split('|');
                switch (game[0])
                {
                    case "1": GameAsoc(game); break;
                    case "2": GameQuiz(game); break;
                    case "3": GameConn(game); break;
                    case "0": GameEnd(); break;
                    default: throw new NotMyFaultException("Game ID " + game[0] + " does not exist! Press OK to skip");
                }
                i++;
            }
            
        }

        private void GameEnd()
        {
            end = true;
        }

        private void GameConn(string[] game)
        {
            throw new NotImplementedException();
        }

        private void GameQuiz(string[] game)
        {
            throw new NotImplementedException();
        }
        private void GameAsoc(string[] game) 
        {
            Asoc a = new Asoc();
            history[gameCount] = (IGame)a;
            gameCount++;
            a.Load(game, this);
            a.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlueScore = -BlueScore;
            RedScore = -RedScore;
        }

        private void setScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 setScore = new Form2(this);
            setScore.Show();
        }
    }
}
