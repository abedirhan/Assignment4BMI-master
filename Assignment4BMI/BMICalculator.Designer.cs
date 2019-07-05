namespace Assignment4BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.rdBtnMetric = new System.Windows.Forms.RadioButton();
            this.lblHeight = new System.Windows.Forms.Label();
            this.rdBtnImperial = new System.Windows.Forms.RadioButton();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.BtnCalculateBMI = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblResultList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBtnMetric
            // 
            this.rdBtnMetric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdBtnMetric.AutoSize = true;
            this.rdBtnMetric.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMetric.Location = new System.Drawing.Point(145, 161);
            this.rdBtnMetric.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdBtnMetric.Name = "rdBtnMetric";
            this.rdBtnMetric.Size = new System.Drawing.Size(104, 37);
            this.rdBtnMetric.TabIndex = 1;
            this.rdBtnMetric.Text = "Metric";
            this.rdBtnMetric.UseVisualStyleBackColor = true;
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(13, 282);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(136, 33);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "My Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtnImperial
            // 
            this.rdBtnImperial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdBtnImperial.AutoSize = true;
            this.rdBtnImperial.Checked = true;
            this.rdBtnImperial.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnImperial.Location = new System.Drawing.Point(284, 161);
            this.rdBtnImperial.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdBtnImperial.Name = "rdBtnImperial";
            this.rdBtnImperial.Size = new System.Drawing.Size(123, 37);
            this.rdBtnImperial.TabIndex = 1;
            this.rdBtnImperial.TabStop = true;
            this.rdBtnImperial.Text = "Imperial";
            this.rdBtnImperial.UseVisualStyleBackColor = true;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(9, 220);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(140, 33);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "My Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(144, 213);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(215, 40);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(144, 275);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(215, 40);
            this.txtHeight.TabIndex = 4;
            // 
            // BtnCalculateBMI
            // 
            this.BtnCalculateBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.BtnCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculateBMI.Location = new System.Drawing.Point(150, 321);
            this.BtnCalculateBMI.Name = "BtnCalculateBMI";
            this.BtnCalculateBMI.Size = new System.Drawing.Size(163, 38);
            this.BtnCalculateBMI.TabIndex = 1;
            this.BtnCalculateBMI.Text = "Calculate";
            this.BtnCalculateBMI.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(13, 379);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(443, 40);
            this.txtResult.TabIndex = 4;
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.Location = new System.Drawing.Point(376, 281);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(86, 31);
            this.lblHeightUnit.TabIndex = 5;
            this.lblHeightUnit.Text = "label1";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(376, 219);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(86, 31);
            this.lblWeightUnit.TabIndex = 5;
            this.lblWeightUnit.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 480);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 90);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lblResultList
            // 
            this.lblResultList.AutoSize = true;
            this.lblResultList.Location = new System.Drawing.Point(15, 446);
            this.lblResultList.Name = "lblResultList";
            this.lblResultList.Size = new System.Drawing.Size(219, 31);
            this.lblResultList.TabIndex = 7;
            this.lblResultList.Text = "Previous Results";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 89);
            this.panel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("GRACETIANS Cutting", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-5, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " APP TECH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(469, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResultList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.rdBtnImperial);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.rdBtnMetric);
            this.Controls.Add(this.BtnCalculateBMI);
            this.Controls.Add(this.lblHeightUnit);
            this.Controls.Add(this.lblWeightUnit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdBtnMetric;
        private System.Windows.Forms.RadioButton rdBtnImperial;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button BtnCalculateBMI;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblResultList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}

