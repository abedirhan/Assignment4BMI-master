using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Assignment4BMI
{
    public partial class BMICalculator : Form
    {
        private double _weight;
        private double _height;


        public double UserWeight
        {
            get { return _weight; }
            set
            {

                if (value < 0)
                {

                    MessageBox.Show("Please Enter a number other than the negative number.");

                }
                else
                {
                    _weight = value;
                }
            }
        }

        public double UserHeight
        {
            get { return _height; }
            set
            {

                if (value < 0)
                {

                    MessageBox.Show("Please Enter a number other than the negative number.");

                }
                else
                {
                    _height = value;
                }
            }
        }
        public double BMI { get; set; }


        public BMICalculator()
        {
            InitializeComponent();
            //            UserWeight = _weight;
            //            UserHeight = _height;
            //            BMI = _bmi;
        }

        public double BMICalculatorMetric(double weight, double height)
        {
            BMI = weight / (height * height);
            return BMI;
        }
        public double BMICalculatorImperial(double weight, double height)
        {
            BMI = weight * 703 / (height * height);
            return BMI;

        }
        public void Clean()
        {
            txtHeight.Clear();
            txtWeight.Clear();
            //            rdBtnImperial.Checked = false;
            //            rdBtnMetric.Checked = false;
            // txtResult.Clear();
           
            txtWeight.Focus();

        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

            BtnCalculateBMI.Enabled = false;

        }

        private void rdBtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMetric.Checked)
            {
                lblHeightUnit.Text = "m";
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

                BMI = BMICalculatorImperial(UserWeight, UserHeight);
                // BMI = UserWeight * 703 / (UserHeight * UserHeight);
                txtResult.Text = Convert.ToString($"{BMI:F2}");
            }

            if (rdBtnMetric.Checked)
            {
                BMI = BMICalculatorMetric(UserWeight, UserHeight);
                // BMI = UserWeight  / (UserHeight * UserHeight);
                txtResult.Text = Convert.ToString($"{BMI:F2}");
            }



            if (BMI < 18.5)
            {
                txtUnderWeight.BackColor = Color.Crimson;
                txtHeight.ForeColor = Color.White;
                // txtHeight.Font= FontStyle.Bold;
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                txtNormalWeight.BackColor = Color.LimeGreen;
                txtNormalWeight.ForeColor = Color.White;

            }
            else if (BMI > 25 && BMI < 29.9)
            {
                TxtOwerWeight.BackColor = Color.Tomato;
                TxtOwerWeight.ForeColor = Color.White;

            }
            else if (BMI > 30 && BMI < 34.9)
            {
                txtObese.Enabled = true;
                txtObese.BackColor = Color.Crimson;
                txtObese.ForeColor = Color.White;

            }
//            else if (BMI > 35)
//            {
//                txtNormalWeight.BackColor = Color.DarkRed;
//                txtNormalWeight.ForeColor = Color.White;
//
//            }




            Clean();

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                UserWeight = double.Parse(txtWeight.Text);



            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
            }


        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
//            txtObese.BackColor = Color.White;
//            txtObese.ForeColor = Color.Black;

            try
            {

                UserHeight = double.Parse(txtHeight.Text);
                if (txtWeight.Text.Length > 1)
                {
                    BtnCalculateBMI.Enabled = true;
                }
            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
            }
        }
    }
}
