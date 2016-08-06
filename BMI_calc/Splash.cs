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
        //Driver class of Loading Screen
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void splashClock_Tick(object sender, EventArgs e)
        {
            prgsBar.PerformStep();

            if (prgsBar.Value >= prgsBar.Maximum)
            {
                splashClock.Enabled = false;

                BMICalculator bmiCalculator = new BMICalculator();

                bmiCalculator.ShowDialog();
                this.Close();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
