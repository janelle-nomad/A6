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
            this.components = new System.ComponentModel.Container();
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
            this.userBMIStatus = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.BMI_layout.Controls.Add(this.WeightLbl, 1, 1);
            this.BMI_layout.Controls.Add(this.HeightTB, 0, 2);
            this.BMI_layout.Controls.Add(this.WeightTB, 1, 2);
            this.BMI_layout.Controls.Add(this.HeightLbl, 0, 1);
            this.BMI_layout.Location = new System.Drawing.Point(4, 4);
            this.BMI_layout.Name = "BMI_layout";
            this.BMI_layout.RowCount = 3;
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.BMI_layout.Size = new System.Drawing.Size(296, 152);
            this.BMI_layout.TabIndex = 0;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.ImperialRadioBtn.Location = new System.Drawing.Point(151, 3);
            this.ImperialRadioBtn.Name = "ImperialRadioBtn";
            this.ImperialRadioBtn.Size = new System.Drawing.Size(141, 45);
            this.ImperialRadioBtn.TabIndex = 1;
            this.ImperialRadioBtn.Text = "Imperial";
            this.ImperialRadioBtn.UseVisualStyleBackColor = true;
            this.ImperialRadioBtn.CheckedChanged += new System.EventHandler(this.ImperialRadioBtn_CheckedChanged);
            // 
            // metricRadioBtn
            // 
            this.metricRadioBtn.AutoSize = true;
            this.metricRadioBtn.Checked = true;
            this.metricRadioBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.metricRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.metricRadioBtn.Name = "metricRadioBtn";
            this.metricRadioBtn.Size = new System.Drawing.Size(120, 45);
            this.metricRadioBtn.TabIndex = 0;
            this.metricRadioBtn.TabStop = true;
            this.metricRadioBtn.Text = "Metric";
            this.metricRadioBtn.UseVisualStyleBackColor = true;
            this.metricRadioBtn.CheckedChanged += new System.EventHandler(this.metricRadioBtn_CheckedChanged);
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Lora", 13F);
            this.HeightLbl.Location = new System.Drawing.Point(3, 66);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(100, 27);
            this.HeightLbl.TabIndex = 1;
            this.HeightLbl.Text = "My Height";
            this.HeightLbl.Click += new System.EventHandler(this.metricRadioBtn_CheckedChanged);
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Lora", 13F);
            this.WeightLbl.Location = new System.Drawing.Point(151, 66);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(104, 27);
            this.WeightLbl.TabIndex = 2;
            this.WeightLbl.Text = "My Weight";
            // 
            // HeightTB
            // 
            this.HeightTB.Font = new System.Drawing.Font("Lora", 20F);
            this.HeightTB.Location = new System.Drawing.Point(3, 109);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(142, 40);
            this.HeightTB.TabIndex = 1;
            this.HeightTB.Click += new System.EventHandler(this.HeightTB_Click);
            // 
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(151, 109);
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
            this.CalculateBMIBtn.Location = new System.Drawing.Point(2, 275);
            this.CalculateBMIBtn.Name = "CalculateBMIBtn";
            this.CalculateBMIBtn.Size = new System.Drawing.Size(297, 51);
            this.CalculateBMIBtn.TabIndex = 4;
            this.CalculateBMIBtn.Text = "Calculate BMI";
            this.CalculateBMIBtn.UseVisualStyleBackColor = false;
            this.CalculateBMIBtn.Click += new System.EventHandler(this.CalculateBMIBtn_Click);
            // 
            // ResultsTB
            // 
            this.ResultsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResultsTB.Location = new System.Drawing.Point(4, 404);
            this.ResultsTB.Multiline = true;
            this.ResultsTB.Name = "ResultsTB";
            this.ResultsTB.ReadOnly = true;
            this.ResultsTB.Size = new System.Drawing.Size(125, 36);
            this.ResultsTB.TabIndex = 6;
            // 
            // ResultsLbl
            // 
            this.ResultsLbl.AutoSize = true;
            this.ResultsLbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResultsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResultsLbl.ForeColor = System.Drawing.Color.White;
            this.ResultsLbl.Location = new System.Drawing.Point(14, 368);
            this.ResultsLbl.Name = "ResultsLbl";
            this.ResultsLbl.Size = new System.Drawing.Size(106, 31);
            this.ResultsLbl.TabIndex = 7;
            this.ResultsLbl.Text = "Results";
            // 
            // OutputTB
            // 
            this.OutputTB.Font = new System.Drawing.Font("Open Sans", 11F);
            this.OutputTB.Location = new System.Drawing.Point(135, 368);
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.Size = new System.Drawing.Size(166, 72);
            this.OutputTB.TabIndex = 8;
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Lora", 11F);
            this.zeroBtn.Location = new System.Drawing.Point(7, 159);
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
            this.oneBtn.Location = new System.Drawing.Point(58, 159);
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
            this.twoBtn.Location = new System.Drawing.Point(106, 159);
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
            this.threeBtn.Location = new System.Drawing.Point(154, 159);
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
            this.fourBtn.Location = new System.Drawing.Point(203, 159);
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
            this.fiveBtn.Location = new System.Drawing.Point(254, 159);
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
            this.sixBtn.Location = new System.Drawing.Point(6, 197);
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
            this.sevenBtn.Location = new System.Drawing.Point(58, 197);
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
            this.eightBtn.Location = new System.Drawing.Point(106, 197);
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
            this.nineBtn.Location = new System.Drawing.Point(154, 197);
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
            this.button12.Location = new System.Drawing.Point(2, 236);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(294, 34);
            this.button12.TabIndex = 20;
            this.button12.Text = "Clear";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.button13.Font = new System.Drawing.Font("Lora", 11F);
            this.button13.Location = new System.Drawing.Point(200, 197);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(95, 32);
            this.button13.TabIndex = 21;
            this.button13.Text = "Backspace";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // userBMIStatus
            // 
            this.userBMIStatus.ForeColor = System.Drawing.Color.Transparent;
            this.userBMIStatus.Location = new System.Drawing.Point(4, 333);
            this.userBMIStatus.Name = "userBMIStatus";
            this.userBMIStatus.Size = new System.Drawing.Size(293, 23);
            this.userBMIStatus.TabIndex = 22;
            this.userBMIStatus.ForeColorChanged += new System.EventHandler(this.CalculateBMIBtn_Click);
            this.userBMIStatus.Click += new System.EventHandler(this.CalculateBMIBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.userBMIStatus);
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
            this.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.ProgressBar userBMIStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

