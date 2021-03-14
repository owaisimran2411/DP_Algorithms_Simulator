namespace DynamicProgrammingAlgorithms
{
    partial class LevenshetinEditDistance
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
            this.currentPosition = new System.Windows.Forms.Label();
            this.iValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.wValue = new System.Windows.Forms.Label();
            this.psuedoLabel = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.psuedoTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.finalOutputButton = new System.Windows.Forms.Button();
            this.completeIterationButton = new System.Windows.Forms.Button();
            this.nextIterationButton = new System.Windows.Forms.Button();
            this.setupEnvironmentButton = new System.Windows.Forms.Button();
            this.intializeGridButton = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentPosition
            // 
            this.currentPosition.AutoSize = true;
            this.currentPosition.Location = new System.Drawing.Point(177, 52);
            this.currentPosition.Name = "currentPosition";
            this.currentPosition.Size = new System.Drawing.Size(0, 13);
            this.currentPosition.TabIndex = 3;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentPosition);
            this.groupBox2.Controls.Add(this.currentPositionLabel);
            this.groupBox2.Controls.Add(this.wValue);
            this.groupBox2.Controls.Add(this.iValue);
            this.groupBox2.Location = new System.Drawing.Point(692, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 309);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "execution steps";
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
            this.wValue.Size = new System.Drawing.Size(59, 13);
            this.wValue.TabIndex = 1;
            this.wValue.Text = "value of j =";
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(688, 319);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(420, 120);
            this.tabControl2.TabIndex = 39;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(412, 94);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "String 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(396, 81);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(412, 94);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "String 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 7);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(399, 84);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.psuedoTextBox);
            this.groupBox1.Controls.Add(this.psuedoLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 313);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Levenshetin Edit Distance";
            // 
            // psuedoTextBox
            // 
            this.psuedoTextBox.Location = new System.Drawing.Point(10, 36);
            this.psuedoTextBox.Name = "psuedoTextBox";
            this.psuedoTextBox.ReadOnly = true;
            this.psuedoTextBox.Size = new System.Drawing.Size(645, 271);
            this.psuedoTextBox.TabIndex = 9;
            this.psuedoTextBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 402);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "L Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // finalOutputButton
            // 
            this.finalOutputButton.Location = new System.Drawing.Point(684, 59);
            this.finalOutputButton.Name = "finalOutputButton";
            this.finalOutputButton.Size = new System.Drawing.Size(424, 23);
            this.finalOutputButton.TabIndex = 37;
            this.finalOutputButton.Text = "View Final Output";
            this.finalOutputButton.UseVisualStyleBackColor = true;
            this.finalOutputButton.Click += new System.EventHandler(this.finalOutputButton_Click);
            // 
            // completeIterationButton
            // 
            this.completeIterationButton.Location = new System.Drawing.Point(684, 88);
            this.completeIterationButton.Name = "completeIterationButton";
            this.completeIterationButton.Size = new System.Drawing.Size(424, 23);
            this.completeIterationButton.TabIndex = 36;
            this.completeIterationButton.Text = "Complete All Iterations";
            this.completeIterationButton.UseVisualStyleBackColor = true;
            this.completeIterationButton.Click += new System.EventHandler(this.completeIterationButton_Click);
            // 
            // nextIterationButton
            // 
            this.nextIterationButton.Location = new System.Drawing.Point(683, 59);
            this.nextIterationButton.Name = "nextIterationButton";
            this.nextIterationButton.Size = new System.Drawing.Size(424, 23);
            this.nextIterationButton.TabIndex = 35;
            this.nextIterationButton.Text = "Perform Next Iteration";
            this.nextIterationButton.UseVisualStyleBackColor = true;
            this.nextIterationButton.Click += new System.EventHandler(this.nextIterationButton_Click);
            // 
            // setupEnvironmentButton
            // 
            this.setupEnvironmentButton.Location = new System.Drawing.Point(684, 59);
            this.setupEnvironmentButton.Name = "setupEnvironmentButton";
            this.setupEnvironmentButton.Size = new System.Drawing.Size(424, 23);
            this.setupEnvironmentButton.TabIndex = 34;
            this.setupEnvironmentButton.Text = "Setup Necessary Environment";
            this.setupEnvironmentButton.UseVisualStyleBackColor = true;
            this.setupEnvironmentButton.Click += new System.EventHandler(this.setupEnvironmentButton_Click);
            // 
            // intializeGridButton
            // 
            this.intializeGridButton.Location = new System.Drawing.Point(684, 59);
            this.intializeGridButton.Name = "intializeGridButton";
            this.intializeGridButton.Size = new System.Drawing.Size(424, 23);
            this.intializeGridButton.TabIndex = 33;
            this.intializeGridButton.Text = "Initialize Grid";
            this.intializeGridButton.UseVisualStyleBackColor = true;
            this.intializeGridButton.Click += new System.EventHandler(this.intializeGridButton_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(7, 20);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(301, 13);
            this.lengthLabel.TabIndex = 0;
            this.lengthLabel.Text = "Number of operations required for converting String1->String2: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lengthLabel);
            this.groupBox3.Location = new System.Drawing.Point(687, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 195);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Output";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tomato;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1010, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 39);
            this.backButton.TabIndex = 43;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(873, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 39);
            this.exitButton.TabIndex = 42;
            this.exitButton.Text = "Exit Application";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LevenshetinEditDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 768);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.finalOutputButton);
            this.Controls.Add(this.completeIterationButton);
            this.Controls.Add(this.nextIterationButton);
            this.Controls.Add(this.setupEnvironmentButton);
            this.Controls.Add(this.intializeGridButton);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "LevenshetinEditDistance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevenshetinEditDistance";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currentPosition;
        private System.Windows.Forms.Label iValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Label wValue;
        private System.Windows.Forms.Label psuedoLabel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button finalOutputButton;
        private System.Windows.Forms.Button completeIterationButton;
        private System.Windows.Forms.Button nextIterationButton;
        private System.Windows.Forms.Button setupEnvironmentButton;
        private System.Windows.Forms.Button intializeGridButton;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox psuedoTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
    }
}