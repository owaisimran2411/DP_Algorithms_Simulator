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
    public partial class RodCuttingProblem : Form
    {
        private Label[] mTable;

        private int elementCount = 10;
        private int rodLength = 152;

        private string inputValues;
        private string inputWeights;

        private int x = 1, y = 1;

        private bool ReadFromFile()
        {
            string fileName = "Rod_Cutting_Problem.txt";
            string fileData = File.ReadAllText(fileName);

            // first line of the file contains element count
            elementCount = Convert.ToInt32(fileData.Split('\n')[0]);

            // second line of the file contains allowed weight
            /*allowedWeight = Convert.ToInt32(fileData.Split('\n')[1]);*/

            // allocating size of inputValues and inputWeights array
            /*inputValues = new string[elementCount];
            inputWeights = new string[elementCount];*/

            inputValues = fileData.Split('\n')[1];
            inputValuesTextBox.Text = inputValues.ToString();


            inputWeights = fileData.Split('\n')[2];
            inputWeightsTextBox.Text = inputWeights.ToString();

            label2.Text = elementCount.ToString();

            string psuedo = "Psuedo_RodCuttingProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();


            return true;
        }

        private void GridInitialize()
        {
            int yCoord = 20;

            if (this.mTable == null)
            {

                mTable = new Label[elementCount + 1];
                /*keepTable = new Label[elementCount + 1, allowedWeight + 1];*/

                int labelCount = 0;
                int xCoord = 50;
                for(int row=0; row< elementCount + 1; row++)
                {
                    mTable[row] = new Label();
                    mTable[row].Name = "label" + labelCount.ToString();
                    labelCount++;
                    mTable[row].Text = "0";
                    mTable[row].Visible = false;
                    mTable[row].BringToFront();
                    mTable[row].Location = new Point(xCoord, yCoord);
                    mTable[row].AutoSize = true;
                    tabPage1.Controls.Add(mTable[row]);
                    xCoord += 80;
                }
            }
        }

        private void PerformComputation()
        {
        
            // code here
            for (int i = 1; i <=elementCount ; i++)
            {
                // divide the rod of length i into two rods of length j
                // and i-j each and take maximum
                for (int j = 1; j <= i; j++)
                {
                    int a = Convert.ToInt32(mTable[i - j].Text);
                    int sum = Convert.ToInt32(inputValues.Split(' ')[j - 1]) +a;
                    int b = Convert.ToInt32(mTable[i].Text);
                    mTable[i].Text = Math.Max(b, sum).ToString();
                   
                }
                //mTable[i].Visible = true;
                //
            }
            mTable[0].Visible = true;
        
        }

        private void ComputeUtility(int xCoord)
        {
            mTable[xCoord].Visible = true;
            mTable[xCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
            if (mTable[xCoord-1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#B92100"))
            {
                mTable[xCoord - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
        }
        private void initializeGridButton_Click(object sender, EventArgs e)
        {
            if (ReadFromFile())
            {
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

        private void setupButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            MessageBox.Show("Necessary Processing Done");
            performIterationButton.Visible = true;
            completeIterationsButton.Visible = true;
            setupButton.Visible = false;
        }

        private void performIterationButton_Click(object sender, EventArgs e)
        {
            if(x<=rodLength)
            {
                if(y<=x)
                {
                    iValue.Text = "Value of i = " + x.ToString();
                    wValue.Text = "Value of j = " + y.ToString();
                    currentPosition.Text = "T[ i ] = T[ " + x.ToString() + "]";
                    ComputeUtility(x);
                    y++;
                }
                else
                {
                    x++;
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
        private void CompleteIterations()
        {
            for(int i=0; i<=elementCount; i++)
            {
                mTable[i].Visible = true;
                mTable[i].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
        }

        private void completeIterationsButton_Click(object sender, EventArgs e)
        {
            CompleteIterations();
            performIterationButton.Visible = false;
            completeIterationsButton.Visible = false;
            finalOutputButton.Visible = true;
        }

        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            finalOutputButton.Visible = false;
            label1.Text += mTable[elementCount].Text;
            exitButton.Visible = true;
            backButton.Visible = true;
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

        

        public RodCuttingProblem()
        {
            InitializeComponent();

            performIterationButton.Visible = false;
            completeIterationsButton.Visible = false;
            setupButton.Visible = false;
            finalOutputButton.Visible = false;
        }
    }
}
