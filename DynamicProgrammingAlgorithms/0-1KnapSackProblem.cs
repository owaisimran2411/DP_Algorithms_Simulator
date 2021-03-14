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
    public partial class _0_1KnapSackProblem : Form
    {

        // declaring label array for M table
        private Label[,] mTable;

        // declaring label array for keep table
        private Label[,] keepTable;

        // necessary variables
        private int elementCount=10;
        private int allowedWeight=152;

        // array to hold user provided values and weights
        private string inputValues;
        private string inputWeights;

        private int x = 1, y = 1;

        // private function to read weights, values, element count from file
        private bool ReadFromFile()
        {
            string fileName = "0-1_KnapSack_Problem.txt";
            string fileData = File.ReadAllText(fileName);

            // first line of the file contains element count
            elementCount = Convert.ToInt32(fileData.Split('\n')[0]);

            // second line of the file contains allowed weight
            allowedWeight = Convert.ToInt32(fileData.Split('\n')[1]);

            // allocating size of inputValues and inputWeights array
            /*inputValues = new string[elementCount];
            inputWeights = new string[elementCount];*/

            inputValues = fileData.Split('\n')[2];
            inputValuesTextBox.Text = inputValues.ToString();


            inputWeights = fileData.Split('\n')[3];
            inputWeightsTextBox.Text = inputWeights.ToString();

            string psuedo = "Psuedo_KnapSackProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();


            return true;
        }

        // private function to Initialize M table Grid
        private void GridInitialize()
        {
            int yCoord = 20;

            if (this.mTable == null && this.keepTable == null)    
            {
                
                mTable = new Label[elementCount + 1, allowedWeight + 1];
                keepTable = new Label[elementCount + 1, allowedWeight + 1];

                int labelCount = 0;
                for (int row = 0; row < elementCount+1; row++)
                {
                    int xCoord = 50;   
                    for(int column = 0; column < allowedWeight+1; column++)
                    {
                        mTable[row, column] = new Label();
                        mTable[row, column].Name = "MLabel" + labelCount.ToString();
                        mTable[row, column].Text = "MLabel" + labelCount.ToString();
                        mTable[row, column].Visible = false ;
                        mTable[row, column].AutoSize = true;
                        mTable[row, column].BringToFront();
                        mTable[row, column].Location = new Point(xCoord, yCoord);

                        keepTable[row, column] = new Label();
                        keepTable[row, column].Name = "KLabel" + labelCount.ToString();
                        keepTable[row, column].Text = "KLabel" + labelCount.ToString();
                        keepTable[row, column].Visible = false;
                        keepTable[row, column].AutoSize = true;
                        keepTable[row, column].BringToFront();
                        keepTable[row, column].Location = new Point(xCoord, yCoord);

                        xCoord += 80;

                        labelCount++;

                        tabPage1.Controls.Add(mTable[row, column]);
                        tabPage2.Controls.Add(keepTable[row, column]);
                    }
                    yCoord += 20;
                    /*MessageBox.Show("Labels Created Till Now: " + labelCount.ToString());*/
                }
            }
        }

        private void PerformComputation()
        {
            int i, w;

            for (i = 0; i <= elementCount; i++)
            {
                for (w = 0; w <= allowedWeight; w++)
                {
                    if (i == 0 && w == 0)
                    {
                        mTable[i, w].Visible = false;
                    }
                    if (i == 0 || w == 0)
                    {
                        mTable[i, w].Text = "0";
                        mTable[i, w].Visible = true;

                        keepTable[i, w].Text = "0";
                        keepTable[i, w].Visible = true;
                        // computing keep table

                    }
                    else if (Convert.ToInt32(inputWeights.Split(' ')[i - 1]) <= w)
                    {
                        int val1 = Convert.ToInt32(inputValues.Split(' ')[i - 1]) + Convert.ToInt32(mTable[i - 1, w - Convert.ToInt32(inputWeights.Split(' ')[i - 1])].Text);
                        int val2 = Convert.ToInt32(mTable[i - 1, w].Text);
                        if (val1 > val2)
                        {
                            mTable[i, w].Text = val1.ToString();
                        }
                        else
                        {
                            mTable[i, w].Text = val2.ToString();
                        }
                        mTable[i, w].Visible = false;
                        keepTable[i, w].Visible = false;

                    }
                    else
                    {
                        mTable[i, w].Text = mTable[i - 1, w].Text;
                        mTable[i, w].Visible = false;
                        keepTable[i, w].Visible = false;

                    }

                    
                }
            }
        }
       

        public _0_1KnapSackProblem()
        {
            InitializeComponent();
            performIterationButton.Visible = false;
            completeIterationsButton.Visible = false;
            setupButton.Visible = false;
            finalOutputButton.Visible = false;
        }

        private void performIterationButton_Click(object sender, EventArgs e)
        {
            if (x <= elementCount)
            {

                if (y <= allowedWeight)
                {
                    currentPosition.Text = "K[" + x.ToString() + ", " + y.ToString() + "]";
                    if (mTable[x, y - 1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#000"))
                    {
                        mTable[x, y].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");

                        mTable[x, y].Visible = true;
                    }
                    else
                    {
                        mTable[x, y - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                        mTable[x, y].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
                        if (inputWeights[x - 1] <= y)
                        {
                            conditionBeingExecuted.Text = "if part of pseudo code in execution";
                            conditionCodePart1.Text = "K[ i, w ] = max( value[ i-1 ] + K[ i-1, w - weights[ i-1 ] ], K[ i-1 , w] )";
                            conditionCodePart2.Text = "K[" + x.ToString() + ", " + y.ToString() + "] = " + "max( value[" + (x - 1).ToString() + "] + K[ " + (x - 1).ToString() + ", " + y.ToString() + " - " + inputWeights[x - 1].ToString() + " ], K[" + (x - 1).ToString() + ", " + y.ToString() + " ] )";
                            conditionCodePart3.Text = "K[" + x.ToString() + ", " + y.ToString() + "] = " + "max( " + inputValues[x - 1].ToString() + " + " + Convert.ToInt32(mTable[x - 1, y - inputWeights[x - 1]].Text).ToString() + " , " + mTable[x - 1, y].Text + " )";
                        }
                        else
                        {
                            conditionBeingExecuted.Text = "else part of pseudo code in execution";
                            int prev = x - 1;
                            conditionCodePart1.Text = "K[" + x.ToString() + ", " + y.ToString() + "] = " + "K[" + prev.ToString() + ", " + y.ToString() + "]";
                            conditionCodePart2.Text = "";
                            conditionCodePart3.Text = "";
                        }
                        mTable[x, y].Visible = true;
                    }
                    iValue.Text = "value of i = " + x.ToString();
                    wValue.Text = "value of w = " + y.ToString();
                    y++;
                }
                else
                {
                    x++;
                    mTable[x - 1, y - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    y = 1;
                    performIterationButton.PerformClick();
                }
            }
            else
            {
                performIterationButton.Visible = false;
                completeIterationsButton.Visible = false;
                finalOutputButton.Visible = true;

            }
        }

        private void completeIterationsButton_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for(i=1; i<=elementCount; i++)
            {
                for(j=1; j<=allowedWeight; j++)
                {
                    mTable[i, j].Visible = true;
                    mTable[i, j].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
                }
            }
            performIterationButton.Visible = false;
            completeIterationsButton.Visible = false;
            finalOutputButton.Visible = true;
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            MessageBox.Show("Necessary Processing Done");
            performIterationButton.Visible = true;
            completeIterationsButton.Visible = true;
            setupButton.Visible = false;
        }

        private void KeepTable()
        {
            for(int i=1; i<=elementCount; i++)
            {
                for(int j=1; j<=allowedWeight; j++)
                {
                    if(Convert.ToInt32(mTable[i - 1, j].Text) == Convert.ToInt32(mTable[i,j].Text))
                    {
                        keepTable[i, j].Text = "0";
                        
                    }
                    else
                    {
                        keepTable[i, j].Text = "1";
                    }
                    keepTable[i, j].Visible = true;
                }
            }

            int finalWeight = Convert.ToInt32(mTable[elementCount, allowedWeight].Text);
            

            int weight = allowedWeight;
            string finalResult = "";

            for(int i=elementCount; i>0 && finalWeight>0; i--)
            {
                if(finalWeight == Convert.ToInt32(mTable[i - 1, weight].Text))
                {
                    continue;
                }
                else
                {
                    finalResult += "Element Value: " + inputValues.Split(' ')[i - 1].ToString() + ", Element Weight: " + inputWeights.Split(' ')[i - 1].ToString() + "\n";
                    finalWeight -= Convert.ToInt32(inputValues.Split(' ')[i - 1]);
                    weight -= Convert.ToInt32(inputWeights.Split(' ')[i - 1]);
                }
            }
            richTextBox1.Text = (finalResult + "\nTotal Value: " + mTable[elementCount, allowedWeight].Text);
            
        }
        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            KeepTable();
            finalOutputButton.Visible = false;
            backButton.Visible = true;
            exitButton.Visible = true;
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainWindow = new MainScreen();
            mainWindow.Show();
        }

        private void initializeGridButton_Click(object sender, EventArgs e)            
        {
            if(ReadFromFile())
            {
                Label inputs = new Label();
                inputs.Text = inputValues;
                tabPage3.Controls.Add(inputs);
                inputs.Text = inputWeights;
                tabPage4.Controls.Add(inputs);
                inputs.Text = elementCount.ToString();
                tabPage5.Controls.Add(inputs);
                GridInitialize();
                MessageBox.Show("Grid Initialized");
            }
            else
            {
                /*labelA.Text = "Unable To Read From File";*/
            }

            initializeGridButton.Visible = false;
            setupButton.Visible = true;
        }
    }
}
