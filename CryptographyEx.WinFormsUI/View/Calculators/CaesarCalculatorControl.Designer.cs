namespace CryptographyEx.WinFormsUI.View.Calculators
{
    partial class CaesarCalculatorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upLabel = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            this.SuspendLayout();
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.upLabel.Location = new System.Drawing.Point(143, 63);
            this.upLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(146, 16);
            this.upLabel.TabIndex = 21;
            this.upLabel.Text = "вхідне повідомлення:";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownStep.Location = new System.Drawing.Point(235, 134);
            this.numericUpDownStep.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownStep.TabIndex = 20;
            this.numericUpDownStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownStep.ValueChanged += new System.EventHandler(this.numericUpDownStep_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "крок кодування";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(108, 81);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(213, 28);
            this.inputTextBox.TabIndex = 17;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // CaesarCalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.numericUpDownStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTextBox);
            this.Name = "CaesarCalculatorControl";
            this.Size = new System.Drawing.Size(444, 220);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox inputTextBox;
    }
}
