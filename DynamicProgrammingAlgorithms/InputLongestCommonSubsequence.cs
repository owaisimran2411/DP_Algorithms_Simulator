﻿using System;
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
    public partial class InputLongestCommonSubsequence : Form
    {
        public InputLongestCommonSubsequence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LongestCommonSubsequence obj = new LongestCommonSubsequence();
            obj.GenerateFile(textBox1.Text);
            button2.Visible = false;
            algoButton.Visible = true;
        }

        private void algoButton_Click(object sender, EventArgs e)
        {
            LongestCommonSubsequence obj = new LongestCommonSubsequence();
            this.Hide();
            obj.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainScreen obj = new MainScreen();
            this.Hide();
            obj.Show();
        }
    }
}
