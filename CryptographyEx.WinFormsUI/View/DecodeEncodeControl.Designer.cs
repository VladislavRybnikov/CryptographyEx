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
            this.SuspendLayout();
            // 
            // btnDecoding
            // 
            this.btnDecoding.Location = new System.Drawing.Point(485, 64);
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(121, 56);
            this.btnDecoding.TabIndex = 3;
            this.btnDecoding.Text = "Декодування";
            this.btnDecoding.UseVisualStyleBackColor = true;
            this.btnDecoding.Click += new System.EventHandler(this.btnDecoding_Click);
            // 
            // btnEncoding
            // 
            this.btnEncoding.Location = new System.Drawing.Point(120, 64);
            this.btnEncoding.Name = "btnEncoding";
            this.btnEncoding.Size = new System.Drawing.Size(121, 56);
            this.btnEncoding.TabIndex = 2;
            this.btnEncoding.Text = "Кодування";
            this.btnEncoding.UseVisualStyleBackColor = true;
            this.btnEncoding.Click += new System.EventHandler(this.btnEncoding_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Location = new System.Drawing.Point(225, 164);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(526, 331);
            this.panelQuestion.TabIndex = 4;
            // 
            // DecodeEncodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.btnDecoding);
            this.Controls.Add(this.btnEncoding);
            this.Name = "DecodeEncodeControl";
            this.Size = new System.Drawing.Size(811, 607);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecoding;
        private System.Windows.Forms.Button btnEncoding;
        public System.Windows.Forms.Panel panelQuestion;
    }
}
