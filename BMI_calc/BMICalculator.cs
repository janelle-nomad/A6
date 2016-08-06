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
 * Version 0.0.6: Added more documentation 
 */
namespace BMI_calc
{
    public partial class BMICalculator : Form
    {
        // public variables
        public bool heightInput = false;
        public bool weightInput = false; // Sets the keypad buttons to zero 

        // Private variable
        private string _formulaType;

        public BMICalculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**
         * *<summary>
         * Property Allows the program to use the appropriate formula when calculateing BMI
         * </summary>
         * @property {string} Formula
         */
        public string ForumlaType
        {
            get { return this._formulaType; }
            set { this._formulaType = value; }
        }

        /** PRIVATE METHODS
         * 
         * <summary>
         * This method produces a requirement stating that if 'HeightTB.Textbox' has been
         * clicked, then make the 'WeightTB.Textbox' void, unless it is clicked 
         * </summary>
         * @method {bool} 
         */

        
        private void HeightTB_Click(object sender, EventArgs e)
        {
            heightInput = true;
            weightInput = false;
        }

        /** PRIVATE METHODS
             * 
             * <summary>
             * This method produces a requirement stating that if 'WeightTB.Textbox' has been
             * clicked, then make the 'HeightTB.Textbox' void, unless it is clicked 
             * </summary>
             * @method {bool} 
        */

        private void WeightTB_Click(object sender, EventArgs e)
        {
            heightInput = false;
            weightInput = true;
        }

        /**
         * <summary>
         * This will allow the number buttons from 0-9 to be active, so the user can use them
         * to provide input into the textboxes
         * </summary>
         * 
         *@method Number_Click 
         */
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


        /** PRIVATE METHOD
         * <summary>
         * This method intia;izes the Clear Button
         * </summary>
         */
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HeightTB.Text = "";
            WeightTB.Text = "";
            ResultsTB.Text = "";
            OutputTB.Text = "";
        }

        /**PRIVATE METHOD
         * <summary>
         * Intializes the Backspace button
         * </summary>
         */
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

        /** PRIVATE METHOD
         * 
         * <SUMMARY>
         * This is the private method for the metric radio button, it changes the labels once clicked
         * </SUMMARY>
         * 
         * @method metricRadioBtn_CheckedChanged
         * @returns {void}
         */
        private void metricRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HeightLbl.Text = "My Height CM";
            WeightLbl.Text = "My Weight KG";
            this.ForumlaType = metricRadioBtn.Text;
        }

        /** PRIVATE METHOD
         * 
         * <SUMMARY>
         * This is the private method for the metric radio button, it changes the labels once clicked
         * </SUMMARY>
         * 
         * @method imperialRadioBtn_CheckedChanged
         * @returns {void}
         */
        private void ImperialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            HeightLbl.Text = "My Height IN";
            WeightLbl.Text = "My Weight LBS";
            this.ForumlaType = ImperialRadioBtn.Text;
        }


        /** PUBLIC METHOD
         * 
         * <summary>
         * Holds the _formula method
         * </summary>
         * @method formula
         */
        public void formula()
        {
            this._formulaType = "Imperial";
        }

        
        /**Public Method
         * <summary>
         * This method performs the metric and Imperial methods
         * Converts the user's values within the WeightTb.Textbox, and HeightTB.Textbox, into
         * workable datatype, Double, and uses the _formulaType, to determine the formula to use
         * based on the radio buttons that the user has clicked prior to clicking the CalculateBMI button 
         * </summary> 
         * 
         * @method Calculation
         * @returns {double}
         * 
         */

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
            this.timer1.Start();

            //if (userBMI < 18.5)
            //{
            //    userBMIStatus.ForeColor = Color.DarkOrange;
            //}

            //else if (userBMI >= 18.5 && userBMI <= 24.9)
            //{
            //    userBMIStatus.ForeColor = Color.MediumSeaGreen;
            //}
            return userBMI;
            
        }


        private void CalculateBMIBtn_Click(object sender, EventArgs e)
        {
            ResultsTB.Text = "";
            OutputTB.Text = "";

            timer1.Start();
            Calculation();
            OutputTB.Text = UserResult();
            ResultsTB.Text = bmiOutput();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.userBMIStatus.Increment(1);
        }
        /** PUBLIC METHOD
         * <summary>
         * Determines the user's BMI scale based on the user's BMI
         * </summary>
         * @method bmiOutput
         * @returns {string}
         */

        public string bmiOutput() 
        {
            double userBMI = Calculation();
            string bmiOutput = "";

            if (userBMI < 18.5)
            {
                userBMIStatus.ForeColor = Color.DarkOrange;
                bmiOutput = "Underweight";
                
            }

            else if (userBMI >=18.5 && userBMI <= 24.9)
            {
                userBMIStatus.ForeColor = Color.MediumSeaGreen;
                bmiOutput = "Normal";
                
            }

            else if (userBMI >= 25 && userBMI <= 29.9)
            {
                userBMIStatus.ForeColor = Color.Yellow;
                bmiOutput = "Overweight";
                
            }

            else if (userBMI >= 30)
            {
                userBMIStatus.ForeColor = Color.Red; //progress bar colors
                bmiOutput = "Obese";
                
            }
            return bmiOutput;
        }

        /** PUBLIC METHOD
         * <summary>
         * Determines the user's BMI result based on the user's BMI
         * </summary>
         * @method userResult
         * @returns {string}
         */
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
    }
}
