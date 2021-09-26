
namespace BMI_Calculator
{
    partial class MainForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.TextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.TextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelBMICalculated = new System.Windows.Forms.Label();
            this.buttonConvertFtoM = new System.Windows.Forms.Button();
            this.buttonConvertPtoKG = new System.Windows.Forms.Button();
            this.labelPtoKGExplain = new System.Windows.Forms.Label();
            this.labelConvertFtoMExplined = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(20, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "BMI Calculator";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(22, 75);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(96, 20);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Weight(kg)";
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(26, 99);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(100, 26);
            this.TextBoxWeight.TabIndex = 2;
            this.TextBoxWeight.ValidatingType = typeof(int);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(26, 179);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(88, 20);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height(m)";
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(30, 203);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.TextBoxHeight.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(242, 262);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(136, 35);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelBMICalculated
            // 
            this.labelBMICalculated.AutoSize = true;
            this.labelBMICalculated.Location = new System.Drawing.Point(30, 277);
            this.labelBMICalculated.Name = "labelBMICalculated";
            this.labelBMICalculated.Size = new System.Drawing.Size(0, 20);
            this.labelBMICalculated.TabIndex = 6;
            // 
            // buttonConvertFtoM
            // 
            this.buttonConvertFtoM.Location = new System.Drawing.Point(151, 179);
            this.buttonConvertFtoM.Name = "buttonConvertFtoM";
            this.buttonConvertFtoM.Size = new System.Drawing.Size(136, 35);
            this.buttonConvertFtoM.TabIndex = 7;
            this.buttonConvertFtoM.Text = "Feet to Meters";
            this.buttonConvertFtoM.UseVisualStyleBackColor = true;
            this.buttonConvertFtoM.Click += new System.EventHandler(this.buttonConvertFtoM_Click);
            // 
            // buttonConvertPtoKG
            // 
            this.buttonConvertPtoKG.Location = new System.Drawing.Point(151, 90);
            this.buttonConvertPtoKG.Name = "buttonConvertPtoKG";
            this.buttonConvertPtoKG.Size = new System.Drawing.Size(136, 35);
            this.buttonConvertPtoKG.TabIndex = 8;
            this.buttonConvertPtoKG.Text = "Pounds to Kg";
            this.buttonConvertPtoKG.UseVisualStyleBackColor = true;
            this.buttonConvertPtoKG.Click += new System.EventHandler(this.buttonConvertPtoKG_Click);
            // 
            // labelPtoKGExplain
            // 
            this.labelPtoKGExplain.AutoSize = true;
            this.labelPtoKGExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtoKGExplain.Location = new System.Drawing.Point(175, 128);
            this.labelPtoKGExplain.Name = "labelPtoKGExplain";
            this.labelPtoKGExplain.Size = new System.Drawing.Size(238, 15);
            this.labelPtoKGExplain.TabIndex = 9;
            this.labelPtoKGExplain.Text = "Click on the button to convert pounds to kg.";
            // 
            // labelConvertFtoMExplined
            // 
            this.labelConvertFtoMExplined.AutoSize = true;
            this.labelConvertFtoMExplined.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertFtoMExplined.Location = new System.Drawing.Point(175, 217);
            this.labelConvertFtoMExplined.Name = "labelConvertFtoMExplined";
            this.labelConvertFtoMExplined.Size = new System.Drawing.Size(242, 15);
            this.labelConvertFtoMExplined.TabIndex = 10;
            this.labelConvertFtoMExplined.Text = "Click on the button to convert feet to meters.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 325);
            this.Controls.Add(this.labelConvertFtoMExplined);
            this.Controls.Add(this.labelPtoKGExplain);
            this.Controls.Add(this.buttonConvertPtoKG);
            this.Controls.Add(this.buttonConvertFtoM);
            this.Controls.Add(this.labelBMICalculated);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.MaskedTextBox TextBoxWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.MaskedTextBox TextBoxHeight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelBMICalculated;
        private System.Windows.Forms.Button buttonConvertFtoM;
        private System.Windows.Forms.Button buttonConvertPtoKG;
        private System.Windows.Forms.Label labelPtoKGExplain;
        private System.Windows.Forms.Label labelConvertFtoMExplined;
    }
}

