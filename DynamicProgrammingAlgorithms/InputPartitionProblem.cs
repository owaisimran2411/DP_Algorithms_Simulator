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
    public partial class InputPartitionProblem : Form
    {
        private int matrixCount = 0;
        private string dimension = "";
        public InputPartitionProblem()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen obj = new MainScreen();
            obj.Show();
        }

        private void algoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PartitionProblem newWindow = new PartitionProblem();
            newWindow.Show();
        }

        private void numberMatricesButton_Click(object sender, EventArgs e)
        {
            matrixCount = Convert.ToInt32(textBox1.Text);

            label3.Visible = textBox2.Visible = true;

            numberMatricesButton.Visible = false;
            textBox1.ReadOnly = true;
            dimensionButton.Visible = true;
        }

        private void dimensionButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Split(' ').Length == matrixCount)
            {
                button1.Visible = true;
                textBox2.ReadOnly = true;
                dimensionButton.Visible = false;

                dimension = textBox2.Text;

            }
            else
            {
                MessageBox.Show("You have provided: " + textBox2.Text.Split(' ').Length.ToString() + " value input\nprovide " + (matrixCount - textBox2.Text.Split(' ').Length).ToString() + " more input");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "Partition_Making_Problem.txt";
            File.WriteAllText(fileName, dimension);

            algoButton.Visible = true;
            button1.Visible = false;
        }
    }
}
