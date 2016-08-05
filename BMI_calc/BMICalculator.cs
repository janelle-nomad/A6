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
        private bool heightInput = false;
        bool weightInput = false;

        public BMICalculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void button12_Click(object sender, EventArgs e)
        {
            HeightTB.Text = "";
            WeightTB.Text = "";
            ResultsTB.Text = "";
            OutputTB.Text = "";
        }

        /*Backspace Btn*/
        private void button13_Click(object sender, EventArgs e)
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

        
    }
}
