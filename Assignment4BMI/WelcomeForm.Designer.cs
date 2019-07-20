namespace Assignment4BMI
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.CopyRightlable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.Location = new System.Drawing.Point(15, 136);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(273, 29);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome To BMI Calcutor";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(82, 212);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(136, 23);
            this.progressBar.TabIndex = 1;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 20;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // CopyRightlable
            // 
            this.CopyRightlable.AutoSize = true;
            this.CopyRightlable.Font = new System.Drawing.Font("Corbel", 10F);
            this.CopyRightlable.Location = new System.Drawing.Point(68, 415);
            this.CopyRightlable.Name = "CopyRightlable";
            this.CopyRightlable.Size = new System.Drawing.Size(233, 17);
            this.CopyRightlable.TabIndex = 2;
            this.CopyRightlable.Text = "© Created By Ayhan All Right Reserved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "App Tech Present";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyRightlable);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Corbel", 20F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label CopyRightlable;
        private System.Windows.Forms.Label label1;
    }
}