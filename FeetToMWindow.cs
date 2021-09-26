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
    public partial class FeetToMWindow : Form
    {
        private double _HeightinFeet;
        public FeetToMWindow()
        {
            InitializeComponent();
        }

        private void buttomCalculate_Click(object sender, EventArgs e)
        {
            _HeightinFeet = Convert.ToDouble(textBoxInputFeet.Text);
            double ans = _HeightinFeet / 3.28;
            double finalAns = Math.Round(ans, 2);
            labelReturnInPound.Text = ("In pounds it is " + finalAns);
        }
    }
}
