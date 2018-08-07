namespace EnrCalcForm
{
    partial class EnrCalcForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.avgTimeBox = new System.Windows.Forms.TextBox();
            this.LOTD = new System.Windows.Forms.CheckBox();
            this.endingEnrLabel = new System.Windows.Forms.Label();
            this.endingEnrTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.startingEnrLabel = new System.Windows.Forms.Label();
            this.startingEnrTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.perHour = new System.Windows.Forms.RadioButton();
            this.perStreakRadioBtn = new System.Windows.Forms.RadioButton();
            this.perKillAvgButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.specificDormantResultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dormantResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orbResultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startStreak = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.startStreak);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.avgTimeBox);
            this.groupBox1.Controls.Add(this.LOTD);
            this.groupBox1.Controls.Add(this.endingEnrLabel);
            this.groupBox1.Controls.Add(this.endingEnrTextBox);
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.startingEnrLabel);
            this.groupBox1.Controls.Add(this.startingEnrTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Avg Time (mins)";
            // 
            // avgTimeBox
            // 
            this.avgTimeBox.Enabled = false;
            this.avgTimeBox.Location = new System.Drawing.Point(113, 46);
            this.avgTimeBox.Name = "avgTimeBox";
            this.avgTimeBox.Size = new System.Drawing.Size(120, 20);
            this.avgTimeBox.TabIndex = 1;
            // 
            // LOTD
            // 
            this.LOTD.AutoSize = true;
            this.LOTD.Location = new System.Drawing.Point(93, 149);
            this.LOTD.Name = "LOTD";
            this.LOTD.Size = new System.Drawing.Size(123, 17);
            this.LOTD.TabIndex = 8;
            this.LOTD.Text = "Luck of the dwarves";
            this.LOTD.UseVisualStyleBackColor = true;
            // 
            // endingEnrLabel
            // 
            this.endingEnrLabel.AutoSize = true;
            this.endingEnrLabel.Location = new System.Drawing.Point(25, 127);
            this.endingEnrLabel.Name = "endingEnrLabel";
            this.endingEnrLabel.Size = new System.Drawing.Size(59, 13);
            this.endingEnrLabel.TabIndex = 6;
            this.endingEnrLabel.Text = "Ending Enr";
            // 
            // endingEnrTextBox
            // 
            this.endingEnrTextBox.Location = new System.Drawing.Point(113, 123);
            this.endingEnrTextBox.Name = "endingEnrTextBox";
            this.endingEnrTextBox.Size = new System.Drawing.Size(120, 20);
            this.endingEnrTextBox.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(96, 172);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 9;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // startingEnrLabel
            // 
            this.startingEnrLabel.AutoSize = true;
            this.startingEnrLabel.Location = new System.Drawing.Point(25, 101);
            this.startingEnrLabel.Name = "startingEnrLabel";
            this.startingEnrLabel.Size = new System.Drawing.Size(62, 13);
            this.startingEnrLabel.TabIndex = 4;
            this.startingEnrLabel.Text = "Starting Enr";
            // 
            // startingEnrTextBox
            // 
            this.startingEnrTextBox.Location = new System.Drawing.Point(113, 97);
            this.startingEnrTextBox.Name = "startingEnrTextBox";
            this.startingEnrTextBox.Size = new System.Drawing.Size(120, 20);
            this.startingEnrTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.perHour);
            this.groupBox2.Controls.Add(this.perStreakRadioBtn);
            this.groupBox2.Controls.Add(this.perKillAvgButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.specificDormantResultBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.resultBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dormantResultBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.orbResultBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drop Chance";
            // 
            // perHour
            // 
            this.perHour.AutoSize = true;
            this.perHour.Location = new System.Drawing.Point(207, 19);
            this.perHour.Name = "perHour";
            this.perHour.Size = new System.Drawing.Size(67, 17);
            this.perHour.TabIndex = 2;
            this.perHour.TabStop = true;
            this.perHour.Text = "Per Hour";
            this.perHour.UseVisualStyleBackColor = true;
            this.perHour.CheckedChanged += new System.EventHandler(this.perHour_CheckedChanged);
            // 
            // perStreakRadioBtn
            // 
            this.perStreakRadioBtn.AutoSize = true;
            this.perStreakRadioBtn.Location = new System.Drawing.Point(117, 19);
            this.perStreakRadioBtn.Name = "perStreakRadioBtn";
            this.perStreakRadioBtn.Size = new System.Drawing.Size(75, 17);
            this.perStreakRadioBtn.TabIndex = 1;
            this.perStreakRadioBtn.TabStop = true;
            this.perStreakRadioBtn.Text = "Per Streak";
            this.perStreakRadioBtn.UseVisualStyleBackColor = true;
            // 
            // perKillAvgButton
            // 
            this.perKillAvgButton.AutoSize = true;
            this.perKillAvgButton.Location = new System.Drawing.Point(11, 19);
            this.perKillAvgButton.Name = "perKillAvgButton";
            this.perKillAvgButton.Size = new System.Drawing.Size(100, 17);
            this.perKillAvgButton.TabIndex = 0;
            this.perKillAvgButton.TabStop = true;
            this.perKillAvgButton.Text = "Per Kill Average";
            this.perKillAvgButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Specific Dormant";
            // 
            // specificDormantResultBox
            // 
            this.specificDormantResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specificDormantResultBox.Location = new System.Drawing.Point(133, 127);
            this.specificDormantResultBox.Name = "specificDormantResultBox";
            this.specificDormantResultBox.ReadOnly = true;
            this.specificDormantResultBox.Size = new System.Drawing.Size(100, 13);
            this.specificDormantResultBox.TabIndex = 10;
            this.specificDormantResultBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Any";
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultBox.Location = new System.Drawing.Point(133, 51);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 13);
            this.resultBox.TabIndex = 4;
            this.resultBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dormant";
            // 
            // dormantResultBox
            // 
            this.dormantResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dormantResultBox.Location = new System.Drawing.Point(133, 101);
            this.dormantResultBox.Name = "dormantResultBox";
            this.dormantResultBox.ReadOnly = true;
            this.dormantResultBox.Size = new System.Drawing.Size(100, 13);
            this.dormantResultBox.TabIndex = 8;
            this.dormantResultBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Orb";
            // 
            // orbResultBox
            // 
            this.orbResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orbResultBox.Location = new System.Drawing.Point(133, 75);
            this.orbResultBox.Name = "orbResultBox";
            this.orbResultBox.ReadOnly = true;
            this.orbResultBox.Size = new System.Drawing.Size(100, 13);
            this.orbResultBox.TabIndex = 6;
            this.orbResultBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Starting Streak";
            // 
            // startStreak
            // 
            this.startStreak.Location = new System.Drawing.Point(113, 72);
            this.startStreak.Name = "startStreak";
            this.startStreak.Size = new System.Drawing.Size(120, 20);
            this.startStreak.TabIndex = 3;
            // 
            // EnrCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrCalcForm";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
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
        private System.Windows.Forms.TextBox orbResultBox;
        private System.Windows.Forms.CheckBox LOTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dormantResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specificDormantResultBox;
        private System.Windows.Forms.RadioButton perStreakRadioBtn;
        private System.Windows.Forms.RadioButton perKillAvgButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox avgTimeBox;
        private System.Windows.Forms.RadioButton perHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox startStreak;
    }
}

