namespace CryptographyEx.WinFormsUI.View
{
    partial class RSAControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, -20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "к-сть баллів";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(522, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "N:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(358, 356);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 30);
            this.btnCheck.TabIndex = 44;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(470, 356);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 30);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Далі";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(439, 280);
            this.tbKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 30);
            this.tbKey.TabIndex = 42;
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.Location = new System.Drawing.Point(559, 10);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(20, 24);
            this.lbCurrentTask.TabIndex = 41;
            this.lbCurrentTask.Text = "0";
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.Location = new System.Drawing.Point(74, 5);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(26, 29);
            this.lbAllQuestions.TabIndex = 40;
            this.lbAllQuestions.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(55, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(348, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ключ: ";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(31, 5);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(26, 29);
            this.lbCorrectAnswer.TabIndex = 38;
            this.lbCorrectAnswer.Text = "0";
            // 
            // tbG
            // 
            this.tbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbG.Location = new System.Drawing.Point(418, 204);
            this.tbG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbG.Name = "tbG";
            this.tbG.ReadOnly = true;
            this.tbG.Size = new System.Drawing.Size(100, 30);
            this.tbG.TabIndex = 36;
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(418, 169);
            this.tbN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbN.Name = "tbN";
            this.tbN.ReadOnly = true;
            this.tbN.Size = new System.Drawing.Size(100, 30);
            this.tbN.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(372, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(372, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "n";
            // 
            // tbE
            // 
            this.tbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbE.Location = new System.Drawing.Point(418, 238);
            this.tbE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbE.Name = "tbE";
            this.tbE.ReadOnly = true;
            this.tbE.Size = new System.Drawing.Size(100, 30);
            this.tbE.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(372, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 29);
            this.label11.TabIndex = 50;
            this.label11.Text = "e";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "message";
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbX.Location = new System.Drawing.Point(133, 180);
            this.tbX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbX.Name = "tbX";
            this.tbX.ReadOnly = true;
            this.tbX.Size = new System.Drawing.Size(100, 30);
            this.tbX.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 47);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alice";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 284);
            this.panel1.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.default_user;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(87, 55);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(84, 74);
            this.panel5.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.key_icon_0;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(427, 87);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(68, 62);
            this.panel7.TabIndex = 49;
            // 
            // RSAControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lbCurrentTask);
            this.Controls.Add(this.lbAllQuestions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RSAControl";
            this.Size = new System.Drawing.Size(673, 459);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.Label lbAllQuestions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}
