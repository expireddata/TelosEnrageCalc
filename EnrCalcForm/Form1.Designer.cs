namespace EnrCalcForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startingEnrLabel = new System.Windows.Forms.Label();
            this.startingEnrTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.endingEnrLabel = new System.Windows.Forms.Label();
            this.endingEnrTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.LOTD = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LOTD);
            this.groupBox1.Controls.Add(this.endingEnrLabel);
            this.groupBox1.Controls.Add(this.endingEnrTextBox);
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.startingEnrLabel);
            this.groupBox1.Controls.Add(this.startingEnrTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // startingEnrLabel
            // 
            this.startingEnrLabel.AutoSize = true;
            this.startingEnrLabel.Location = new System.Drawing.Point(37, 38);
            this.startingEnrLabel.Name = "startingEnrLabel";
            this.startingEnrLabel.Size = new System.Drawing.Size(62, 13);
            this.startingEnrLabel.TabIndex = 2;
            this.startingEnrLabel.Text = "Starting Enr";
            // 
            // startingEnrTextBox
            // 
            this.startingEnrTextBox.Location = new System.Drawing.Point(117, 35);
            this.startingEnrTextBox.Name = "startingEnrTextBox";
            this.startingEnrTextBox.Size = new System.Drawing.Size(120, 20);
            this.startingEnrTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(135, 127);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // endingEnrLabel
            // 
            this.endingEnrLabel.AutoSize = true;
            this.endingEnrLabel.Location = new System.Drawing.Point(37, 75);
            this.endingEnrLabel.Name = "endingEnrLabel";
            this.endingEnrLabel.Size = new System.Drawing.Size(59, 13);
            this.endingEnrLabel.TabIndex = 5;
            this.endingEnrLabel.Text = "Ending Enr";
            // 
            // endingEnrTextBox
            // 
            this.endingEnrTextBox.Location = new System.Drawing.Point(117, 72);
            this.endingEnrTextBox.Name = "endingEnrTextBox";
            this.endingEnrTextBox.Size = new System.Drawing.Size(120, 20);
            this.endingEnrTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop Chance";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(126, 40);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 1;
            // 
            // LOTD
            // 
            this.LOTD.AutoSize = true;
            this.LOTD.Location = new System.Drawing.Point(117, 104);
            this.LOTD.Name = "LOTD";
            this.LOTD.Size = new System.Drawing.Size(123, 17);
            this.LOTD.TabIndex = 6;
            this.LOTD.Text = "Luck of the dwarves";
            this.LOTD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Enr Calc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label startingEnrLabel;
        private System.Windows.Forms.TextBox startingEnrTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label endingEnrLabel;
        private System.Windows.Forms.TextBox endingEnrTextBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LOTD;
    }
}

