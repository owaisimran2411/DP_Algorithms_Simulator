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
    public partial class ChainMatrixMultiplication : Form
    {

        private Label[,] mTable;        // array for storing number of operation
        private Label[,] kTable;        // array for storing K values

        private int numberMatrices;     // variable to hold count of number of matrices
        private int[] dimensions;       // variable to hold dimension of matrices


        private int x = 1, y=0;
        private int step = 2;
        private bool ReadFromFile()
        {
            string fileName = "Chain_Matrix.txt";
            string fileData = File.ReadAllText(fileName);

            numberMatrices = fileData.Split(' ').Length - 1;

            dimensions = new int[numberMatrices+1];

            for(int i=0; i<=numberMatrices; i++)
            {
                dimensions[i] = Convert.ToInt32(fileData.Split(' ')[i]);
                inputDimensionsTextBox.Text += fileData.Split(' ')[i].ToString() + " ";
            }

            /*for(int i=0; i<=numberMatrices; i++)
            {
                label1.Text += dimensions[i].ToString() + " ";
            }*/

            string psuedo = "Pseudo_ChainMatrixProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            return true;
        }

        private void GridInitialize()
        {
            int yCoord = 20;
            if (this.mTable == null && this.kTable == null)
            {

                label2.Text = numberMatrices.ToString();
                mTable = new Label[numberMatrices+1, numberMatrices+1];
                kTable = new Label[numberMatrices+1, numberMatrices+1];

                int labelCount = 0;
                for (int row = 0; row < numberMatrices+1; row++)
                {
                    int xCoord = 50;
                    for (int column = 0; column < numberMatrices+1; column++)
                    {
                        mTable[row, column] = new Label();
                        mTable[row, column].Name = "MLabel" + labelCount.ToString();
                        mTable[row, column].Text = "MLabel" + labelCount.ToString();
                        mTable[row, column].Visible = false;
                        mTable[row, column].AutoSize = true;
                        mTable[row, column].BringToFront();
                        mTable[row, column].Location = new Point(xCoord, yCoord);

                        kTable[row, column] = new Label();
                        kTable[row, column].Name = "KLabel" + labelCount.ToString();
                        kTable[row, column].Text = "KLabel" + labelCount.ToString();
                        kTable[row, column].Visible = false;
                        kTable[row, column].AutoSize = true;
                        kTable[row, column].BringToFront();
                        kTable[row, column].Location = new Point(xCoord, yCoord);

                        xCoord += 80;

                        labelCount++;

                        tabPage1.Controls.Add(mTable[row, column]);
                        tabPage2.Controls.Add(kTable[row, column]);
                    }
                    yCoord += 20;
                    /*MessageBox.Show("Labels Created Till Now: " + labelCount.ToString());*/
                }
            }

        }

        private void PerformComputation()
        {
            for (int i = 1; i < numberMatrices+1; i++)
            {
                mTable[i, i].Text = "0";
                mTable[i,i].Visible = true;
            }

            int q;
            // L is chain length. 
            for (int L = 2; L < numberMatrices+1; L++)
            {
                for (int i = 1; i < numberMatrices + 1 - L + 1; i++)
                {
                    int j = i + L - 1;
                    mTable[i, j].Text = Int32.MaxValue.ToString();
                    for (int k = i; k <= j - 1; k++)
                    {
                        // q = cost/scalar multiplications 
                        q = Convert.ToInt32(mTable[i, k].Text) + Convert.ToInt32(mTable[k + 1, j].Text) + dimensions[i - 1] * dimensions[k] * dimensions[j];
                        if (q < Convert.ToInt32(mTable[i, j].Text))
                        {
                            mTable[i, j].Text = q.ToString();
                            mTable[i, j].Visible = false;

                            kTable[i, j].Text = k.ToString();
                            kTable[i, j].Visible = false;
                        }
                    }
                }
            }
        }

        private void CompleteIterations()
        {
            for (int L = 2; L < numberMatrices + 1; L++)
            {
                for (int i = 1; i < numberMatrices + 1 - L + 1; i++)
                {
                    int j = i + L - 1;
                    mTable[i, j].Visible = true;
                    mTable[i, j].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    kTable[i, j].Visible = true;
                }
            }
        }

        private void VisibleUtility(int xCoord, int yCoord) 
        {
            

            if(mTable[xCoord-1, yCoord-1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#000"))
            {
                mTable[xCoord, yCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
            else
            {
                mTable[xCoord-1, yCoord - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                mTable[xCoord, yCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
            }
            mTable[xCoord, yCoord].Visible = true;
            kTable[xCoord, yCoord].Visible = true;

        }
        public ChainMatrixMultiplication()
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
            MessageBox.Show("Environment Setup Completed");
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = true;
            completeIterationButton.Visible = true;
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
            operationsLabel.Text += mTable[1, numberMatrices].Text;
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
            if(step<numberMatrices+1)
            {
                if(x<numberMatrices+1-step+1)
                {
                    y = x + step - 1;
                    iValue.Text = "value of i = " + x.ToString();
                    wValue.Text = "value of j = " + y.ToString();
                    currentPosition.Text = "M[" + x.ToString() + ", " + y.ToString() + "]";
                    int kValuesPossible = y - x;
                    kValueLabel1.Text = kValuesPossible.ToString();
                    textBox1.ReadOnly = true;
                    textBox1.Text = "";
                    
                    for(int p=x; p<y; p++)
                    {
                        
                        textBox1.Text += p.ToString() + " ";                      
                    }
                    VisibleUtility(x, y);
                    x++;
                }
                else
                {
                    step++;
                    x = 1;
                    nextIterationButton.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("completed");
                nextIterationButton.Visible = false;
                completeIterationButton.Visible = false;
                finalOutputButton.Visible = true;
            }
        }
    }
}
