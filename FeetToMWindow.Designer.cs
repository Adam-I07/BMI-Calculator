
namespace BMI_Calculator
{
    partial class FeetToMWindow
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
            this.labelFtoMTitle = new System.Windows.Forms.Label();
            this.labelExplainFormat = new System.Windows.Forms.Label();
            this.labelReturnInPound = new System.Windows.Forms.Label();
            this.textBoxInputFeet = new System.Windows.Forms.TextBox();
            this.buttomCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFtoMTitle
            // 
            this.labelFtoMTitle.AutoSize = true;
            this.labelFtoMTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFtoMTitle.Location = new System.Drawing.Point(12, 9);
            this.labelFtoMTitle.Name = "labelFtoMTitle";
            this.labelFtoMTitle.Size = new System.Drawing.Size(235, 20);
            this.labelFtoMTitle.TabIndex = 0;
            this.labelFtoMTitle.Text = "Convert from Feet to Meters";
            // 
            // labelExplainFormat
            // 
            this.labelExplainFormat.AutoSize = true;
            this.labelExplainFormat.Location = new System.Drawing.Point(13, 39);
            this.labelExplainFormat.Name = "labelExplainFormat";
            this.labelExplainFormat.Size = new System.Drawing.Size(275, 13);
            this.labelExplainFormat.TabIndex = 2;
            this.labelExplainFormat.Text = "Enter your height in the following format: if 5 foot 6 do 5.6";
            // 
            // labelReturnInPound
            // 
            this.labelReturnInPound.AutoSize = true;
            this.labelReturnInPound.Location = new System.Drawing.Point(13, 107);
            this.labelReturnInPound.Name = "labelReturnInPound";
            this.labelReturnInPound.Size = new System.Drawing.Size(0, 13);
            this.labelReturnInPound.TabIndex = 3;
            // 
            // textBoxInputFeet
            // 
            this.textBoxInputFeet.Location = new System.Drawing.Point(64, 74);
            this.textBoxInputFeet.Name = "textBoxInputFeet";
            this.textBoxInputFeet.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputFeet.TabIndex = 4;
            // 
            // buttomCalculate
            // 
            this.buttomCalculate.Location = new System.Drawing.Point(181, 68);
            this.buttomCalculate.Name = "buttomCalculate";
            this.buttomCalculate.Size = new System.Drawing.Size(89, 30);
            this.buttomCalculate.TabIndex = 5;
            this.buttomCalculate.Text = "Calculate";
            this.buttomCalculate.UseVisualStyleBackColor = true;
            this.buttomCalculate.Click += new System.EventHandler(this.buttomCalculate_Click);
            // 
            // FeetToMWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 181);
            this.Controls.Add(this.buttomCalculate);
            this.Controls.Add(this.textBoxInputFeet);
            this.Controls.Add(this.labelReturnInPound);
            this.Controls.Add(this.labelExplainFormat);
            this.Controls.Add(this.labelFtoMTitle);
            this.Name = "FeetToMWindow";
            this.Text = "FeetToMWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFtoMTitle;
        private System.Windows.Forms.Label labelExplainFormat;
        private System.Windows.Forms.Label labelReturnInPound;
        private System.Windows.Forms.TextBox textBoxInputFeet;
        private System.Windows.Forms.Button buttomCalculate;
    }
}