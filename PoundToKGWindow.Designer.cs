
namespace BMI_Calculator
{
    partial class PoundToKGWindow
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
            this.labelPtoKGLabel = new System.Windows.Forms.Label();
            this.labelExplainFormat = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.TextBoxPoundInput = new System.Windows.Forms.MaskedTextBox();
            this.labelDisplayInKg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPtoKGLabel
            // 
            this.labelPtoKGLabel.AutoSize = true;
            this.labelPtoKGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtoKGLabel.Location = new System.Drawing.Point(12, 9);
            this.labelPtoKGLabel.Name = "labelPtoKGLabel";
            this.labelPtoKGLabel.Size = new System.Drawing.Size(233, 16);
            this.labelPtoKGLabel.TabIndex = 0;
            this.labelPtoKGLabel.Text = "Convert from Pound to Kilograms";
            // 
            // labelExplainFormat
            // 
            this.labelExplainFormat.AutoSize = true;
            this.labelExplainFormat.Location = new System.Drawing.Point(12, 41);
            this.labelExplainFormat.Name = "labelExplainFormat";
            this.labelExplainFormat.Size = new System.Drawing.Size(224, 13);
            this.labelExplainFormat.TabIndex = 1;
            this.labelExplainFormat.Text = "Enter your weight in the following format: 23.4 ";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(170, 63);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 30);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // TextBoxPoundInput
            // 
            this.TextBoxPoundInput.Location = new System.Drawing.Point(50, 69);
            this.TextBoxPoundInput.Name = "TextBoxPoundInput";
            this.TextBoxPoundInput.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPoundInput.TabIndex = 3;
            this.TextBoxPoundInput.ValidatingType = typeof(int);
            // 
            // labelDisplayInKg
            // 
            this.labelDisplayInKg.AutoSize = true;
            this.labelDisplayInKg.Location = new System.Drawing.Point(15, 119);
            this.labelDisplayInKg.Name = "labelDisplayInKg";
            this.labelDisplayInKg.Size = new System.Drawing.Size(0, 13);
            this.labelDisplayInKg.TabIndex = 4;
            // 
            // PoundToKGWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.labelDisplayInKg);
            this.Controls.Add(this.TextBoxPoundInput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelExplainFormat);
            this.Controls.Add(this.labelPtoKGLabel);
            this.Name = "PoundToKGWindow";
            this.Text = "PoundToKGWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPtoKGLabel;
        private System.Windows.Forms.Label labelExplainFormat;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.MaskedTextBox TextBoxPoundInput;
        private System.Windows.Forms.Label labelDisplayInKg;
    }
}