﻿namespace CryptographyEx.WinFormsUI.View
{
    partial class TrithemiusControl
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
            this.downLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbCorrectAnsw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.downLabel.Location = new System.Drawing.Point(114, 136);
            this.downLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(184, 16);
            this.downLabel.TabIndex = 32;
            this.downLabel.Text = "закодоване повідомлення:";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.upLabel.Location = new System.Drawing.Point(26, 71);
            this.upLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(146, 16);
            this.upLabel.TabIndex = 31;
            this.upLabel.Text = "вхідне повідомлення:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(323, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "к-сть баллів";
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.Location = new System.Drawing.Point(351, 38);
            this.lbCurrentTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(16, 18);
            this.lbCurrentTask.TabIndex = 28;
            this.lbCurrentTask.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(230, 310);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 24);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbCorrectAnsw
            // 
            this.lbCorrectAnsw.AutoSize = true;
            this.lbCorrectAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnsw.Location = new System.Drawing.Point(96, 270);
            this.lbCorrectAnsw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrectAnsw.Name = "lbCorrectAnsw";
            this.lbCorrectAnsw.Size = new System.Drawing.Size(175, 20);
            this.lbCorrectAnsw.TabIndex = 26;
            this.lbCorrectAnsw.Text = "Правильна відповідь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "крок кодування";
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.Location = new System.Drawing.Point(96, 38);
            this.lbAllQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(20, 24);
            this.lbAllQuestions.TabIndex = 23;
            this.lbAllQuestions.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "/";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(65, 38);
            this.lbCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(20, 24);
            this.lbCorrectAnswer.TabIndex = 21;
            this.lbCorrectAnswer.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(139, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescription.Location = new System.Drawing.Point(30, 97);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(21, 24);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "0";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnswer.Location = new System.Drawing.Point(100, 163);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(213, 28);
            this.tbAnswer.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(259, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "функція переходу:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(205, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "F(x) =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(275, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "x + 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(231, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(277, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "0";
            // 
            // TrithemiusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentTask);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbCorrectAnsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbAnswer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrithemiusControl";
            this.Size = new System.Drawing.Size(425, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbCorrectAnsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAllQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbDescription;
        public System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
    }
}
