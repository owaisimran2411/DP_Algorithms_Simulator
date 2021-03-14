namespace DynamicProgrammingAlgorithms
{
    partial class RodCuttingProblem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finalOutputButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.inputWeightsTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.inputValuesTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.conditionCodePart3 = new System.Windows.Forms.Label();
            this.conditionCodePart2 = new System.Windows.Forms.Label();
            this.conditionCodePart1 = new System.Windows.Forms.Label();
            this.psuedoTextBox = new System.Windows.Forms.RichTextBox();
            this.psuedoLabel = new System.Windows.Forms.Label();
            this.conditionBeingExecuted = new System.Windows.Forms.Label();
            this.currentPosition = new System.Windows.Forms.Label();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.wValue = new System.Windows.Forms.Label();
            this.iValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setupButton = new System.Windows.Forms.Button();
            this.performIterationButton = new System.Windows.Forms.Button();
            this.completeIterationsButton = new System.Windows.Forms.Button();
            this.initializeGridButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalOutputButton
            // 
            this.finalOutputButton.Location = new System.Drawing.Point(629, 64);
            this.finalOutputButton.Name = "finalOutputButton";
            this.finalOutputButton.Size = new System.Drawing.Size(306, 23);
            this.finalOutputButton.TabIndex = 27;
            this.finalOutputButton.Text = "View Final Output";
            this.finalOutputButton.UseVisualStyleBackColor = true;
            this.finalOutputButton.Click += new System.EventHandler(this.finalOutputButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(307, 58);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Rod Length";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // inputWeightsTextBox
            // 
            this.inputWeightsTextBox.Location = new System.Drawing.Point(9, 7);
            this.inputWeightsTextBox.Name = "inputWeightsTextBox";
            this.inputWeightsTextBox.ReadOnly = true;
            this.inputWeightsTextBox.Size = new System.Drawing.Size(291, 45);
            this.inputWeightsTextBox.TabIndex = 0;
            this.inputWeightsTextBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.inputWeightsTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(307, 58);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Individual Length";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // inputValuesTextBox
            // 
            this.inputValuesTextBox.Location = new System.Drawing.Point(6, 7);
            this.inputValuesTextBox.Name = "inputValuesTextBox";
            this.inputValuesTextBox.ReadOnly = true;
            this.inputValuesTextBox.Size = new System.Drawing.Size(295, 45);
            this.inputValuesTextBox.TabIndex = 0;
            this.inputValuesTextBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.inputValuesTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(307, 58);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Individual Price";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(628, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 224);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Profit can be: ";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(624, 359);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(315, 84);
            this.tabControl2.TabIndex = 26;
            // 
            // conditionCodePart3
            // 
            this.conditionCodePart3.AutoSize = true;
            this.conditionCodePart3.Location = new System.Drawing.Point(6, 120);
            this.conditionCodePart3.Name = "conditionCodePart3";
            this.conditionCodePart3.Size = new System.Drawing.Size(0, 13);
            this.conditionCodePart3.TabIndex = 7;
            // 
            // conditionCodePart2
            // 
            this.conditionCodePart2.AutoSize = true;
            this.conditionCodePart2.Location = new System.Drawing.Point(6, 103);
            this.conditionCodePart2.Name = "conditionCodePart2";
            this.conditionCodePart2.Size = new System.Drawing.Size(0, 13);
            this.conditionCodePart2.TabIndex = 6;
            // 
            // conditionCodePart1
            // 
            this.conditionCodePart1.AutoSize = true;
            this.conditionCodePart1.Location = new System.Drawing.Point(7, 86);
            this.conditionCodePart1.Name = "conditionCodePart1";
            this.conditionCodePart1.Size = new System.Drawing.Size(0, 13);
            this.conditionCodePart1.TabIndex = 5;
            // 
            // psuedoTextBox
            // 
            this.psuedoTextBox.Location = new System.Drawing.Point(6, 36);
            this.psuedoTextBox.Name = "psuedoTextBox";
            this.psuedoTextBox.ReadOnly = true;
            this.psuedoTextBox.Size = new System.Drawing.Size(590, 271);
            this.psuedoTextBox.TabIndex = 8;
            this.psuedoTextBox.Text = "";
            // 
            // psuedoLabel
            // 
            this.psuedoLabel.AutoSize = true;
            this.psuedoLabel.Location = new System.Drawing.Point(7, 20);
            this.psuedoLabel.Name = "psuedoLabel";
            this.psuedoLabel.Size = new System.Drawing.Size(71, 13);
            this.psuedoLabel.TabIndex = 0;
            this.psuedoLabel.Text = "Psuedo Code";
            // 
            // conditionBeingExecuted
            // 
            this.conditionBeingExecuted.AutoSize = true;
            this.conditionBeingExecuted.Location = new System.Drawing.Point(7, 69);
            this.conditionBeingExecuted.Name = "conditionBeingExecuted";
            this.conditionBeingExecuted.Size = new System.Drawing.Size(0, 13);
            this.conditionBeingExecuted.TabIndex = 4;
            // 
            // currentPosition
            // 
            this.currentPosition.AutoSize = true;
            this.currentPosition.Location = new System.Drawing.Point(177, 52);
            this.currentPosition.Name = "currentPosition";
            this.currentPosition.Size = new System.Drawing.Size(0, 13);
            this.currentPosition.TabIndex = 3;
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.AutoSize = true;
            this.currentPositionLabel.Location = new System.Drawing.Point(6, 52);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(140, 13);
            this.currentPositionLabel.TabIndex = 2;
            this.currentPositionLabel.Text = "Currently Working on index: ";
            // 
            // wValue
            // 
            this.wValue.AutoSize = true;
            this.wValue.Location = new System.Drawing.Point(7, 36);
            this.wValue.Name = "wValue";
            this.wValue.Size = new System.Drawing.Size(65, 13);
            this.wValue.TabIndex = 1;
            this.wValue.Text = "value of w =";
            // 
            // iValue
            // 
            this.iValue.AutoSize = true;
            this.iValue.Location = new System.Drawing.Point(7, 20);
            this.iValue.Name = "iValue";
            this.iValue.Size = new System.Drawing.Size(62, 13);
            this.iValue.TabIndex = 0;
            this.iValue.Text = "value of i = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.psuedoTextBox);
            this.groupBox1.Controls.Add(this.psuedoLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 313);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rod Cutting Problem";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(630, 64);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(306, 23);
            this.setupButton.TabIndex = 23;
            this.setupButton.Text = "Setup Necessary Environment";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // performIterationButton
            // 
            this.performIterationButton.Location = new System.Drawing.Point(629, 64);
            this.performIterationButton.Name = "performIterationButton";
            this.performIterationButton.Size = new System.Drawing.Size(306, 23);
            this.performIterationButton.TabIndex = 22;
            this.performIterationButton.Text = "Perform Next Iteration";
            this.performIterationButton.UseVisualStyleBackColor = true;
            this.performIterationButton.Click += new System.EventHandler(this.performIterationButton_Click);
            // 
            // completeIterationsButton
            // 
            this.completeIterationsButton.Location = new System.Drawing.Point(628, 93);
            this.completeIterationsButton.Name = "completeIterationsButton";
            this.completeIterationsButton.Size = new System.Drawing.Size(306, 23);
            this.completeIterationsButton.TabIndex = 21;
            this.completeIterationsButton.Text = "Complete All Iterations";
            this.completeIterationsButton.UseVisualStyleBackColor = true;
            this.completeIterationsButton.Click += new System.EventHandler(this.completeIterationsButton_Click);
            // 
            // initializeGridButton
            // 
            this.initializeGridButton.Location = new System.Drawing.Point(629, 64);
            this.initializeGridButton.Name = "initializeGridButton";
            this.initializeGridButton.Size = new System.Drawing.Size(306, 23);
            this.initializeGridButton.TabIndex = 20;
            this.initializeGridButton.Text = "Initialize Grid";
            this.initializeGridButton.UseVisualStyleBackColor = true;
            this.initializeGridButton.Click += new System.EventHandler(this.initializeGridButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "M-Value Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.conditionCodePart3);
            this.groupBox2.Controls.Add(this.conditionCodePart2);
            this.groupBox2.Controls.Add(this.conditionCodePart1);
            this.groupBox2.Controls.Add(this.conditionBeingExecuted);
            this.groupBox2.Controls.Add(this.currentPosition);
            this.groupBox2.Controls.Add(this.currentPositionLabel);
            this.groupBox2.Controls.Add(this.wValue);
            this.groupBox2.Controls.Add(this.iValue);
            this.groupBox2.Location = new System.Drawing.Point(624, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 309);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "execution steps";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 405);
            this.tabControl1.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tomato;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(836, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 39);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(699, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 39);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Exit Application";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RodCuttingProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 772);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.finalOutputButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.performIterationButton);
            this.Controls.Add(this.initializeGridButton);
            this.Controls.Add(this.completeIterationsButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "RodCuttingProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RodCuttingProblem";
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button finalOutputButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox inputWeightsTextBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox inputValuesTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label conditionCodePart3;
        private System.Windows.Forms.Label conditionCodePart2;
        private System.Windows.Forms.Label conditionCodePart1;
        private System.Windows.Forms.RichTextBox psuedoTextBox;
        private System.Windows.Forms.Label psuedoLabel;
        private System.Windows.Forms.Label conditionBeingExecuted;
        private System.Windows.Forms.Label currentPosition;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Label wValue;
        private System.Windows.Forms.Label iValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button performIterationButton;
        private System.Windows.Forms.Button completeIterationsButton;
        private System.Windows.Forms.Button initializeGridButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
    }
}