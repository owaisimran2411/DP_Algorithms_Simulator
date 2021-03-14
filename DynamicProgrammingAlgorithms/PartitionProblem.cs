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
    public partial class PartitionProblem : Form
    {
        private Label[,] partition;

        private int[] series;
        private int seriesLength;

        private int sum = 0;

        private int xCoord = 50, yCoord = 20;
        private int labelCount = 0;

        private int x = 1, y = 1;

        private bool ReadFromFile()
        {
            string fileName = "Partition_Making_Problem.txt";
            string fileData = File.ReadAllText(fileName);

            seriesLength = fileData.Split(' ').Length;

            series = new int[seriesLength];
            for (int i = 0; i < seriesLength; i++)
            {
                series[i] = Convert.ToInt32(fileData.Split(' ')[i]);
                inputCoinsTextBox.Text += series[i].ToString() + " ";
            }

            string psuedo = "Psuedo_PartitionProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            return true;
        }

        private bool GridInitialize()
        {
            ReadFromFile();
            
            if(this.partition == null)
            {
                for(int i=0; i<seriesLength; i++)
                {
                    sum += series[i];
                }
            }

            if(sum % 2 != 0)
            {
                return false;
            }
            int rows = sum / 2;
            /*MessageBox.Show(rows.ToString());*/
            partition = new Label[rows+1, seriesLength + 1];

            
            /*for (int row = 0; row <= rows ; row++)
            {
                
                for (int column = 0; column <= seriesLength; column++)
                {
                    partition[row, column] = new Label();
                    partition[row, column].Name = "pLabel" + labelCount.ToString();
                    partition[row, column].Text = "pLabel" + labelCount.ToString();
                    partition[row, column].Visible = true;
                    partition[row, column].AutoSize = true;
                    partition[row, column].BringToFront();
                    partition[row, column].Location = new Point(xCoord, yCoord);



                    xCoord += 80;

                    labelCount++;

                    tabPage1.Controls.Add(partition[row, column]);

                }
                yCoord += 20;
                MessageBox.Show("Labels Created Till Now: " + labelCount.ToString());
            }*/
            
            return true;
        }
        public PartitionProblem()
        {
            InitializeComponent();

            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = false;
            completeIterationButton.Visible = false;
            finalOutputButton.Visible = false;
        }


        private void PerformComputation()
        {
            for (int row = 0; row <= seriesLength; row++)
            {
                partition[0, row] = new Label();
                partition[0, row].Name = "pLabel" + labelCount.ToString();
                partition[0, row].Text = "1";
                partition[0, row].Visible = true;
                partition[0, row].AutoSize = true;
                partition[0, row].BringToFront();
                partition[0, row].Location = new Point(xCoord, yCoord);



                xCoord += 80;

                labelCount++;

                tabPage1.Controls.Add(partition[0, row]);
            }

            xCoord = 50;
            yCoord += 20;
            for(int column = 1; column<=sum/2; column++)
            {
                partition[column, 0] = new Label();
                partition[column, 0].Name = "pLabel" + labelCount.ToString();
                partition[column, 0].Text = "0";
                partition[column, 0].Visible = true;
                partition[column, 0].AutoSize = true;
                partition[column, 0].BringToFront();
                partition[column, 0].Location = new Point(xCoord, yCoord);
                yCoord += 20;
                labelCount++;
                tabPage1.Controls.Add(partition[column, 0]);
            }
            xCoord = 130;
            yCoord = 40;
        }

        private void setupEnvironmentButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            nextIterationButton.Visible = true;
            completeIterationButton.Visible = true;
            setupEnvironmentButton.Visible = false;
        }

        private void ComputeUtility(int xValue, int yValue)
        {
            if(xValue >= series[yValue-1])
            {
                
                if(partition[xValue, yValue].Text == "1")
                {
                    partition[xValue, yValue].Text = partition[xValue, yValue].Text;
                }
                if(partition[xValue - series[yValue - 1], yValue - 1].Text == "1")
                {
                    partition[xValue, yValue].Text = partition[xValue - series[yValue - 1], yValue - 1].Text;
                }
            }
        }

        private void CompleteIterations()
        {
            while(nextIterationButton.Visible==true)
            {
                nextIterationButton.PerformClick();
            }
        }
        private void completeIterationButton_Click(object sender, EventArgs e)
        {
            CompleteIterations();
        }

        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            if(partition[sum/2, seriesLength].Text == "1")
            {
                lengthLabel.Text += "Division is Possible";
            }
            else
            {
                lengthLabel.Text += "Division is not Possible";
            }
            finalOutputButton.Visible = false;
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

        private void nextIterationButton_Click(object sender, EventArgs e)
        {
            if(x<=sum/2)
            {
                if(y<=seriesLength)
                {
                    iValue.Text = "Value of i= " + x.ToString();
                    wValue.Text = "Value of j= " + y.ToString();
                    currentPosition.Text = "L[" + x.ToString() + ", " + y.ToString() + "]";

                    partition[x, y] = new Label();
                    partition[x, y].Name = "pLabel" + labelCount.ToString();
                    labelCount++;
                    partition[x, y].Text = partition[x, y - 1].Text;
                    partition[x, y].Visible = true;
                    partition[x, y].AutoSize = true;
                    partition[x, y].BringToFront();
                    partition[x, y].Location = new Point(partition[x-1,y-1].Location.X + 80, partition[x - 1, y - 1].Location.Y + 20);
                    tabPage1.Controls.Add(partition[x, y]);
                    ComputeUtility(x, y);
                    y++;
                    xCoord += 80;
                   
                }
                else
                {
                    xCoord = 130;
                    yCoord += 20;
                    x++;
                    y = 1;
                    nextIterationButton.PerformClick(); 
                }
            }
            else
            {
                
                nextIterationButton.Visible = false;
                completeIterationButton.Visible = false;
                finalOutputButton.Visible = true;
            }
        }

        private void intializeGridButton_Click(object sender, EventArgs e)
        {
            if(GridInitialize())
            {
                setupEnvironmentButton.Visible = true;
                MessageBox.Show("Grid Initialized");
            }
            else
            {

                lengthLabel.Text += "Not Possible as sum of array is not even!";
            }
            intializeGridButton.Visible = false;
        }
    }
}
