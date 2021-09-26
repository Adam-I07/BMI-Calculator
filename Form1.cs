using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class MainForm : Form
    {
        private double _height;
        private double _weight;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            _height = Convert.ToDouble(TextBoxHeight.Text);
            _weight = Convert.ToDouble(TextBoxWeight.Text);


            double finalHeight = _height * _height;
            double ans = _weight / finalHeight;
            double finalAns = Math.Round(ans, 2);
            labelBMICalculated.Text = ("The BMI is: " + finalAns);
        }

        private void buttonConvertPtoKG_Click(object sender, EventArgs e)
        {
            PoundToKGWindow pToKg = new PoundToKGWindow();
            pToKg.Show();
        }

        private void buttonConvertFtoM_Click(object sender, EventArgs e)
        {
            FeetToMWindow FtoM = new FeetToMWindow();
            FtoM.Show();
        }
    }
}
