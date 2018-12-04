namespace CryptographyEx.WinFormsUI
{
    partial class EncodersForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbNameEncoder = new System.Windows.Forms.Label();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.encodersLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cLB = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.tPHistory = new System.Windows.Forms.TabPage();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.NameCodding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.tbTheory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tPHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.yearLbl);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lbNameEncoder);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxEncoding);
            this.splitContainer1.Panel1.Controls.Add(this.encodersLabel);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 645);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbNameEncoder
            // 
            this.lbNameEncoder.AutoSize = true;
            this.lbNameEncoder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameEncoder.ForeColor = System.Drawing.Color.DimGray;
            this.lbNameEncoder.Location = new System.Drawing.Point(63, 607);
            this.lbNameEncoder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameEncoder.Name = "lbNameEncoder";
            this.lbNameEncoder.Size = new System.Drawing.Size(169, 25);
            this.lbNameEncoder.TabIndex = 10;
            this.lbNameEncoder.Text = "Шифр: Не вибрано";
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Location = new System.Drawing.Point(53, 290);
            this.comboBoxEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEncoding.TabIndex = 8;
            this.comboBoxEncoding.SelectedIndexChanged += new System.EventHandler(this.comboBoxEncoding_SelectedIndexChanged);
            // 
            // encodersLabel
            // 
            this.encodersLabel.AutoSize = true;
            this.encodersLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodersLabel.ForeColor = System.Drawing.Color.DimGray;
            this.encodersLabel.Location = new System.Drawing.Point(32, 233);
            this.encodersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encodersLabel.Name = "encodersLabel";
            this.encodersLabel.Size = new System.Drawing.Size(202, 37);
            this.encodersLabel.TabIndex = 7;
            this.encodersLabel.Text = "Оберіть шифр";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources._2000px_KPI_wiki_logo_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(116, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 68);
            this.panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tPHistory);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 21);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 636);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(811, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbTheory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(811, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Теорія";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(811, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тест";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cLB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbDescription);
            this.panel2.Controls.Add(this.lbCurrentTask);
            this.panel2.Controls.Add(this.lbAllQuestions);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbCorrectAnswer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 599);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(696, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cLB
            // 
            this.cLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLB.FormattingEnabled = true;
            this.cLB.Location = new System.Drawing.Point(3, 170);
            this.cLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cLB.Name = "cLB";
            this.cLB.Size = new System.Drawing.Size(799, 207);
            this.cLB.Sorted = true;
            this.cLB.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Виберіть правильну відповідь";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescription.Location = new System.Drawing.Point(75, 76);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(0, 29);
            this.lbDescription.TabIndex = 36;
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.Location = new System.Drawing.Point(468, 18);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(0, 24);
            this.lbCurrentTask.TabIndex = 35;
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.Location = new System.Drawing.Point(93, 18);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(26, 29);
            this.lbAllQuestions.TabIndex = 34;
            this.lbAllQuestions.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "/";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(51, 18);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(26, 29);
            this.lbCorrectAnswer.TabIndex = 32;
            this.lbCorrectAnswer.Text = "0";
            // 
            // tPHistory
            // 
            this.tPHistory.Controls.Add(this.lvHistory);
            this.tPHistory.Location = new System.Drawing.Point(4, 25);
            this.tPHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPHistory.Name = "tPHistory";
            this.tPHistory.Size = new System.Drawing.Size(811, 607);
            this.tPHistory.TabIndex = 3;
            this.tPHistory.Text = "Історя Тестів";
            this.tPHistory.UseVisualStyleBackColor = true;
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCodding,
            this.Mark});
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvHistory.GridLines = true;
            this.lvHistory.Location = new System.Drawing.Point(0, 0);
            this.lvHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(811, 607);
            this.lvHistory.TabIndex = 0;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.SelectedIndexChanged += new System.EventHandler(this.lvHistory_SelectedIndexChanged);
            this.lvHistory.Click += new System.EventHandler(this.lvHistory_Click);
            // 
            // NameCodding
            // 
            this.NameCodding.Text = "Назва алгоритма";
            // 
            // Mark
            // 
            this.Mark.Text = "Загальна оцінка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(70, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "KPI -";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLbl.ForeColor = System.Drawing.Color.DimGray;
            this.yearLbl.Location = new System.Drawing.Point(120, 87);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(41, 20);
            this.yearLbl.TabIndex = 12;
            this.yearLbl.Text = "2018";
            this.yearLbl.Click += new System.EventHandler(this.yearLbl_Click);
            // 
            // tbTheory
            // 
            this.tbTheory.AcceptsReturn = true;
            this.tbTheory.AcceptsTab = true;
            this.tbTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTheory.Location = new System.Drawing.Point(19, 25);
            this.tbTheory.Multiline = true;
            this.tbTheory.Name = "tbTheory";
            this.tbTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTheory.Size = new System.Drawing.Size(772, 575);
            this.tbTheory.TabIndex = 0;
            // 
            // EncodersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 645);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncodersForm";
            this.Text = "EncodersForm";
            this.Load += new System.EventHandler(this.EncodersForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tPHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label encodersLabel;
        public System.Windows.Forms.ComboBox comboBoxEncoding;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tPHistory;
        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader NameCodding;
        private System.Windows.Forms.ColumnHeader Mark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox cLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.Label lbAllQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCorrectAnswer;
        public System.Windows.Forms.Label lbNameEncoder;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTheory;
    }
}