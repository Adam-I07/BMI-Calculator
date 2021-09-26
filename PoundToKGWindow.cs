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
    public partial class PoundToKGWindow : Form
    {
        private double _weightInPound;
        public PoundToKGWindow()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            _weightInPound = Convert.ToDouble(TextBoxPoundInput.Text);
            double ans = _weightInPound * 0.453592;
            double finalAns = Math.Round(ans, 2);
            labelDisplayInKg.Text = ("Converted to Kilograms is: " + finalAns);

        }
    }
}
