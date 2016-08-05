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
            this.zeroBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
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
            this.ResultsTB.Location = new System.Drawing.Point(4, 404);
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
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.zeroBtn.Location = new System.Drawing.Point(7, 197);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(41, 32);
            this.zeroBtn.TabIndex = 9;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.oneBtn.Location = new System.Drawing.Point(58, 197);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(41, 32);
            this.oneBtn.TabIndex = 10;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.twoBtn.Location = new System.Drawing.Point(106, 197);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(41, 32);
            this.twoBtn.TabIndex = 11;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.threeBtn.Location = new System.Drawing.Point(154, 197);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(41, 32);
            this.threeBtn.TabIndex = 12;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.fourBtn.Location = new System.Drawing.Point(203, 197);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(41, 32);
            this.fourBtn.TabIndex = 13;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.fiveBtn.Location = new System.Drawing.Point(254, 197);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(41, 32);
            this.fiveBtn.TabIndex = 14;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.sixBtn.Location = new System.Drawing.Point(6, 235);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(41, 32);
            this.sixBtn.TabIndex = 15;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.sevenBtn.Location = new System.Drawing.Point(58, 235);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(41, 32);
            this.sevenBtn.TabIndex = 16;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.eightBtn.Location = new System.Drawing.Point(106, 235);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(41, 32);
            this.eightBtn.TabIndex = 17;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.nineBtn.Location = new System.Drawing.Point(154, 235);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(41, 32);
            this.nineBtn.TabIndex = 18;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.Number_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.button12.Font = new System.Drawing.Font("Lora", 11F);
            this.button12.Location = new System.Drawing.Point(2, 274);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(294, 34);
            this.button12.TabIndex = 20;
            this.button12.Text = "Clear";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ClearBtn_Click);
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
            this.button13.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.zeroBtn);
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
            this.Text = "BMI Calculator";
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
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

