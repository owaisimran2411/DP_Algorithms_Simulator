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
    public partial class WordBreakProblem : Form
    {

        private Label[] table;
        private static Random random = new Random((int)DateTime.Now.Ticks);

        private string word = "muhammadowais";
        private int dictionaryWordCount = 0;


        private string[] dictionary;

        private int x = 1;
        private int y = 2;
        private bool GenerateFile()
        {
            string validCharacters = "abcdefghijklmnopqrstuvwxyz";

            string[] dictionaryArray = new string[55];


            string fileName = "Word_Break_Problem.txt";
            
            for(int i=0; i<55; i++)
            {
                
                int randomLength = random.Next(5, 16);
                string word = "";
                for(int j=0; j<randomLength; j++)
                {
                    word += validCharacters[random.Next(validCharacters.Length)];
                }
                dictionaryArray[i] = word;
            }

            File.WriteAllLines(fileName, dictionaryArray);
            return true;
        }

        private void ReadFromFile()
        {
            string fileName = "Word_Break_Problem.txt";
            string fileData = File.ReadAllText(fileName);

            dictionaryWordCount = fileData.Split('\n').Length - 1;

            dictionary = new string[dictionaryWordCount];

            
           
            string msg = "";
            for (int i = 0; i < dictionaryWordCount; i++)
            {
                dictionary[i] = fileData.Split('\n')[i];
                msg += dictionary[i];
                
            }

            string psuedo = "Psuedo_WordBreakProblem.txt";
            string psuedoData = File.ReadAllText(psuedo);
            psuedoTextBox.Text = psuedoData.ToString();

            inputCoinsTextBox.Text = msg;

        }

        private void InitializeGrid()
        {
            int yCoord = 20;
            if(this.table == null)
            {
                table = new Label[word.Length + 1];
                int labelCount = 0;
                int xCoord = 50;
                for(int row=0; row < word.Length + 1; row++)
                {
                    table[row] = new Label();
                    table[row].Name = "table" + labelCount.ToString();
                    table[row].Text = "0";
                    table[row].Visible = false;
                    table[row].AutoSize = true;
                    table[row].BringToFront();
                    table[row].Location = new Point(xCoord, yCoord);
                    xCoord += 50;
                    labelCount++;
                    tabPage1.Controls.Add(table[row]);
                }
            }
        }
        public WordBreakProblem()
        {
            InitializeComponent();
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = false;
            completeIterationButton.Visible = false;
            finalOutputButton.Visible = false;
            
        }

        private void intializeGridButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            InitializeGrid();

            intializeGridButton.Visible = false;
            setupEnvironmentButton.Visible = true;
            MessageBox.Show("Grid Initialized");
        }

        private bool PerformComputation()
        {
            for(int i=1; i<=word.Length; i++)
            {
                /*table[i].Visible = true;*/
                if(table[i].Text == "0" && SearchDictionary(word.Substring(0,i)))
                {
                    table[i].Text = "1";
                }

                if(table[i].Text == "1")
                {
                    if(i==word.Length)
                    {
                        nextIterationButton.Visible = false;
                        completeIterationButton.Visible = false;
                        
                        lengthLabel.Text += "Possible";
                        return true;
                    }

                    for(int j=i+1; j<= word.Length; j++)
                    {
                        if(table[j].Text == "0" && SearchDictionary(word.Substring(i,j-i)))
                        {
                            table[j].Text = "1";
                        }

                        if(j==word.Length && table[j].Text == "1")
                        {
                            nextIterationButton.Visible = false;
                            completeIterationButton.Visible = false;
                            
                            lengthLabel.Text += "Possible";
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void setupEnvironmentButton_Click(object sender, EventArgs e)
        {
            PerformComputation();
            setupEnvironmentButton.Visible = false;
            nextIterationButton.Visible = true;
            completeIterationButton.Visible = true;
            
            MessageBox.Show("Environment Setup Complete");
        }
        private bool SearchDictionary(string element)
        {
            
            
            for(int i=0; i<dictionaryWordCount; i++)
            {
                
                
                if(element == dictionary[i].Substring(0, dictionary[i].Length - 1))
                {
                    
                    return true;
                }
            }
            return false;
        }
        private void ComputeUtility(int xCoord)
        {
            table[xCoord].Visible = true;
            table[xCoord].ForeColor = System.Drawing.ColorTranslator.FromHtml("#B92100");
            if (table[xCoord - 1].ForeColor == System.Drawing.ColorTranslator.FromHtml("#B92100")) 
            {
                table[xCoord - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
        }
        private void nextIterationButton_Click(object sender, EventArgs e)
        {
            if(x<=word.Length)
            {
                ComputeUtility(x);
                if (table[x].Text == "1")
                {
                    iValue.Text = "Value of i = " + x.ToString();
                    wValue.Text = "Value of j = " + y.ToString();
                    currentPosition.Text = "L[i] = L[" + x.ToString() + "]";
                    if (y<=word.Length)
                    {
                        y++;
                    }
                    else
                    {
                        x++;
                        y = x + 1;
                        nextIterationButton.PerformClick();
                    }
                }
                else
                {
                    iValue.Text = "Value of i = " + x.ToString();
                    wValue.Text = "";
                    x++;
                    y = x + 1;
                    /*nextIterationButton.PerformClick();*/
                    
                }
                
            }
            else
            {
                completeIterationButton.Visible = false;
                nextIterationButton.Visible = false;
                finalOutputButton.Visible = true;
            }
        }

        private void finalOutputButton_Click(object sender, EventArgs e)
        {
            lengthLabel.Visible = true;
            finalOutputButton.Visible = false;
            backButton.Visible = exitButton.Visible = true;
        }

        private void completeIterationButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<word.Length; i++)
            {
                table[i].Visible = true;
                table[i].ForeColor = System.Drawing.ColorTranslator.FromHtml("#000");
            }
            completeIterationButton.Visible = false;
            nextIterationButton.Visible = false;
            finalOutputButton.Visible = true;
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
    }
}
