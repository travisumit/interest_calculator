namespace Interest_Calculator
{
    partial class InterestCalculator
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
            this.principle = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.interest = new System.Windows.Forms.TextBox();
            this.lblprinciple = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.lblInterest = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // principle
            // 
            this.principle.Location = new System.Drawing.Point(218, 91);
            this.principle.Name = "principle";
            this.principle.Size = new System.Drawing.Size(100, 20);
            this.principle.TabIndex = 0;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(218, 133);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 20);
            this.rate.TabIndex = 1;
            // 
            // interest
            // 
            this.interest.Enabled = false;
            this.interest.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interest.Location = new System.Drawing.Point(217, 312);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(116, 30);
            this.interest.TabIndex = 2;
            // 
            // lblprinciple
            // 
            this.lblprinciple.AutoSize = true;
            this.lblprinciple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprinciple.Location = new System.Drawing.Point(113, 91);
            this.lblprinciple.Name = "lblprinciple";
            this.lblprinciple.Size = new System.Drawing.Size(82, 20);
            this.lblprinciple.TabIndex = 3;
            this.lblprinciple.Text = "Principle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(140, 30);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(294, 42);
            this.heading.TabIndex = 6;
            this.heading.Text = "INTEREST CALCULATOR";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(125, 131);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(53, 20);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rate:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(126, 178);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 20);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(218, 226);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(88, 35);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(126, 310);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(77, 20);
            this.lblInterest.TabIndex = 10;
            this.lblInterest.Text = "Interest:";
            this.lblInterest.Click += new System.EventHandler(this.label1_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(217, 181);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 2;
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 382);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprinciple);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.principle);
            this.Name = "InterestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principle;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Label lblprinciple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox time;
    }
}

