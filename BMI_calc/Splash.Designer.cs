namespace BMI_calc
{
    partial class Splash
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
            this.prgsBar = new System.Windows.Forms.ProgressBar();
            this.Welcome = new System.Windows.Forms.Label();
            this.splashClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prgsBar
            // 
            this.prgsBar.ForeColor = System.Drawing.Color.Maroon;
            this.prgsBar.Location = new System.Drawing.Point(57, 87);
            this.prgsBar.Name = "prgsBar";
            this.prgsBar.Size = new System.Drawing.Size(297, 23);
            this.prgsBar.TabIndex = 0;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Welcome.Location = new System.Drawing.Point(59, 29);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(291, 47);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "BMI Calculator";
            // 
            // splashClock
            // 
            this.splashClock.Enabled = true;
            this.splashClock.Interval = 400;
            this.splashClock.Tick += new System.EventHandler(this.splashClock_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(396, 153);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.prgsBar);
            this.Name = "Splash";
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgsBar;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Timer splashClock;
    }
}