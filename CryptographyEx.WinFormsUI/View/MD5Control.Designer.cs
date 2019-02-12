namespace CryptographyEx.WinFormsUI.View
{
    partial class MD5Control
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
            this.lblAnswerInfo = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbCorrectAnsw = new System.Windows.Forms.Label();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnswerInfo
            // 
            this.lblAnswerInfo.AutoSize = true;
            this.lblAnswerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerInfo.Location = new System.Drawing.Point(359, 286);
            this.lblAnswerInfo.Name = "lblAnswerInfo";
            this.lblAnswerInfo.Size = new System.Drawing.Size(73, 25);
            this.lblAnswerInfo.TabIndex = 47;
            this.lblAnswerInfo.Text = "Вірно!";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.downLabel.Location = new System.Drawing.Point(263, 150);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(237, 20);
            this.downLabel.TabIndex = 46;
            this.downLabel.Text = "закодоване повідомлення:";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.upLabel.Location = new System.Drawing.Point(291, 66);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(191, 20);
            this.upLabel.TabIndex = 45;
            this.upLabel.Text = "вхідне повідомлення:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(541, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(159, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "к-сть баллів";
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.Location = new System.Drawing.Point(579, 33);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(20, 24);
            this.lbCurrentTask.TabIndex = 42;
            this.lbCurrentTask.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(353, 367);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 30);
            this.btnCheck.TabIndex = 41;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbCorrectAnsw
            // 
            this.lbCorrectAnsw.AutoSize = true;
            this.lbCorrectAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnsw.Location = new System.Drawing.Point(90, 318);
            this.lbCorrectAnsw.Name = "lbCorrectAnsw";
            this.lbCorrectAnsw.Size = new System.Drawing.Size(206, 25);
            this.lbCorrectAnsw.TabIndex = 40;
            this.lbCorrectAnsw.Text = "Правильна відповідь:";
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.Location = new System.Drawing.Point(239, 33);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(26, 29);
            this.lbAllQuestions.TabIndex = 39;
            this.lbAllQuestions.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "/";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(197, 33);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(26, 29);
            this.lbCorrectAnswer.TabIndex = 37;
            this.lbCorrectAnswer.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(353, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 36;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescription.Location = new System.Drawing.Point(276, 107);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(0, 29);
            this.lbDescription.TabIndex = 35;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnswer.Location = new System.Drawing.Point(244, 183);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(283, 34);
            this.tbAnswer.TabIndex = 34;
            // 
            // MD5Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAnswerInfo);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentTask);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbCorrectAnsw);
            this.Controls.Add(this.lbAllQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbAnswer);
            this.Name = "MD5Control";
            this.Size = new System.Drawing.Size(734, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswerInfo;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbCorrectAnsw;
        private System.Windows.Forms.Label lbAllQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbDescription;
        public System.Windows.Forms.TextBox tbAnswer;
    }
}
