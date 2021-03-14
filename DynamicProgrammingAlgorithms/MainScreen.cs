using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicProgrammingAlgorithms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>-1)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    this.Hide();
                    LongestCommonSubsequence newWindow = new LongestCommonSubsequence();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    this.Hide();
                    ShortestCommonSuperSequence newWindow = new ShortestCommonSuperSequence();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    this.Hide();
                    LevenshetinEditDistance newWindow = new LevenshetinEditDistance();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    this.Hide();
                    LongestIncreasingSubsequence newWindow = new LongestIncreasingSubsequence();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    this.Hide();
                    ChainMatrixMultiplication newWindow = new ChainMatrixMultiplication();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    this.Hide();
                    _0_1KnapSackProblem newWindow = new _0_1KnapSackProblem();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    this.Hide();
                    PartitionProblem newWindow = new PartitionProblem();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    this.Hide();
                    RodCuttingProblem newWindow = new RodCuttingProblem();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    this.Hide();
                    CoinChangeMakingProblem newWindow = new CoinChangeMakingProblem();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    this.Hide();
                    WordBreakProblem newWindow = new WordBreakProblem();
                    newWindow.Show();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    this.Hide();
                    InputLongestCommonSubsequence newWindow = new InputLongestCommonSubsequence();
                    newWindow.Show();
                }
                else if(comboBox1.SelectedIndex == 1) 
                {
                    this.Hide();
                    InputShortestCommonSupersequence newWindow = new InputShortestCommonSupersequence();
                    newWindow.Show();
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    this.Hide();
                    InputEditDistance newWindow = new InputEditDistance();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    this.Hide();
                    InputLongestIncreasingSubSequence newWindow = new InputLongestIncreasingSubSequence();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    this.Hide();
                    InputChainMatrix newWindow = new InputChainMatrix();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    this.Hide();
                    InputKnapSack newWindow = new InputKnapSack();
                    newWindow.Show();
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    this.Hide();
                    InputPartitionProblem newWindow = new InputPartitionProblem();
                    newWindow.Show();
                }
                

            }
        }
    }
}
