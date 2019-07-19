using System;
using System.Windows.Forms;

namespace Assignment4BMI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            AnimationTimer.Enabled = true;
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 100)
            {
                Program.Forms[FormEnum.BMI_Form].Show();
                Hide();
            }

        }


    }
}
