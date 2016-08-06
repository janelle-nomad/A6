using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * BMI Calculator Program
 * 
 * Author: Janelle Heron
 * Student: 300839820
 * Date Created: July 21 2016
 * Program Description: This program calculates an individuals BMI a.k.a Body Mass Index
 * 
 * Version 0.2: Renamed form controls, and reorganized form appearance 
 */
namespace BMI_calc
{
    public partial class BMICalculator : Form
    {
        public bool heightInput = false;
        public bool weightInput = false;
        private string _formulaType;

        public BMICalculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /***
         * Allows the program to get the appropriate formula to use for calculateing BMI
         */
        public string ForumlaType
        {
            get { return this._formulaType; }
            set { this._formulaType = value; }
        }
private void HeightTB_Click(object sender, EventArgs e)
        {
            heightInput = true;
            weightInput = false;
        }

        private void WeightTB_Click(object sender, EventArgs e)
        {
            heightInput = false;
            weightInput = true;
        }

        private void Number_Click(object sender, EventArgs e)
        {

            Button button = (Button) sender;
            int value = Convert.ToInt32(button.Text);

            if (heightInput)
            {
                HeightTB.Text += value;
            }

            if (weightInput)
            {
                WeightTB.Text += value;
            }
        }

        /*Clear Button*/
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HeightTB.Text = "";
            WeightTB.Text = "";
            ResultsTB.Text = "";
            OutputTB.Text = "";
        }

        /*Backspace Btn*/
        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (heightInput)
                {
                    string value = HeightTB.Text;
                    string remove = value.Remove(value.Length - 1, 1);
                    HeightTB.Text = remove;
                }

                if (weightInput)
                {
                    string value = WeightTB.Text;
                    string remove = value.Remove(value.Length - 1, 1);
                    WeightTB.Text = remove;
                }        
            }

            catch (Exception)
            {
                
                return;
            }
        }

        private void metricRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HeightLbl.Text = "My Height [CM]";
            WeightLbl.Text = "My Weight [KG]";
            this.ForumlaType = metricRadioBtn.Text;
        }

        private void ImperialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HeightLbl.Text = "My Height [IN]";
            WeightLbl.Text = "My Weight [LBS]";
            this.ForumlaType = ImperialRadioBtn.Text;
        }

        public void formula()
        {
            this._formulaType = "Imperial";
        }

        
        public double Calculation()
        {
            double userBMI = 0;
            double userWeight = Double.Parse(WeightTB.Text);
            double userHeight = Double.Parse(HeightTB.Text);

            if (this._formulaType == "Imperial")
            {
                            
                userBMI = ((userWeight * 703) / (userHeight * userHeight / 100));

            }

            else if (this._formulaType == "Metric")
            {
                userBMI = (userWeight/(userHeight/100)*(userHeight/100));
            }
            return userBMI;
        }

        public string bmiOutput()
        {
            double userBmi = Calculation();
            string bmiOutput = "";

            if (userBmi < 18.5)
            {
                bmiOutput = "Underweight";
            }

            else if (userBmi >=18.5 && userBmi <= 24.9)
            {
                bmiOutput = "Normal";
            }

            else if (userBmi >= 25 && userBmi <= 29.9)
            {
                bmiOutput = "Overweight";
            }

            else if (userBmi >= 30)
            {
                bmiOutput = "Obese";
            }
            return bmiOutput;
        }

        public string UserResult()
        {
            double userBMI = Calculation();

            string userResult = "";

            if (userBMI < 18.5)
            {
                userResult = "Less than 18.5";
            }

            else if (userBMI >= 18.5 && userBMI <= 24.9)
            {
                userResult = "Between 18.5 and 24.9";
            }

            else if (userBMI >= 25 && userBMI <= 29.9)
            {
                userResult = "Between 25 and 29.9";
            }

            else if (userBMI >= 30)
            {
                userResult = "30 or greater";
            }

            return userResult;
        }

        private void CalculateBMIBtn_Click(object sender, EventArgs e)
        {
            ResultsTB.Text = "";
            OutputTB.Text = "";

            OutputTB.Text = UserResult();
            ResultsTB.Text = bmiOutput();
        }
    }
}
