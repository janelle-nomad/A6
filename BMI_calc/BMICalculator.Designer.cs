namespace BMI_calc
{
    partial class BMICalculator
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
            this.BMI_layout = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioBtn = new System.Windows.Forms.RadioButton();
            this.metricRadioBtn = new System.Windows.Forms.RadioButton();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.CalculateBMIBtn = new System.Windows.Forms.Button();
            this.ResultsTB = new System.Windows.Forms.TextBox();
            this.ResultsLbl = new System.Windows.Forms.Label();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.BMI_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMI_layout
            // 
            this.BMI_layout.ColumnCount = 2;
            this.BMI_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16393F));
            this.BMI_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83607F));
            this.BMI_layout.Controls.Add(this.ImperialRadioBtn, 1, 0);
            this.BMI_layout.Controls.Add(this.metricRadioBtn, 0, 0);
            this.BMI_layout.Controls.Add(this.HeightLbl, 0, 1);
            this.BMI_layout.Controls.Add(this.WeightLbl, 1, 1);
            this.BMI_layout.Controls.Add(this.HeightTB, 0, 2);
            this.BMI_layout.Controls.Add(this.WeightTB, 1, 2);
            this.BMI_layout.Location = new System.Drawing.Point(4, 4);
            this.BMI_layout.Name = "BMI_layout";
            this.BMI_layout.RowCount = 3;
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.88489F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.11511F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.BMI_layout.Size = new System.Drawing.Size(296, 187);
            this.BMI_layout.TabIndex = 0;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Checked = true;
            this.ImperialRadioBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.ImperialRadioBtn.Location = new System.Drawing.Point(151, 3);
            this.ImperialRadioBtn.Name = "ImperialRadioBtn";
            this.ImperialRadioBtn.Size = new System.Drawing.Size(141, 45);
            this.ImperialRadioBtn.TabIndex = 1;
            this.ImperialRadioBtn.TabStop = true;
            this.ImperialRadioBtn.Text = "Imperial";
            this.ImperialRadioBtn.UseVisualStyleBackColor = true;
            // 
            // metricRadioBtn
            // 
            this.metricRadioBtn.AutoSize = true;
            this.metricRadioBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.metricRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.metricRadioBtn.Name = "metricRadioBtn";
            this.metricRadioBtn.Size = new System.Drawing.Size(120, 45);
            this.metricRadioBtn.TabIndex = 0;
            this.metricRadioBtn.Text = "Metric";
            this.metricRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Lora", 19F);
            this.HeightLbl.Location = new System.Drawing.Point(3, 61);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(98, 78);
            this.HeightLbl.TabIndex = 1;
            this.HeightLbl.Text = "My Height";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Lora", 19F);
            this.WeightLbl.Location = new System.Drawing.Point(151, 61);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(104, 78);
            this.WeightLbl.TabIndex = 2;
            this.WeightLbl.Text = "My Weight";
            // 
            // HeightTB
            // 
            this.HeightTB.Font = new System.Drawing.Font("Lora", 20F);
            this.HeightTB.Location = new System.Drawing.Point(3, 142);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(142, 40);
            this.HeightTB.TabIndex = 1;
            this.HeightTB.Click += new System.EventHandler(this.HeightTB_Click);
            // 
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(151, 142);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(142, 40);
            this.WeightTB.TabIndex = 2;
            this.WeightTB.Click += new System.EventHandler(this.WeightTB_Click);
            // 
            // CalculateBMIBtn
            // 
            this.CalculateBMIBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CalculateBMIBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.CalculateBMIBtn.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIBtn.Location = new System.Drawing.Point(2, 313);
            this.CalculateBMIBtn.Name = "CalculateBMIBtn";
            this.CalculateBMIBtn.Size = new System.Drawing.Size(297, 51);
            this.CalculateBMIBtn.TabIndex = 4;
            this.CalculateBMIBtn.Text = "Calculate BMI";
            this.CalculateBMIBtn.UseVisualStyleBackColor = false;
            // 
            // ResultsTB
            // 
            this.ResultsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResultsTB.Location = new System.Drawing.Point(2, 404);
            this.ResultsTB.Multiline = true;
            this.ResultsTB.Name = "ResultsTB";
            this.ResultsTB.ReadOnly = true;
            this.ResultsTB.Size = new System.Drawing.Size(112, 36);
            this.ResultsTB.TabIndex = 6;
            // 
            // ResultsLbl
            // 
            this.ResultsLbl.AutoSize = true;
            this.ResultsLbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResultsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResultsLbl.ForeColor = System.Drawing.Color.White;
            this.ResultsLbl.Location = new System.Drawing.Point(5, 368);
            this.ResultsLbl.Name = "ResultsLbl";
            this.ResultsLbl.Size = new System.Drawing.Size(106, 31);
            this.ResultsLbl.TabIndex = 7;
            this.ResultsLbl.Text = "Results";
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Open Sans", 11F);
            this.OutputTB.Location = new System.Drawing.Point(120, 365);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(181, 75);
            this.OutputTB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lora", 11F);
            this.button1.Location = new System.Drawing.Point(7, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lora", 11F);
            this.button2.Location = new System.Drawing.Point(58, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lora", 11F);
            this.button3.Location = new System.Drawing.Point(106, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lora", 11F);
            this.button4.Location = new System.Drawing.Point(154, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Lora", 11F);
            this.button5.Location = new System.Drawing.Point(203, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Lora", 11F);
            this.button6.Location = new System.Drawing.Point(254, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Lora", 11F);
            this.button7.Location = new System.Drawing.Point(6, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 32);
            this.button7.TabIndex = 15;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Lora", 11F);
            this.button8.Location = new System.Drawing.Point(58, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 32);
            this.button8.TabIndex = 16;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Lora", 11F);
            this.button9.Location = new System.Drawing.Point(106, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 32);
            this.button9.TabIndex = 17;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Lora", 11F);
            this.button10.Location = new System.Drawing.Point(154, 235);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(41, 32);
            this.button10.TabIndex = 18;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Lora", 11F);
            this.button12.Location = new System.Drawing.Point(2, 274);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(294, 34);
            this.button12.TabIndex = 20;
            this.button12.Text = "Clear";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Lora", 11F);
            this.button13.Location = new System.Drawing.Point(200, 235);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(95, 32);
            this.button13.TabIndex = 21;
            this.button13.Text = "Backspace";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.ResultsLbl);
            this.Controls.Add(this.ResultsTB);
            this.Controls.Add(this.CalculateBMIBtn);
            this.Controls.Add(this.BMI_layout);
            this.Font = new System.Drawing.Font("Lora", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BMI_layout.ResumeLayout(false);
            this.BMI_layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMI_layout;
        private System.Windows.Forms.RadioButton ImperialRadioBtn;
        private System.Windows.Forms.RadioButton metricRadioBtn;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.Button CalculateBMIBtn;
        private System.Windows.Forms.TextBox ResultsTB;
        private System.Windows.Forms.Label ResultsLbl;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

