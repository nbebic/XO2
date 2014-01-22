namespace XO2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScoreRed = new System.Windows.Forms.Label();
            this.ScoreBlue = new System.Windows.Forms.Label();
            this.LoadGame = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ScoreRed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScoreBlue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadGame, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 232);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ScoreRed
            // 
            this.ScoreRed.AutoSize = true;
            this.ScoreRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScoreRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreRed.Font = new System.Drawing.Font("Comic Sans MS", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreRed.ForeColor = System.Drawing.Color.Red;
            this.ScoreRed.Location = new System.Drawing.Point(351, 0);
            this.ScoreRed.Name = "ScoreRed";
            this.ScoreRed.Size = new System.Drawing.Size(161, 187);
            this.ScoreRed.TabIndex = 1;
            this.ScoreRed.Text = "0";
            // 
            // ScoreBlue
            // 
            this.ScoreBlue.AutoSize = true;
            this.ScoreBlue.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScoreBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreBlue.Font = new System.Drawing.Font("Comic Sans MS", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreBlue.ForeColor = System.Drawing.Color.Blue;
            this.ScoreBlue.Location = new System.Drawing.Point(184, 0);
            this.ScoreBlue.Name = "ScoreBlue";
            this.ScoreBlue.Size = new System.Drawing.Size(161, 187);
            this.ScoreBlue.TabIndex = 0;
            this.ScoreBlue.Text = "0";
            // 
            // LoadGame
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LoadGame, 2);
            this.LoadGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadGame.Location = new System.Drawing.Point(3, 190);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(691, 39);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "&Next Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setScoreToolStripMenuItem,
            this.endGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // setScoreToolStripMenuItem
            // 
            this.setScoreToolStripMenuItem.Name = "setScoreToolStripMenuItem";
            this.setScoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setScoreToolStripMenuItem.Text = "Set Score";
            this.setScoreToolStripMenuItem.Click += new System.EventHandler(this.setScoreToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "asdf";
            this.openFileDialog1.Filter = "ASDF|*.asdf|All Files|*.*";
            this.openFileDialog1.Title = "Load Game";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(697, 256);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ScoreRed;
        private System.Windows.Forms.Label ScoreBlue;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

