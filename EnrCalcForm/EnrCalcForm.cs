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
        public static int NumberOfTrials = 10000;
        public EnrCalcForm()
        {
            InitializeComponent();
            perKillAvgButton.Checked = true; 
        }

        private void calcButton_Click(object sender, EventArgs e)
        {


            int startEnr;
            int endEnr;
            double avgTime = 1;

            if (string.IsNullOrEmpty(this.startingEnrTextBox.Text) || string.IsNullOrEmpty(this.endingEnrTextBox.Text) || (avgTimeBox.Enabled && (string.IsNullOrEmpty(this.avgTimeBox.Text) || !double.TryParse(avgTimeBox.Text, out avgTime))) || !int.TryParse(startingEnrTextBox.Text, out startEnr) || !int.TryParse(endingEnrTextBox.Text, out endEnr))
            {
                //Todo give feedback
                return;
            }
            double sumP = 0;
            double sumStreak = 0;
            int initStreak = 0;
            if (!string.IsNullOrEmpty(this.startStreak.Text))
            {
                int.TryParse(this.startStreak.Text, out initStreak);
            }
            for (int trialNum = 0; trialNum < NumberOfTrials; trialNum++)
            {
                double p = 1;
                int streak = initStreak; 
                for (int curEnr = startEnr; curEnr <= endEnr; curEnr += randomRoll())
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
                sumStreak += (streak - initStreak) + 1;
            }
            double avgKills = sumStreak / NumberOfTrials;
            double kph = (60 / avgTime);
            double result = (1 - (sumP / NumberOfTrials));
            if (perStreakRadioBtn.Checked)
            {
                result = 1 / result;
            }
            else if (perKillAvgButton.Checked)
            {
                result = 1 / (result / avgKills);
            }
            else if (perHour.Checked)
            {
                result = 1 / (result * kph / avgKills);
            }
            this.resultBox.Text = "1 in " + result.ToString("N3");
            this.orbResultBox.Text = "1 in " + (4*result/3).ToString("N3");
            this.dormantResultBox.Text = "1 in " + (result*4).ToString("N3");
            this.specificDormantResultBox.Text = "1 in " + (result*12).ToString("N3");        
        }

        private void perHour_CheckedChanged(object sender, EventArgs e)
        {
            avgTimeBox.Enabled = perHour.Checked;
        }

        private int randomRoll()
        {
            double roll = r.NextDouble();

            if(roll <= 0.012)
            {
                return 5; 
            }
            if(roll <= 0.104)
            {
                return 8; 
            }
            if(roll <= 0.226)
            {
                return 9; 
            }
            if(roll <= 0.474)
            {
                return 10; 
            }
            if(roll <= 0.623)
            {
                return 11; 
            }
            if(roll <= 0.72)
            {
                return 12; 
            }
            if(roll <= 0.805)
            {
                return 13;
            }
            if(roll <= 0.867)
            {
                return 14; 
            }
            if(roll <= 0.915)
            {
                return 15; 
            }
            if(roll <= 0.942)
            {
                return 16;
            }
            if(roll <= 0.960)
            {
                return 17; 
            }
            if(roll <= 0.977)
            {
                return 18; 
            }
            if(roll <= 0.99)
            {
                return 19; 
            }
            return 20;
        }
    }
}
