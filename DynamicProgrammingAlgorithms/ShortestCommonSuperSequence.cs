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

namespace DynamicProgrammingAlgorithms
{
    public partial class ShortestCommonSuperSequence : Form
    {
        private Label[,] lTable;        // array of label to store lengths

        private string sequence1 = "";       // string1 to be read from file
        private string sequence2 = "";       // string2 to be read from file

        private int x = 1, y = 1;
        private bool ReadFromFile()
        {
            string fileName = "Shortest_Common_Supersequence.txt";
            string fileData = File.ReadAllText(fileName);

            sequence1 = fileData.Split(' ')[0];
            sequence2 = fileData.Split(' ')[1];

            richTextBox1.Text = sequence1;
            richTextBox2.Text = sequence2;

            string psuedo = "Psuedo_ShortestCommonSupersequenceProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            return true;
        }

        private void InitializeGrid()
        {
            int yCoord = 20;
            if (this.lTable == null)
            {
                lTable = new Label[sequence1.Length + 1, sequence2.Length + 1];
                int labelCount = 0;
                for (int row = 0; row <= sequence1.Length; row++)
                {
                    int xCoord = 50;
                    for (int column = 0; column <= sequence2.Length; column++)
                    {
                        lTable[row, column] = new Label();
                        lTable[row, column].Name = "LLabel" + labelCount.ToString();
                        lTable[row, column].Text = "LLabel" + labelCount.ToString();
                        lTable[row, column].Visible = false;
                        lTable[row, column].AutoSize = true;
                        lTable[row, column].BringToFront();
                        lTable[row, column].Location = new Point(xCoord, yCoord);



                        xCoord += 80;

                        labelCount++;

                        tabPage1.Controls.Add(lTable[row, column]);

                    }
                    yCoord += 20;
                    /*MessageBox.Show("Labels Created Till Now: " + labelCount.ToString());*/
                }
            }
        }

        public bool GenerateFile(string content)
        {
            string fileName = "Shortest_Common_Supersequence.txt";
            string s1 = content;


            Random randomNumber = new Random();
            int randomLength = randomNumber.Next(30, 100);      // generating a random number in the range 30-99

            string new1 = "";
            string new2 = "";

            // generating a random arrangement for string1
            for (int i = 0; i < randomLength; i++)
            {
                new1 += s1[randomNumber.Next(s1.Length)];
            }

            // generating a random arrangement for string2
            for (int i = 0; i < randomLength; i++)
            {
                new2 += s1[randomNumber.Next(s1.Length)];
            }
            File.WriteAllText(fileName, new1 + " " + new2);
            return true;
        }

        private void PerformComputation()
        {
            for (int i = 0; i <= sequence1.Length; i++)
            {
                for (int j = 0; j <= sequence2.Length; j++)
                {
                    // Below steps follow above recurrence
                    if (i == 0 || j == 0)
                    {
                        lTable[i, j].Text = "0";
                        lTable[i, j].Visible = true;
                    }

                    else if (sequence1[i - 1] ==sequence2[j - 1])
                    {
                        lTable[i, j].Text = (Convert.ToInt32(lTable[i - 1, j - 1].Text) + 1).ToString();
                        lTable[i, j].Visible = false;
                    }

                    else
                    {
                        
                        lTable[i, j].Text = (Math.Max(Convert.ToInt32(lTable[i - 1, j].Text), Convert.ToInt32(lTable[i, j-1].Text))).ToString();
                        
                        lTable[i, j].Visible = false;

                    }
                    //dp[i][j] = 1 + min(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }

        private void CompleteIterations()
        {
            for (int i = 0; i <= sequence1.Length; i++)
            {
                for (int j = 0; j <= sequence2.Length; j++)
                {
                    lTable[i, j].Visible = true;
                    lTable[i, j].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                }
            }
        }


        private void intializeGridButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            InitializeGrid();

            intializeGridButton.Visible = false;
            setupEnvironmentButton.Visible = true;
            MessageBox.Show("Grid Initialized");

        }

        private void setupEnvironmentButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = true;
            completeIterationButton.Visible = true;
            MessageBox.Show("Environment Setup Complete");
        }

        private void ComputeUtility(int xCoord, int yCoord)
        {
            lTable[xCoord, yCoord].Visible = true;
            iValue.Text = "Value of i is: " + xCoord.ToString();
            wValue.Text = "Value of j is: " + yCoord.ToString();
            currentPosition.Text = "L[i, j] = L[" + xCoord.ToString() + ", " + yCoord.ToString() + "]";
        }
        private void nextIterationButton_Click(object sender, EventArgs e)
        {
            if (x <= sequence1.Length)
            {
                if (y <= sequence2.Length)
                {
                    ComputeUtility(x, y);
                    if (lTable[x, y - 1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#000"))
                    {
                        lTable[x, y].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    }
                    else
                    {
                        lTable[x, y - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                        lTable[x, y].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
                    }
                    y++;
                }
                else
                {
                    x++;
                    lTable[x - 1, y - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    y = 1;

                    nextIterationButton.PerformClick();
                }
            }
            else
            {
                completeIterationButton.Visible = false;
                nextIterationButton.Visible = false;
                finalOutputButton.Visible = true;
            }
        }

        private void completeIterationButton_Click(object sender, EventArgs e)
        {
            CompleteIterations();
            completeIterationButton.Visible = false;
            nextIterationButton.Visible = false;
            finalOutputButton.Visible = true;
        }

        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            finalOutputButton.Visible = false;
            lengthLabel.Text += (sequence1.Length + sequence2.Length - Convert.ToInt32(lTable[sequence1.Length, sequence2.Length].Text)).ToString();
            backButton.Visible = exitButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen obj = new MainScreen();
            this.Hide();
            obj.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public ShortestCommonSuperSequence()
        {
            InitializeComponent();
            
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = false;
            completeIterationButton.Visible = false;
            finalOutputButton.Visible = false;
        }
    }
}
