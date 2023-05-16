using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class MasterMindGame : Form
    {
        int coloumn = 0;
        int row = 7;
        bool RFlag = false;
        bool BFlag = false;
        bool PFlag = false;
        bool YFlag = false;
        bool GFlag = false;
        bool OFlag = false;
        string[] colors = { "red", "blue", "purple", "yellow", "green", "orange" };
        string[] RandomPickedColor = new string[4];
        string[,] SelectedColors = new string[8,4 ];
        private string[] pickcolor(string[] colors, string[] RandomPickedColor)
        {
            int i = 0;
            for (i = 0; i < RandomPickedColor.Length; i++)
            {
                while (RandomPickedColor[i] == null)
                {
                    bool RepeatFlag = false;
                    int r = new Random().Next(0, 6);
                    if (i == 0)
                    {
                        RandomPickedColor[i] = colors[r];
                    }
                    else
                    {
                        for (int a = 0; a <= i; a++)
                        {
                            if (colors[r] == RandomPickedColor[a])
                                RepeatFlag = true;
                        }
                        if (RepeatFlag == false)
                            RandomPickedColor[i] = colors[r];
                    }
                }
            }
            return RandomPickedColor;
        }
        private void ShowResult(string[,] SelectedColor, string[] RandomPickColor)
        {
            int n;
            int TRCounter = 0;
            if (row == 7)
            {
                n = 7;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S1.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S1.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S2.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S2.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S3.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S3.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S4.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S4.BackColor = Color.Red;
            }
           
            if (row == 6)
            {
                n = 6;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S5.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S5.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S6.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S6.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S7.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S7.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S8.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S8.BackColor = Color.Red;
            }

            if (row == 5)
            {
                n = 5;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S9.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S9.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S10.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S10.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S11.BackColor = Color.Black;
                        TRCounter++;
                }
                else
                    S11.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S12.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S12.BackColor = Color.Red;
            }

            if (row == 4)
            {
                n = 4;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S13.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S13.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S14.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S14.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S15.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S15.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S16.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S16.BackColor = Color.Red;
            }

            if (row == 3)
            {
                n = 3;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S17.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S17.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S18.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S18.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S19.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S19.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S20.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S20.BackColor = Color.Red;
            }

            if (row == 2)
            {
                n = 2;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S21.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S21.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S22.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S22.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S23.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S23.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S24.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S24.BackColor = Color.Red;
            }

            if (row == 1)
            {
                n = 1;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S25.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S25.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S26.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S26.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S27.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S27.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S28.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S28.BackColor = Color.Red;
            }

            if (row == 0)
            {
                n = 0;
                if (SelectedColors[n, 0] == RandomPickColor[0])
                {
                    S29.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S29.BackColor = Color.Red;

                if (SelectedColors[n, 1] == RandomPickColor[1])
                {
                    S30.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S30.BackColor = Color.Red;

                if (SelectedColors[n, 2] == RandomPickColor[2])
                {
                    S31.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S31.BackColor = Color.Red;

                if (SelectedColors[n, 3] == RandomPickColor[3])
                {
                    S32.BackColor = Color.Black;
                    TRCounter++;
                }
                else
                    S32.BackColor = Color.Red;
            }
            if (TRCounter == 4)
            {
                MessageBox.Show("you win", "happy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
            else
            {
                if (row == 0)
                {
                    MessageBox.Show("you lose", "sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Restart();
                }
                else
                    TRCounter = 0;
            }
        }

        private void reset()
        {
            RFlag = false;
            BFlag = false;
            PFlag = false;
            YFlag = false;
            GFlag = false;
            OFlag = false;
        }
        Random random = new Random();

        public MasterMindGame()
        {
            InitializeComponent();
        }

        private void buttonElipseRed_Click(object sender, EventArgs e)
        {

            ButtonElipse NewRed = new ButtonElipse();
            NewRed.BackColor = System.Drawing.Color.Red;
            NewRed.Dock = System.Windows.Forms.DockStyle.Fill;
            NewRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewRed.ForeColor = System.Drawing.Color.Red;
            NewRed.Location = new System.Drawing.Point(44, 14);
            NewRed.MaximumSize = new System.Drawing.Size(500, 500);
            NewRed.Name = "buttonElipseRed";
            NewRed.Size = new System.Drawing.Size(56, 47);
            NewRed.TabIndex = 4;
            NewRed.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (RFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewRed, coloumn, row);
                    SelectedColors[row, coloumn] = "red";
                    coloumn++;
                    RFlag = true;
                    if(coloumn==4)
                        ShowResult(SelectedColors, RandomPickedColor);

                }
            }
            else
            { 
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewRed, coloumn, row);
                SelectedColors[row, coloumn] = "red";
                coloumn++;
                RFlag = true;
            }

        }

        private void buttonElipseBlue_Click(object sender, EventArgs e)
        {
            ButtonElipse NewBlue = new ButtonElipse();
            NewBlue.BackColor = System.Drawing.Color.Blue;
            NewBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            NewBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewBlue.ForeColor = System.Drawing.Color.Blue;
            NewBlue.Location = new System.Drawing.Point(44, 14);
            NewBlue.MaximumSize = new System.Drawing.Size(500, 500);
            NewBlue.Name = "buttonElipseRed";
            NewBlue.Size = new System.Drawing.Size(56, 47);
            NewBlue.TabIndex = 4;
            NewBlue.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (BFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewBlue, coloumn, row);
                    SelectedColors[row, coloumn] = "blue";
                    coloumn++;
                    BFlag = true;
                    if (coloumn == 4)
                        ShowResult(SelectedColors, RandomPickedColor);
                }
            }
            else
            {
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewBlue, coloumn, row);
                SelectedColors[row, coloumn] = "blue";
                coloumn++;
                BFlag = true;
            }
        }

        private void buttonElipsePurple_Click(object sender, EventArgs e)
        {
            ButtonElipse NewPurple = new ButtonElipse();
            NewPurple.BackColor = System.Drawing.Color.Purple;
            NewPurple.Dock = System.Windows.Forms.DockStyle.Fill;
            NewPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewPurple.ForeColor = System.Drawing.Color.Purple;
            NewPurple.Location = new System.Drawing.Point(44, 14);
            NewPurple.MaximumSize = new System.Drawing.Size(500, 500);
            NewPurple.Name = "buttonElipseRed";
            NewPurple.Size = new System.Drawing.Size(56, 47);
            NewPurple.TabIndex = 4;
            NewPurple.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (PFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewPurple, coloumn, row);
                    SelectedColors[row, coloumn] = "purple";
                    coloumn++;
                    PFlag = true;
                    if (coloumn == 4)
                        ShowResult(SelectedColors, RandomPickedColor);
                }
            }
            else
            {
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewPurple, coloumn, row);
                SelectedColors[row, coloumn] = "purple";
                coloumn++;
                PFlag = true;
            }
        }

        private void buttonElipseYellow_Click(object sender, EventArgs e)
        {
            ButtonElipse NewYellow = new ButtonElipse();
            NewYellow.BackColor = System.Drawing.Color.Yellow;
            NewYellow.Dock = System.Windows.Forms.DockStyle.Fill;
            NewYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewYellow.ForeColor = System.Drawing.Color.Yellow;
            NewYellow.Location = new System.Drawing.Point(44, 14);
            NewYellow.MaximumSize = new System.Drawing.Size(500, 500);
            NewYellow.Name = "buttonElipseRed";
            NewYellow.Size = new System.Drawing.Size(56, 47);
            NewYellow.TabIndex = 4;
            NewYellow.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (YFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewYellow, coloumn, row);
                    SelectedColors[row, coloumn] = "yellow";
                    coloumn++;
                    YFlag = true;
                    if (coloumn == 4)
                        ShowResult(SelectedColors, RandomPickedColor);
                }
            }
            else
            {
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewYellow, coloumn, row);
                SelectedColors[row, coloumn] = "yellow";
                coloumn++;
                YFlag = true;
            }
        }

        private void buttonElipseGreen_Click(object sender, EventArgs e)
        {
            ButtonElipse NewGreen = new ButtonElipse();
            NewGreen.BackColor = System.Drawing.Color.Green;
            NewGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            NewGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewGreen.ForeColor = System.Drawing.Color.Green;
            NewGreen.Location = new System.Drawing.Point(44, 14);
            NewGreen.MaximumSize = new System.Drawing.Size(500, 500);
            NewGreen.Name = "buttonElipseRed";
            NewGreen.Size = new System.Drawing.Size(56, 47);
            NewGreen.TabIndex = 4;
            NewGreen.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (GFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewGreen, coloumn, row);
                    SelectedColors[row, coloumn] = "green";
                    coloumn++;
                    GFlag = true;
                    if (coloumn == 4)
                        ShowResult(SelectedColors, RandomPickedColor);
                }
            }
            else
            {
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewGreen, coloumn, row);
                SelectedColors[row, coloumn] = "green";
                coloumn++;
                GFlag = true;
            }
        }


        private void buttonElipseOrange_Click(object sender, EventArgs e)
        {
            ButtonElipse NewOrange = new ButtonElipse();
            NewOrange.BackColor = System.Drawing.Color.Orange;
            NewOrange.Dock = System.Windows.Forms.DockStyle.Fill;
            NewOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewOrange.ForeColor = System.Drawing.Color.Orange;
            NewOrange.Location = new System.Drawing.Point(44, 14);
            NewOrange.MaximumSize = new System.Drawing.Size(500, 500);
            NewOrange.Name = "buttonElipseRed";
            NewOrange.Size = new System.Drawing.Size(56, 47);
            NewOrange.TabIndex = 4;
            NewOrange.UseVisualStyleBackColor = false;
            if (coloumn < 4)
            {
                if (OFlag == false)
                {
                    this.tableLayoutPanel1.Controls.Add(NewOrange, coloumn, row);
                    SelectedColors[row, coloumn] = "orange";
                    coloumn++;
                    OFlag = true;
                    if (coloumn == 4)
                        ShowResult(SelectedColors, RandomPickedColor);
                }
            }
            else
            {
                row--;
                coloumn = 0;
                reset();
                this.tableLayoutPanel1.Controls.Add(NewOrange, coloumn, row);
                SelectedColors[row, coloumn] = "orange";
                coloumn++;
                OFlag = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomPickedColor = pickcolor(colors, RandomPickedColor);
        }
    }
}