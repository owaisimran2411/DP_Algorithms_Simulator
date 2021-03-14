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
    public partial class InputKnapSack : Form
    {
        private int elementCount = 0;
        private string inputValues = "";
        private string inputWeights = "";
        private int allowedWeight = 0;
        public InputKnapSack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            elementCount = Convert.ToInt32(textBox1.Text);

            button2.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;

            button1.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Split(' ').Length == elementCount)
            {
                button3.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;

                textBox2.ReadOnly = true;
                inputValues = textBox2.Text;

                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("You have provided: " + textBox2.Text.Split(' ').Length.ToString() + " value input\nprovide " + (elementCount - textBox2.Text.Split(' ').Length).ToString() + " more input");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Split(' ').Length == elementCount)
            {

                textBox3.ReadOnly = true;
                inputWeights = textBox3.Text;

                button3.Visible = false;
                button4.Visible = label5.Visible = textBox4.Visible = true;
            }
            else
            {
                MessageBox.Show("You have provided: " + textBox3.Text.Split(' ').Length.ToString() + " value input\nprovide " + (elementCount - textBox3.Text.Split(' ').Length).ToString() + " more input");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            allowedWeight = Convert.ToInt32(textBox4.Text);
            button4.Visible = false;
            textBox4.ReadOnly = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            string fileName = "0-1_KnapSack_Problem.txt";
            File.WriteAllText(fileName, elementCount.ToString() + '\n' + allowedWeight.ToString() + '\n' + inputValues + '\n' + inputWeights);
            algoButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen obj = new MainScreen();
            this.Hide();
            obj.Show();
        }

        private void algoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _0_1KnapSackProblem newWindow = new _0_1KnapSackProblem();
            newWindow.Show();
        }
    }
}
