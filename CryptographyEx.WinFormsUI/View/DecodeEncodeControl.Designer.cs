namespace CryptographyEx.WinFormsUI.View
{
    partial class DecodeEncodeControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecoding = new System.Windows.Forms.Button();
            this.btnEncoding = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDecoding
            // 
            this.btnDecoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnDecoding.Location = new System.Drawing.Point(372, 64);
            this.btnDecoding.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(95, 33);
            this.btnDecoding.TabIndex = 3;
            this.btnDecoding.Text = "Декодування";
            this.btnDecoding.UseVisualStyleBackColor = false;
            this.btnDecoding.Click += new System.EventHandler(this.btnDecoding_Click);
            // 
            // btnEncoding
            // 
            this.btnEncoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncoding.Location = new System.Drawing.Point(156, 64);
            this.btnEncoding.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncoding.Name = "btnEncoding";
            this.btnEncoding.Size = new System.Drawing.Size(97, 33);
            this.btnEncoding.TabIndex = 2;
            this.btnEncoding.Text = "Кодування";
            this.btnEncoding.UseVisualStyleBackColor = false;
            this.btnEncoding.Click += new System.EventHandler(this.btnEncoding_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Location = new System.Drawing.Point(105, 116);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(429, 349);
            this.panelQuestion.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Шифр";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Controls.Add(this.nameLabel);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(608, 30);
            this.panel9.TabIndex = 43;
            // 
            // DecodeEncodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.btnDecoding);
            this.Controls.Add(this.btnEncoding);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DecodeEncodeControl";
            this.Size = new System.Drawing.Size(606, 491);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecoding;
        private System.Windows.Forms.Button btnEncoding;
        public System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel9;
    }
}
