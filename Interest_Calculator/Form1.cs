using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.principle.Text)){
                MessageBox.Show("Please Enter Principle.");
                this.principle.Focus();
            }
            else if (String.IsNullOrEmpty(this.rate.Text))
            {
                MessageBox.Show("Please Enter Rate.");
                this.rate.Focus();
            }
            else if (String.IsNullOrEmpty(this.time.Text))
            {
                MessageBox.Show("Please Enter Time.");
                this.time.Focus();
            }
            else { 
                Decimal p = Convert.ToDecimal(this.principle.Text);
                Decimal t = Convert.ToDecimal(this.time.Text);
                Decimal r = Convert.ToDecimal(this.rate.Text);

                calculateInterest(p,r,t);
            }
        }
        private void calculateInterest(Decimal p,Decimal r,Decimal t) {
            Decimal i = (p * t * r) / 100;
            this.interest.Text = i.ToString();
        }
    }
}
