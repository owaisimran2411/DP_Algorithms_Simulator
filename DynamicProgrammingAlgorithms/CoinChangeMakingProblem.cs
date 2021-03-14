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
    public partial class CoinChangeMakingProblem : Form
    {
        private Label[] lTable;

        private int[] series;
        private int seriesLength;

        private int desiredChange = 152;

        private int x = 1, y = 0;
        
        private bool ReadFromFile()
        {
            string fileName = "Coin_Change.txt";
            string fileData = File.ReadAllText(fileName);

            seriesLength = fileData.Split(' ').Length;

            series = new int[seriesLength];
            for (int i = 0; i < seriesLength; i++)
            {
                series[i] = Convert.ToInt32(fileData.Split(' ')[i]);
                inputCoinsTextBox.Text += series[i].ToString() + " ";
            }

            label1.Text = desiredChange.ToString();

            string psuedo = "Pseudo_CoinChangeMakingProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            return true;
        }

        private void GridInitialize()
        {
            int yCoord = 20;
            if(this.lTable == null)
            {
                lTable = new Label[desiredChange+1];
                int labelCount = 0;
                int xCoord = 50;
                for (int column = 0; column <= desiredChange; column++)
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

        private void PerformComputation()
        {
            lTable[0].Text = "0";
            lTable[0].Visible = true;
            
            for(int i=1; i<= desiredChange; i++)
            {
                lTable[i].Text = Int32.MaxValue.ToString();
                int result = Int32.MaxValue;
                for (int c=0; c<seriesLength; c++)
                {
                    if(i-series[c]>=0)
                    {
                        result = Convert.ToInt32(lTable[i - series[c]].Text);
                    }

                    if(result != Int32.MaxValue)
                    {
                        lTable[i].Text = (Math.Min(Convert.ToInt32(lTable[i].Text), result + 1)).ToString();
                    }
                }
            }
        }
        private void ComputeUtility(int xCoord)
        {
           
            if(lTable[xCoord-1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#B92100"))
            {
                lTable[xCoord - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
            lTable[xCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
            lTable[xCoord].Visible = true;
        }
        private void nextIterationButton_Click(object sender, EventArgs e)
        {
            if (x <= desiredChange)
            {
                
                if(y<seriesLength)
                {
                    currentPosition.Text = "L[" + x.ToString() + "]";
                    iValue.Text = "value of i = " + x.ToString();
                    wValue.Text = "value of c = " + y.ToString();
                    ComputeUtility(x);
                    y++;
                }
                else
                {
                    x++;
                    y = 0;
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

        private void CompleteIterations()
        {
            for(int i=0; i<=desiredChange; i++)
            {
                lTable[i].Visible = true;
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
            if(Convert.ToInt32(lTable[desiredChange].Text) != Int32.MaxValue)
            {
                lengthLabel.Text += lTable[desiredChange].Text;
            }
            else
            {
                lengthLabel.Text = "Not Possible";
            }
            backButton.Visible = true;
            exitButton.Visible = true;
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

        public CoinChangeMakingProblem()
        {
            InitializeComponent();

            finalOutputButton.Visible = false;
            nextIterationButton.Visible = false;
            completeIterationButton.Visible = false;
            setupEnvironmentButton.Visible = false;
        }
    }
}
