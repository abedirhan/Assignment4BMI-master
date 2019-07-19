using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment4BMI
{
    static class Program
    {
        public static Dictionary<FormEnum, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormEnum, Form>();
            Forms.Add(FormEnum.START_FORM, new WelcomeForm());
            Forms.Add(FormEnum.BMI_Form, new BmiCalculator());
          
            Application.Run(Forms[FormEnum.START_FORM]);
        }
    }
}
