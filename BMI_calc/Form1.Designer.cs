namespace BMI_calc
{
    partial class Form1
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
            this.metricBtn = new System.Windows.Forms.RadioButton();
            this.ImperialBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightBtn = new System.Windows.Forms.TextBox();
            this.CalculateBMIBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultsBtn = new System.Windows.Forms.TextBox();
            this.BMI_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMI_layout
            // 
            this.BMI_layout.ColumnCount = 2;
            this.BMI_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16393F));
            this.BMI_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83607F));
            this.BMI_layout.Controls.Add(this.ImperialBtn, 1, 0);
            this.BMI_layout.Controls.Add(this.metricBtn, 0, 0);
            this.BMI_layout.Controls.Add(this.label1, 0, 1);
            this.BMI_layout.Controls.Add(this.label2, 1, 1);
            this.BMI_layout.Controls.Add(this.weightTB, 0, 2);
            this.BMI_layout.Controls.Add(this.HeightBtn, 1, 2);
            this.BMI_layout.Location = new System.Drawing.Point(2, 12);
            this.BMI_layout.Name = "BMI_layout";
            this.BMI_layout.RowCount = 3;
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.08527F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.91473F));
            this.BMI_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.BMI_layout.Size = new System.Drawing.Size(296, 185);
            this.BMI_layout.TabIndex = 0;
            // 
            // metricBtn
            // 
            this.metricBtn.AutoSize = true;
            this.metricBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.metricBtn.Location = new System.Drawing.Point(3, 3);
            this.metricBtn.Name = "metricBtn";
            this.metricBtn.Size = new System.Drawing.Size(120, 45);
            this.metricBtn.TabIndex = 0;
            this.metricBtn.Text = "Metric";
            this.metricBtn.UseVisualStyleBackColor = true;
            // 
            // ImperialBtn
            // 
            this.ImperialBtn.AutoSize = true;
            this.ImperialBtn.Checked = true;
            this.ImperialBtn.Location = new System.Drawing.Point(151, 3);
            this.ImperialBtn.Name = "ImperialBtn";
            this.ImperialBtn.Size = new System.Drawing.Size(141, 45);
            this.ImperialBtn.TabIndex = 1;
            this.ImperialBtn.TabStop = true;
            this.ImperialBtn.Text = "Imperial";
            this.ImperialBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Weight";
            // 
            // weightTB
            // 
            this.weightTB.Font = new System.Drawing.Font("Lora", 20F);
            this.weightTB.Location = new System.Drawing.Point(3, 143);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(142, 40);
            this.weightTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 82);
            this.label2.TabIndex = 2;
            this.label2.Text = "My Height";
            // 
            // HeightBtn
            // 
            this.HeightBtn.Location = new System.Drawing.Point(151, 143);
            this.HeightBtn.Name = "HeightBtn";
            this.HeightBtn.Size = new System.Drawing.Size(142, 40);
            this.HeightBtn.TabIndex = 2;
            // 
            // CalculateBMIBtn
            // 
            this.CalculateBMIBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CalculateBMIBtn.Font = new System.Drawing.Font("Lora", 20F);
            this.CalculateBMIBtn.Location = new System.Drawing.Point(2, 203);
            this.CalculateBMIBtn.Name = "CalculateBMIBtn";
            this.CalculateBMIBtn.Size = new System.Drawing.Size(296, 51);
            this.CalculateBMIBtn.TabIndex = 4;
            this.CalculateBMIBtn.Text = "Calculate BMI";
            this.CalculateBMIBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(4, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results";
            // 
            // ResultsBtn
            // 
            this.ResultsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResultsBtn.Location = new System.Drawing.Point(2, 404);
            this.ResultsBtn.Name = "ResultsBtn";
            this.ResultsBtn.ReadOnly = true;
            this.ResultsBtn.Size = new System.Drawing.Size(142, 30);
            this.ResultsBtn.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultsBtn);
            this.Controls.Add(this.CalculateBMIBtn);
            this.Controls.Add(this.BMI_layout);
            this.Font = new System.Drawing.Font("Lora", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private System.Windows.Forms.RadioButton ImperialBtn;
        private System.Windows.Forms.RadioButton metricBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.TextBox HeightBtn;
        private System.Windows.Forms.Button CalculateBMIBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultsBtn;
    }
}

