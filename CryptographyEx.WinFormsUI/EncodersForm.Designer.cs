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
            this.panel10 = new System.Windows.Forms.Panel();
            this.yearLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.lbNameEncoder = new System.Windows.Forms.Label();
            this.encodersLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTheory = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbAllQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cLB = new System.Windows.Forms.CheckedListBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tPHistory = new System.Windows.Forms.TabPage();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.NameCodding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tPHistory.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.panel10);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.lbNameEncoder);
            this.splitContainer1.Panel1.Controls.Add(this.encodersLabel);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(884, 561);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightBlue;
            this.panel10.Controls.Add(this.yearLbl);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(64, 86);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(98, 32);
            this.panel10.TabIndex = 15;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLbl.ForeColor = System.Drawing.Color.DimGray;
            this.yearLbl.Location = new System.Drawing.Point(55, 7);
            this.yearLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(41, 20);
            this.yearLbl.TabIndex = 12;
            this.yearLbl.Text = "2018";
            this.yearLbl.Click += new System.EventHandler(this.yearLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "KPI -";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.comboBoxEncoding);
            this.panel4.Location = new System.Drawing.Point(39, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 32);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Location = new System.Drawing.Point(7, 5);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(122, 21);
            this.comboBoxEncoding.TabIndex = 8;
            this.comboBoxEncoding.SelectedIndexChanged += new System.EventHandler(this.comboBoxEncoding_SelectedIndexChanged);
            // 
            // lbNameEncoder
            // 
            this.lbNameEncoder.AutoSize = true;
            this.lbNameEncoder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameEncoder.ForeColor = System.Drawing.Color.DimGray;
            this.lbNameEncoder.Location = new System.Drawing.Point(47, 339);
            this.lbNameEncoder.Name = "lbNameEncoder";
            this.lbNameEncoder.Size = new System.Drawing.Size(135, 20);
            this.lbNameEncoder.TabIndex = 10;
            this.lbNameEncoder.Text = "Шифр: Не вибрано";
            // 
            // encodersLabel
            // 
            this.encodersLabel.AutoSize = true;
            this.encodersLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodersLabel.ForeColor = System.Drawing.Color.DimGray;
            this.encodersLabel.Location = new System.Drawing.Point(35, 189);
            this.encodersLabel.Name = "encodersLabel";
            this.encodersLabel.Size = new System.Drawing.Size(158, 29);
            this.encodersLabel.TabIndex = 7;
            this.encodersLabel.Text = "Оберіть шифр";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tPHistory);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 21);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 517);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.tbTheory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Теорія";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(14, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(580, 30);
            this.panel9.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(260, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Теорія";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbTheory
            // 
            this.tbTheory.AcceptsReturn = true;
            this.tbTheory.AcceptsTab = true;
            this.tbTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTheory.Location = new System.Drawing.Point(14, 44);
            this.tbTheory.Margin = new System.Windows.Forms.Padding(2);
            this.tbTheory.Multiline = true;
            this.tbTheory.Name = "tbTheory";
            this.tbTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTheory.Size = new System.Drawing.Size(580, 436);
            this.tbTheory.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(606, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тест";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 482);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.CadetBlue;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(14, 79);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(343, 35);
            this.panel8.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Виберіть правильну відповідь";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(16, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(571, 34);
            this.panel5.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(259, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Тест";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.lbCurrentTask);
            this.panel11.Location = new System.Drawing.Point(450, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(118, 26);
            this.panel11.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Запитання:";
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCurrentTask.Location = new System.Drawing.Point(99, 4);
            this.lbCurrentTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(18, 20);
            this.lbCurrentTask.TabIndex = 35;
            this.lbCurrentTask.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.lbAllQuestions);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lbCorrectAnswer);
            this.panel6.Location = new System.Drawing.Point(43, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(65, 30);
            this.panel6.TabIndex = 41;
            // 
            // lbAllQuestions
            // 
            this.lbAllQuestions.AutoSize = true;
            this.lbAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAllQuestions.Location = new System.Drawing.Point(40, 4);
            this.lbAllQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllQuestions.Name = "lbAllQuestions";
            this.lbAllQuestions.Size = new System.Drawing.Size(20, 24);
            this.lbAllQuestions.TabIndex = 34;
            this.lbAllQuestions.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "/";
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrectAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCorrectAnswer.Location = new System.Drawing.Point(8, 4);
            this.lbCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(20, 24);
            this.lbCorrectAnswer.TabIndex = 32;
            this.lbCorrectAnswer.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(264, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cLB
            // 
            this.cLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLB.FormattingEnabled = true;
            this.cLB.Location = new System.Drawing.Point(14, 114);
            this.cLB.Margin = new System.Windows.Forms.Padding(2);
            this.cLB.Name = "cLB";
            this.cLB.Size = new System.Drawing.Size(536, 157);
            this.cLB.Sorted = true;
            this.cLB.TabIndex = 38;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescription.Location = new System.Drawing.Point(59, 17);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(57, 24);
            this.lbDescription.TabIndex = 36;
            this.lbDescription.Text = "descr";
            // 
            // tPHistory
            // 
            this.tPHistory.Controls.Add(this.lvHistory);
            this.tPHistory.Location = new System.Drawing.Point(4, 25);
            this.tPHistory.Margin = new System.Windows.Forms.Padding(2);
            this.tPHistory.Name = "tPHistory";
            this.tPHistory.Size = new System.Drawing.Size(606, 488);
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
            this.lvHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(606, 488);
            this.lvHistory.TabIndex = 0;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.SelectedIndexChanged += new System.EventHandler(this.lvHistory_SelectedIndexChanged);
            this.lvHistory.Click += new System.EventHandler(this.lvHistory_Click);
            // 
            // NameCodding
            // 
            this.NameCodding.Text = "Назва алгоритма";
            this.NameCodding.Width = 200;
            // 
            // Mark
            // 
            this.Mark.Text = "Загальна оцінка";
            this.Mark.Width = 224;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.assessment_clipart_summative_assessment_2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(35, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 96);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources._2000px_KPI_wiki_logo_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(87, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 55);
            this.panel1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.Yes_Check_Circle_svg;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(1, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(36, 30);
            this.panel7.TabIndex = 41;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.cLB);
            this.panel12.Controls.Add(this.panel8);
            this.panel12.Controls.Add(this.button1);
            this.panel12.Controls.Add(this.lbDescription);
            this.panel12.Location = new System.Drawing.Point(16, 46);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(571, 345);
            this.panel12.TabIndex = 42;
            // 
            // EncodersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "EncodersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncodersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EncodersForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tPHistory.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
    }
}