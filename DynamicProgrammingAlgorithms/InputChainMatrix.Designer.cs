namespace DynamicProgrammingAlgorithms
{
    partial class InputChainMatrix
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.algoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.numberMatricesButton = new System.Windows.Forms.Button();
            this.dimensionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dimensions";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matrices Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input Content For Chain Matrix Algorithm";
            // 
            // algoButton
            // 
            this.algoButton.BackColor = System.Drawing.Color.Tomato;
            this.algoButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoButton.ForeColor = System.Drawing.Color.White;
            this.algoButton.Location = new System.Drawing.Point(133, 173);
            this.algoButton.Name = "algoButton";
            this.algoButton.Size = new System.Drawing.Size(158, 39);
            this.algoButton.TabIndex = 17;
            this.algoButton.Text = "Display Algorithm";
            this.algoButton.UseVisualStyleBackColor = false;
            this.algoButton.Visible = false;
            this.algoButton.Click += new System.EventHandler(this.algoButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tomato;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(297, 173);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(162, 39);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numberMatricesButton
            // 
            this.numberMatricesButton.BackColor = System.Drawing.Color.Coral;
            this.numberMatricesButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMatricesButton.ForeColor = System.Drawing.Color.White;
            this.numberMatricesButton.Location = new System.Drawing.Point(133, 122);
            this.numberMatricesButton.Name = "numberMatricesButton";
            this.numberMatricesButton.Size = new System.Drawing.Size(326, 45);
            this.numberMatricesButton.TabIndex = 18;
            this.numberMatricesButton.Text = "Confirm Number Matrices";
            this.numberMatricesButton.UseVisualStyleBackColor = false;
            this.numberMatricesButton.Click += new System.EventHandler(this.numberMatricesButton_Click);
            // 
            // dimensionButton
            // 
            this.dimensionButton.BackColor = System.Drawing.Color.Coral;
            this.dimensionButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionButton.ForeColor = System.Drawing.Color.White;
            this.dimensionButton.Location = new System.Drawing.Point(133, 122);
            this.dimensionButton.Name = "dimensionButton";
            this.dimensionButton.Size = new System.Drawing.Size(326, 45);
            this.dimensionButton.TabIndex = 19;
            this.dimensionButton.Text = "Confirm Dimension";
            this.dimensionButton.UseVisualStyleBackColor = false;
            this.dimensionButton.Visible = false;
            this.dimensionButton.Click += new System.EventHandler(this.dimensionButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(133, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Place Content In File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputChainMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dimensionButton);
            this.Controls.Add(this.numberMatricesButton);
            this.Controls.Add(this.algoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "InputChainMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputChainMatrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button algoButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button numberMatricesButton;
        private System.Windows.Forms.Button dimensionButton;
        private System.Windows.Forms.Button button1;
    }
}