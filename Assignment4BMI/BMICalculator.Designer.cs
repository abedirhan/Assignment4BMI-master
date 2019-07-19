namespace Assignment4BMI
{
    partial class BmiCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmiCalculator));
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultList = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdBtnMetric = new System.Windows.Forms.RadioButton();
            this.rdBtnImperial = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtUnderWeight = new System.Windows.Forms.TextBox();
            this.txtNormalWeight = new System.Windows.Forms.TextBox();
            this.TxtOwerWeight = new System.Windows.Forms.TextBox();
            this.txtObese = new System.Windows.Forms.TextBox();
            this.BtnCalculateBMI = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(5, 77);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(128, 38);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "My Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(5, 35);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(128, 42);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "My Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.Font = new System.Drawing.Font("Corbel", 14F);
            this.lblHeightUnit.Location = new System.Drawing.Point(260, 77);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(33, 38);
            this.lblHeightUnit.TabIndex = 5;
            this.lblHeightUnit.Text = "--";
            this.lblHeightUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Corbel", 14F);
            this.lblWeightUnit.Location = new System.Drawing.Point(260, 35);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(33, 42);
            this.lblWeightUnit.TabIndex = 5;
            this.lblWeightUnit.Text = "--";
            this.lblWeightUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Corbel", 14F);
            this.txtWeight.Location = new System.Drawing.Point(141, 38);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(113, 30);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelTitle.Controls.Add(this.pictureBox2);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(3, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(296, 49);
            this.panelTitle.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblResultList
            // 
            this.lblResultList.AutoSize = true;
            this.lblResultList.Font = new System.Drawing.Font("Corbel", 16F);
            this.lblResultList.Location = new System.Drawing.Point(3, 263);
            this.lblResultList.Name = "lblResultList";
            this.lblResultList.Size = new System.Drawing.Size(150, 27);
            this.lblResultList.TabIndex = 7;
            this.lblResultList.Text = "Level Indicator ";
            this.lblResultList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtResult.Enabled = false;
            this.txtResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult.Location = new System.Drawing.Point(3, 222);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(296, 38);
            this.txtResult.TabIndex = 9;
            // 
            // rdBtnMetric
            // 
            this.rdBtnMetric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdBtnMetric.AutoSize = true;
            this.rdBtnMetric.Checked = true;
            this.rdBtnMetric.Font = new System.Drawing.Font("Corbel", 14F);
            this.rdBtnMetric.Location = new System.Drawing.Point(55, 3);
            this.rdBtnMetric.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdBtnMetric.Name = "rdBtnMetric";
            this.rdBtnMetric.Size = new System.Drawing.Size(78, 29);
            this.rdBtnMetric.TabIndex = 1;
            this.rdBtnMetric.TabStop = true;
            this.rdBtnMetric.Text = "Metric";
            this.rdBtnMetric.UseVisualStyleBackColor = true;
            this.rdBtnMetric.CheckedChanged += new System.EventHandler(this.rdBtnMetric_CheckedChanged);
            // 
            // rdBtnImperial
            // 
            this.rdBtnImperial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdBtnImperial.AutoSize = true;
            this.rdBtnImperial.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnImperial.Location = new System.Drawing.Point(161, 3);
            this.rdBtnImperial.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdBtnImperial.Name = "rdBtnImperial";
            this.rdBtnImperial.Size = new System.Drawing.Size(91, 29);
            this.rdBtnImperial.TabIndex = 2;
            this.rdBtnImperial.Text = "Imperial";
            this.rdBtnImperial.UseVisualStyleBackColor = true;
            this.rdBtnImperial.CheckedChanged += new System.EventHandler(this.rdBtnImperial_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Corbel", 14F);
            this.txtHeight.Location = new System.Drawing.Point(141, 80);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(113, 30);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtUnderWeight
            // 
            this.txtUnderWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnderWeight.Enabled = false;
            this.txtUnderWeight.Font = new System.Drawing.Font("Corbel", 14F);
            this.txtUnderWeight.Location = new System.Drawing.Point(3, 296);
            this.txtUnderWeight.Name = "txtUnderWeight";
            this.txtUnderWeight.Size = new System.Drawing.Size(296, 30);
            this.txtUnderWeight.TabIndex = 0;
            this.txtUnderWeight.Text = "Under Weight Increased Risk";
            this.txtUnderWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNormalWeight
            // 
            this.txtNormalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNormalWeight.Enabled = false;
            this.txtNormalWeight.Font = new System.Drawing.Font("Corbel", 14F);
            this.txtNormalWeight.Location = new System.Drawing.Point(3, 332);
            this.txtNormalWeight.Name = "txtNormalWeight";
            this.txtNormalWeight.Size = new System.Drawing.Size(296, 30);
            this.txtNormalWeight.TabIndex = 0;
            this.txtNormalWeight.Text = "Normal Weight Least Risk";
            this.txtNormalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtOwerWeight
            // 
            this.TxtOwerWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOwerWeight.Enabled = false;
            this.TxtOwerWeight.Font = new System.Drawing.Font("Corbel", 14F);
            this.TxtOwerWeight.Location = new System.Drawing.Point(3, 367);
            this.TxtOwerWeight.Name = "TxtOwerWeight";
            this.TxtOwerWeight.Size = new System.Drawing.Size(296, 30);
            this.TxtOwerWeight.TabIndex = 0;
            this.TxtOwerWeight.Text = "Over Weight Increased Risk";
            this.TxtOwerWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObese
            // 
            this.txtObese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObese.Enabled = false;
            this.txtObese.Font = new System.Drawing.Font("Corbel", 14F);
            this.txtObese.Location = new System.Drawing.Point(3, 402);
            this.txtObese.Name = "txtObese";
            this.txtObese.Size = new System.Drawing.Size(296, 30);
            this.txtObese.TabIndex = 0;
            this.txtObese.Text = "Obesee High Risk";
            this.txtObese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculateBMI
            // 
            this.BtnCalculateBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.BtnCalculateBMI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalculateBMI.Font = new System.Drawing.Font("Corbel", 15F);
            this.BtnCalculateBMI.Location = new System.Drawing.Point(3, 118);
            this.BtnCalculateBMI.Name = "BtnCalculateBMI";
            this.BtnCalculateBMI.Size = new System.Drawing.Size(132, 37);
            this.BtnCalculateBMI.TabIndex = 5;
            this.BtnCalculateBMI.Text = "Calculate";
            this.BtnCalculateBMI.UseVisualStyleBackColor = false;
            this.BtnCalculateBMI.Click += new System.EventHandler(this.BtnCalculateBMI_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtObese, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNormalWeight, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtUnderWeight, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResultList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtOwerWeight, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.10276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.02757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.518797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.022556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.77193F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.923884F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 437);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.69422F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83784F));
            this.tableLayoutPanel2.Controls.Add(this.rdBtnMetric, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdBtnImperial, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHeightUnit, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblWeight, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblWeightUnit, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtWeight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHeight, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnCalculateBMI, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnReset, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblHeight, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.37762F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.58228F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.05063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.58228F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 158);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Font = new System.Drawing.Font("Corbel", 15F);
            this.BtnReset.Location = new System.Drawing.Point(141, 118);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(113, 37);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Clear";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(123)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "BmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BmiCalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResultList;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rdBtnMetric;
        private System.Windows.Forms.RadioButton rdBtnImperial;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtUnderWeight;
        private System.Windows.Forms.TextBox txtNormalWeight;
        private System.Windows.Forms.TextBox TxtOwerWeight;
        private System.Windows.Forms.TextBox txtObese;
        private System.Windows.Forms.Button BtnCalculateBMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

