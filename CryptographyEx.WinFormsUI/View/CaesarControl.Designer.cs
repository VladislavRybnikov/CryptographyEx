namespace CryptographyEx.WinFormsUI.View
{
    partial class CaesarControl
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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.lbCorrectAnsw = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.lblAnswerInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnswer.Location = new System.Drawing.Point(105, 164);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(213, 28);
            this.tbAnswer.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescription.Location = new System.Drawing.Point(129, 102);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(0, 24);
            this.lbDescription.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(187, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(70, 42);
            this.lbCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(20, 24);
            this.lbCorrectAnswer.TabIndex = 4;
            this.lbCorrectAnswer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.Location = new System.Drawing.Point(101, 42);
            this.lbAllQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(20, 24);
            this.lbAllQuestions.TabIndex = 6;
            this.lbAllQuestions.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "крок кодування";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownStep.Location = new System.Drawing.Point(228, 196);
            this.numericUpDownStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownStep.TabIndex = 9;
            this.numericUpDownStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownStep.ValueChanged += new System.EventHandler(this.numericUpDownStep_ValueChanged);
            // 
            // lbCorrectAnsw
            // 
            this.lbCorrectAnsw.AutoSize = true;
            this.lbCorrectAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnsw.Location = new System.Drawing.Point(101, 274);
            this.lbCorrectAnsw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrectAnsw.Name = "lbCorrectAnsw";
            this.lbCorrectAnsw.Size = new System.Drawing.Size(175, 20);
            this.lbCorrectAnsw.TabIndex = 10;
            this.lbCorrectAnsw.Text = "Правильна відповідь:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(180, 314);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 24);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.Location = new System.Drawing.Point(364, 44);
            this.lbCurrentTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(16, 18);
            this.lbCurrentTask.TabIndex = 12;
            this.lbCurrentTask.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "к-сть баллів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(336, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "N:";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.upLabel.Location = new System.Drawing.Point(122, 74);
            this.upLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(146, 16);
            this.upLabel.TabIndex = 15;
            this.upLabel.Text = "вхідне повідомлення:";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.downLabel.Location = new System.Drawing.Point(122, 130);
            this.downLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(184, 16);
            this.downLabel.TabIndex = 16;
            this.downLabel.Text = "закодоване повідомлення:";
            // 
            // lblAnswerInfo
            // 
            this.lblAnswerInfo.AutoSize = true;
            this.lblAnswerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerInfo.Location = new System.Drawing.Point(191, 248);
            this.lblAnswerInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswerInfo.Name = "lblAnswerInfo";
            this.lblAnswerInfo.Size = new System.Drawing.Size(60, 20);
            this.lblAnswerInfo.TabIndex = 17;
            this.lblAnswerInfo.Text = "Вірно!";
            // 
            // CaesarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAnswerInfo);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentTask);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbCorrectAnsw);
            this.Controls.Add(this.numericUpDownStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbAnswer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CaesarControl";
            this.Size = new System.Drawing.Size(438, 354);
            this.Load += new System.EventHandler(this.CaesarControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       public System.Windows.Forms.TextBox tbAnswer;
       public System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAllQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label lbCorrectAnsw;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label lblAnswerInfo;
    }
}
