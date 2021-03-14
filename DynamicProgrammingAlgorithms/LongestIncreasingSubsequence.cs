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
    public partial class LongestIncreasingSubsequence : Form
    {
        private Label[] lTable;

        private int[] series;
        private int seriesLength;

        private int x = 1, y = 0;
        private bool ReadFromFile()
        {
            string fileName = "Longest_Increasing_Subsequence.txt";
            string fileData = File.ReadAllText(fileName);

            seriesLength = fileData.Split(' ').Length;

            series = new int[seriesLength];
            for(int i=0; i<seriesLength; i++)
            {
                series[i] = Convert.ToInt32(fileData.Split(' ')[i]);
                inputCoinsTextBox.Text += series[i].ToString() + " ";
            }

            string psuedo = "Psuedo_LongestIncreasingSubsequenceProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            return true;
        }
        private void GridInitialize()
        {
            int yCoord = 20;
            if(this.lTable == null)
            {
                lTable = new Label[seriesLength];
                int labelCount = 0;
                int xCoord = 50;
                for(int column=0; column<seriesLength; column++)
                {
                    lTable[column] = new Label();
                    lTable[column].Name = "lLabel" + labelCount.ToString();
                    lTable[column].Text = "lLabel" + labelCount.ToString();
                    lTable[column].Visible = false;
                    lTable[column].AutoSize = true;
                    lTable[column].BringToFront();
                    lTable[column].Location = new Point(xCoord, yCoord);
                    xCoord += 80;
                    tabPage1.Controls.Add(lTable[column]);
                    labelCount++;
                }
            }
        }
        private void PerformComputation()
        {
            lTable[0].Text = "1";
            lTable[0].Visible = true;

            /*for(int i=1; i<seriesLength; i++)
            {
                lTable[i].Text = "1";
                for(int j=0; j<i; j++)
                {
                    if(series[i] > series[j] && Convert.ToInt32(lTable[i].Text) < Convert.ToInt32(lTable[j].Text) + 1)
                    {
                        lTable[i].Text = (Convert.ToInt32(lTable[j].Text) + 1).ToString();
                    }
                }
            }*/
        }

        private void CompleteIterations()
        {
            for (int i = 1; i < seriesLength; i++)
            {
                lTable[i].Text = "1";
                lTable[i].Visible = true;
                lTable[i].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                for (int j = 0; j < i; j++)
                {
                    if (series[i] > series[j] && Convert.ToInt32(lTable[i].Text) < Convert.ToInt32(lTable[j].Text) + 1)
                    {
                        lTable[i].Text = (Convert.ToInt32(lTable[j].Text) + 1).ToString();
                    }
                }
            }
        }

        private void ComputeUtility(int xCoord, int yCoord)
        {
            lTable[xCoord].Text = "1";
            lTable[xCoord].Visible = true;
            if (series[xCoord] > series[yCoord] && Convert.ToInt32(lTable[xCoord].Text) < Convert.ToInt32(lTable[yCoord].Text) + 1)
            {
                conditionalCodePart3.Text = "L[" + xCoord.ToString() + "] = L[" + yCoord.ToString() + "] + 1";
                lTable[xCoord].Text = (Convert.ToInt32(lTable[yCoord].Text) + 1).ToString();
                conditionalCodePart4.Text = "L[" + xCoord.ToString() + "] = " + (Convert.ToInt32(lTable[yCoord].Text) + 1).ToString();
            }
            else
            {
                conditionalCodePart3.Text = conditionalCodePart4.Text ="";
            }
            lTable[xCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
            if (lTable[xCoord-1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#B92100"))
            {
                lTable[xCoord-1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
        }

        public LongestIncreasingSubsequence()
        {
            InitializeComponent();

            finalOutputButton.Visible = false;
            nextIterationButton.Visible = false;
            completeIterationButton.Visible = false;
            setupEnvironmentButton.Visible = false;
        }

        private void intializeGridButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            GridInitialize();
            MessageBox.Show("Grid Initialized");
            intializeGridButton.Visible = false;
            setupEnvironmentButton.Visible = true;
        }

        private void setupEnvironmentButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = true;
            completeIterationButton.Visible = true;
            MessageBox.Show("Environment Setup Complete");
        }

        private void completeIterationButton_Click(object sender, EventArgs e)
        {
            CompleteIterations();
            completeIterationButton.Visible = false;
            nextIterationButton.Visible = false;
            finalOutputButton.Visible = true;
        }

        private void nextIterationButton_Click(object sender, EventArgs e)
        {
            if(x<seriesLength)
            {
                if(y<x)
                {
                    conditionalCodePart1.Text = "series[i] > series[j] && L[i] < L[j]+1";
                    conditionalCodePart2.Text = "series[" + x.ToString() + "] > series[" + y.ToString() + "] && L[" + x.ToString() + "] < L[" + y.ToString() + "] + 1";
                    iValue.Text = "Value of i= " + x.ToString();
                    wValue.Text = "Value of j= " + y.ToString();
                    currentPosition.Text = "L[" + x.ToString() + "]";
                    ComputeUtility(x, y);
                    y++;
                }
                else
                {
                    y = 0;
                    x++;
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

        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            finalOutputButton.Visible = false;
            int maximum = Convert.ToInt32(lTable[0].Text);
            for(int i=1; i<seriesLength; i++)
            {
                if(maximum<Convert.ToInt32(lTable[i].Text))
                {
                    maximum = Convert.ToInt32(lTable[i].Text);
                }
            }
            lengthLabel.Text += maximum.ToString();
            backButton.Visible = true;
            exitButton.Visible = true;
        }
    }
}
