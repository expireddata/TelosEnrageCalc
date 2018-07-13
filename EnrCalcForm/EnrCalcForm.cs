using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrCalcForm
{
    public partial class EnrCalcForm : Form
    {
        public Random r = new Random();
        public static int NumberOfTrials = 20;
        public EnrCalcForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {


            int startEnr;
            int endEnr;

            if (string.IsNullOrEmpty(this.startingEnrTextBox.Text) || string.IsNullOrEmpty(this.endingEnrTextBox.Text) || !int.TryParse(startingEnrTextBox.Text, out startEnr) || !int.TryParse(endingEnrTextBox.Text, out endEnr))
            {
                //Todo give feedback
                return;
            }
            double sumP = 0;
            for (int trialNum = 0; trialNum < NumberOfTrials; trialNum++)
            {
                double p = 1;
                int streak = 0; 
                for (int curEnr = startEnr; curEnr <= endEnr; curEnr += r.Next(5, 21))
                {
                    double divisor = 10000 / (10 + 0.25 * (curEnr + (this.LOTD.Checked ? 25 : 0)) + 3*streak++);
                    if(curEnr < 100)
                    {
                        divisor *= 10; 
                    }
                    if(curEnr < 25)
                    {
                        divisor *= 3;
                    }
                    double killP = 1 - (1 / Math.Floor(divisor));
                    p *= killP; 
                }
                sumP += p;
            }
            this.resultBox.Text = "1 in " + (1/(1 - (sumP / NumberOfTrials))).ToString("N3");
        }
    }
}
