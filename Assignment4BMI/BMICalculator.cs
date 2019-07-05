using System;
using System.Windows.Forms;

namespace Assignment4BMI
{
    public partial class BMICalculator : Form
    {
        private int _weight;
        private int _height;
        private int _bmi;
        public int Weight { get; set; }
        public int UserHeight { get; set; }
        public int BMI { get; set; }


        public BMICalculator()
        {
            InitializeComponent();
            Weight = _weight;
            UserHeight = _height;
            BMI = _bmi;
        }

        public int BMICalculatorMetric(int weight, int height)
        {
            BMI = Weight / (height * height);
            return BMI;
        }
        public int BMICalculatorImperial(int weight, int height)
        {
            BMI = Weight * 703 / (height * height);
            return BMI;

        }
        public void Clean()
        {
            txtHeight.Clear();
            txtWeight.Clear();

            txtResult.Clear();

        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

           BtnCalculateBMI.Enabled = false;

        }

        private void rdBtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMetric.Checked)
            {
                lblHeightUnit.Text = "cm";
                lblWeightUnit.Text = "kg";

            }
        }

        private void rdBtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnImperial.Checked)
            {
                lblHeightUnit.Text = "in";
                lblWeightUnit.Text = "lb";

            }

        }

        private void BtnCalculateBMI_Click(object sender, EventArgs e)
        {
           

            if (rdBtnImperial.Checked)
            {
                var a = BMICalculatorImperial(Weight, Height);
                txtResult.Text = Convert.ToString(a);
            }

            if (rdBtnMetric.Checked)
            {
                var a = BMICalculatorMetric(Weight, Height);
                txtResult.Text = Convert.ToString(a);
            }

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Weight = int.Parse(txtWeight.Text);
               
                BtnCalculateBMI.Enabled = true;
            }
            catch
            {
                 BtnCalculateBMI.Enabled = false;
            }


        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                Height = int.Parse(txtHeight.Text);
                BtnCalculateBMI.Enabled = true;
            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
            }

        }
    }
}
