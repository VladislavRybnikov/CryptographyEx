namespace CryptographyEx.WinFormsUI
{
    partial class EncodersCalculatorForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 305);
            this.panel2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Green;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 431);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 108);
            this.listBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.AnswerLbl);
            this.panel3.Location = new System.Drawing.Point(82, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 59);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 29);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Термінал обчислень";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.terminal_512;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(5, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 26);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Відповідь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип кодування";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.Calculator_PNG_Picture;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 84);
            this.panel1.TabIndex = 0;
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLbl.Location = new System.Drawing.Point(11, 22);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(0, 18);
            this.AnswerLbl.TabIndex = 6;
            // 
            // EncodersCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "EncodersCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncodersCalculatorForm";
            this.Load += new System.EventHandler(this.EncodersCalculatorForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label AnswerLbl;
    }
}