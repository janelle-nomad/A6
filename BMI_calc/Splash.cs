using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calc
{
    /**
     * Janelle Heron 
     * 300839820
     * Version 4 ~ added splash screen
     * 
     */
        // Driver class of Splash Screen
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void splashClock_Tick(object sender, EventArgs e)
        {
            prgsBar.PerformStep();

            if (prgsBar.Value >= prgsBar.Maximum)
            {
                splashClock.Enabled = false;

                BMICalculator BmiCalculator = new BMICalculator();

                BmiCalculator.ShowDialog();
                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
