using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment4BMI
{
    public partial class BmiCalculator : Form
    {
        private double _weight;
        private double _height;
        /// <summary>
        /// User height get and set value with validation
        /// </summary>
        public double UserWeight
        {
            get { return _weight; }
            set
            {
                if (value > 300 || value < 1)
                {
                    MessageBox.Show(" You can enter value between 1 to-300 KG");
                    txtWeight.Clear();
                }
                else
                {
                    _weight = value;

                }
            }
        }
        /// <summary>
        /// User height get and set value with validation
        /// </summary>
        public double UserHeight
        {
            get { return _height; }
            set
            {
                if (value > 3 )
                {
                    MessageBox.Show("Please enter number between 0.3-3 meter");
                    txtHeight.Clear();
                    
                }
                else
                {
                    _height = value;


                }
            }
        }
        public double Bmi { get; set; }


        public BmiCalculator()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Metric Clculation method.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double BmiCalculatorMetric(double weight, double height)
        {
            Bmi = weight / (height * height);
            return Bmi;
        }
        /// <summary>
        /// Imperial calculation methods.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double BmiCalculatorImperial(double weight, double height)
        {
            Bmi = weight * 703 / (height * height);
            return Bmi;

        }
        /// <summary>
        /// Clean method reset forms and reset multiline indicator. 
        /// </summary>
        public void Clean()
        {
            txtHeight.Clear();
            txtWeight.Clear();
            //            rdBtnImperial.Checked = false;
            //            rdBtnMetric.Checked = false;
            txtResult.Clear();

            txtWeight.Focus();
            txtUnderWeight.BackColor = Color.White;
            txtHeight.ForeColor = Color.Black;

            txtNormalWeight.BackColor = Color.White;
            txtNormalWeight.ForeColor = Color.Black;

            TxtOwerWeight.BackColor = Color.White;
            TxtOwerWeight.ForeColor = Color.Black;


            txtObese.BackColor = Color.White;
            txtObese.ForeColor = Color.Black;
            BtnReset.Enabled = false;
        }

        public void LevelIndicatorClean()
        {
            txtUnderWeight.BackColor = Color.White;
            txtHeight.ForeColor = Color.Black;

            txtNormalWeight.BackColor = Color.White;
            txtNormalWeight.ForeColor = Color.Black;

            TxtOwerWeight.BackColor = Color.White;
            TxtOwerWeight.ForeColor = Color.Black;


            txtObese.BackColor = Color.White;
            txtObese.ForeColor = Color.Black;
        }
        /// <summary>
        /// BMI calculator form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            KeyPreview = true;


            BtnCalculateBMI.Enabled = false;
            BtnReset.Enabled = false;
            if (rdBtnImperial.Checked)
            {
                lblHeightUnit.Text = "in";
                lblWeightUnit.Text = "lb";

            }
            if (rdBtnMetric.Checked)
            {
                lblHeightUnit.Text = "m";
                lblWeightUnit.Text = "kg";

            }

        }
        /// <summary>
        /// Metric radio button checked event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMetric.Checked)
            {
                lblHeightUnit.Text = "m";
                lblWeightUnit.Text = "kg";

            }
        }
        /// <summary>
        /// Imperial radio button checked event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnImperial.Checked)
            {
                lblHeightUnit.Text = "in";
                lblWeightUnit.Text = "lb";

            }

        }
        /// <summary>
        /// Calculation button clicked event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserHeight != 0 )
                {
                    if (rdBtnImperial.Checked)
                    {

                        Bmi = BmiCalculatorImperial(UserWeight, UserHeight);
                        // BMI = UserWeight * 703 / (UserHeight * UserHeight);
                        txtResult.Text = Convert.ToString($"{Bmi:F2}");
                    }

                    if (rdBtnMetric.Checked)
                    {
                        Bmi = BmiCalculatorMetric(UserWeight, UserHeight);
                        // BMI = UserWeight  / (UserHeight * UserHeight);
                        txtResult.Text = Convert.ToString($"{Bmi:F2}");
                    }
                    if (Bmi < 18.5)
                    {
                        txtUnderWeight.BackColor = Color.Crimson;
                        txtUnderWeight.ForeColor = Color.White;
                        // txtHeight.Font= FontStyle.Bold;
                    }
                    else if (Bmi > 18.5 && Bmi < 24.9)
                    {
                        txtNormalWeight.BackColor = Color.LimeGreen;
                        txtNormalWeight.ForeColor = Color.White;
                    }
                    else if (Bmi > 25 && Bmi < 29.9)
                    {
                        TxtOwerWeight.BackColor = Color.Tomato;
                        TxtOwerWeight.ForeColor = Color.White;

                    }
                    else if (Bmi > 30)
                    {
                        txtObese.BackColor = Color.Crimson;
                        txtObese.ForeColor = Color.White;

                    }

                    BtnReset.Enabled = true;
                    

                }
            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
                MessageBox.Show("0 devision error");
            }

        }
        /// <summary>
        /// Weight text box text changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            LevelIndicatorClean();
            try

            {
                UserWeight = double.Parse(txtWeight.Text);
                if (txtHeight.Text.Length > 1 && txtWeight.Text.Length > 1)
                {
                    BtnCalculateBMI.Enabled = true;
                }

            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
            }


        }
        /// <summary>
        /// Height text box text changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            LevelIndicatorClean();
            try

            {
                UserHeight = double.Parse(txtHeight.Text);
                if (txtHeight.Text.Length >1 && txtWeight.Text.Length > 1)
                {
                    BtnCalculateBMI.Enabled = true;

                }

            }
            catch
            {
                BtnCalculateBMI.Enabled = false;
            }

        }
        /// <summary>
        /// Clear button clicked event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {

            Clean();
        }
        /// <summary>
        /// Letter and multi decimal point fixed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
          TextBoxImputDecimalOnly(sender,e);

        }
        /// <summary>
        /// Letter and Multi decimal point fixed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxImputDecimalOnly(sender, e);
        }
        /// <summary>
        /// Text box number , decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TextBoxImputDecimalOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BmiCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
