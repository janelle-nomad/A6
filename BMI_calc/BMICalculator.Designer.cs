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
            this.HeightRadioBtn = new System.Windows.Forms.Label();
            this.WeightRadioBtn = new System.Windows.Forms.Label();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.HeightBtn = new System.Windows.Forms.TextBox();
            this.CalculateBMIBtn = new System.Windows.Forms.Button();
            this.ResultsBtn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.BMI_layout.Controls.Add(this.HeightRadioBtn, 0, 1);
            this.BMI_layout.Controls.Add(this.WeightRadioBtn, 1, 1);
            this.BMI_layout.Controls.Add(this.weightTB, 0, 2);
            this.BMI_layout.Controls.Add(this.HeightBtn, 1, 2);
            this.BMI_layout.Location = new System.Drawing.Point(2, 12);
            this.BMI_layout.Name = "BMI_layout";
            this.BMI_layout.RowCount = 3;
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.08527F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.91473F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.BMI_layout.Size = new System.Drawing.Size(296, 187);
            this.BMI_layout.TabIndex = 0;
            // 
            // ImperialRadioBtn
            // 
            this.ImperialRadioBtn.AutoSize = true;
            this.ImperialRadioBtn.Checked = true;
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
            // HeightRadioBtn
            // 
            this.HeightRadioBtn.AutoSize = true;
            this.HeightRadioBtn.Location = new System.Drawing.Point(3, 57);
            this.HeightRadioBtn.Name = "HeightRadioBtn";
            this.HeightRadioBtn.Size = new System.Drawing.Size(109, 82);
            this.HeightRadioBtn.TabIndex = 1;
            this.HeightRadioBtn.Text = "My Weight";
            // 
            // WeightRadioBtn
            // 
            this.WeightRadioBtn.AutoSize = true;
            this.WeightRadioBtn.Location = new System.Drawing.Point(151, 57);
            this.WeightRadioBtn.Name = "WeightRadioBtn";
            this.WeightRadioBtn.Size = new System.Drawing.Size(103, 82);
            this.WeightRadioBtn.TabIndex = 2;
            this.WeightRadioBtn.Text = "My Height";
            // 
            // weightTB
            // 
            this.weightTB.Font = new System.Drawing.Font("Lora", 20F);
            this.weightTB.Location = new System.Drawing.Point(3, 142);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(142, 40);
            this.weightTB.TabIndex = 1;
            // 
            // HeightBtn
            // 
            this.HeightBtn.Location = new System.Drawing.Point(151, 142);
            this.HeightBtn.Name = "HeightBtn";
            this.HeightBtn.Size = new System.Drawing.Size(142, 40);
            this.HeightBtn.TabIndex = 2;
            // 
            // CalculateBMIBtn
            // 
            this.CalculateBMIBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CalculateBMIBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.CalculateBMIBtn.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIBtn.Location = new System.Drawing.Point(2, 311);
            this.CalculateBMIBtn.Name = "CalculateBMIBtn";
            this.CalculateBMIBtn.Size = new System.Drawing.Size(296, 51);
            this.CalculateBMIBtn.TabIndex = 4;
            this.CalculateBMIBtn.Text = "Calculate BMI";
            this.CalculateBMIBtn.UseVisualStyleBackColor = false;
            // 
            // ResultsBtn
            // 
            this.ResultsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResultsBtn.Location = new System.Drawing.Point(2, 404);
            this.ResultsBtn.Multiline = true;
            this.ResultsBtn.Name = "ResultsBtn";
            this.ResultsBtn.ReadOnly = true;
            this.ResultsBtn.Size = new System.Drawing.Size(112, 36);
            this.ResultsBtn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(120, 365);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(181, 75);
            this.textBox1.TabIndex = 8;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultsBtn);
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
        private System.Windows.Forms.Label HeightRadioBtn;
        private System.Windows.Forms.Label WeightRadioBtn;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.TextBox HeightBtn;
        private System.Windows.Forms.Button CalculateBMIBtn;
        private System.Windows.Forms.TextBox ResultsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

