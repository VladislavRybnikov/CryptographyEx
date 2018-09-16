namespace CryptographyEx.WinFormsUI
{
    partial class MainForm
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
            this.encodersLabel = new System.Windows.Forms.Label();
            this.theoryLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.encodersPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.theoryPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // encodersLabel
            // 
            this.encodersLabel.AutoSize = true;
            this.encodersLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodersLabel.ForeColor = System.Drawing.Color.DimGray;
            this.encodersLabel.Location = new System.Drawing.Point(267, 129);
            this.encodersLabel.Name = "encodersLabel";
            this.encodersLabel.Size = new System.Drawing.Size(95, 29);
            this.encodersLabel.TabIndex = 1;
            this.encodersLabel.Text = "Шифры";
            this.encodersLabel.Click += new System.EventHandler(this.EncodersLabel_Click);
            // 
            // theoryLabel
            // 
            this.theoryLabel.AutoSize = true;
            this.theoryLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.theoryLabel.Location = new System.Drawing.Point(272, 179);
            this.theoryLabel.Name = "theoryLabel";
            this.theoryLabel.Size = new System.Drawing.Size(85, 29);
            this.theoryLabel.TabIndex = 2;
            this.theoryLabel.Text = "Теория";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabel.ForeColor = System.Drawing.Color.DimGray;
            this.aboutLabel.Location = new System.Drawing.Point(247, 236);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(143, 29);
            this.aboutLabel.TabIndex = 3;
            this.aboutLabel.Text = "О Программе";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.ForeColor = System.Drawing.Color.DimGray;
            this.exitLabel.Location = new System.Drawing.Point(278, 295);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(81, 29);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "Выход";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(179, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "CRYPTOGRAPHY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(465, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 55);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ex";
            // 
            // encodersPanel
            // 
            this.encodersPanel.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.key_icon_0;
            this.encodersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encodersPanel.Location = new System.Drawing.Point(217, 119);
            this.encodersPanel.Name = "encodersPanel";
            this.encodersPanel.Size = new System.Drawing.Size(42, 45);
            this.encodersPanel.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.Header_Encryption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(188, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 115);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources._2000px_KPI_wiki_logo_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 55);
            this.panel1.TabIndex = 5;
            // 
            // theoryPanel
            // 
            this.theoryPanel.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.key_icon_0;
            this.theoryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theoryPanel.Location = new System.Drawing.Point(224, 170);
            this.theoryPanel.Name = "theoryPanel";
            this.theoryPanel.Size = new System.Drawing.Size(42, 45);
            this.theoryPanel.TabIndex = 10;
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.key_icon_0;
            this.aboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutPanel.Location = new System.Drawing.Point(203, 226);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(42, 45);
            this.aboutPanel.TabIndex = 10;
            // 
            // exitPanel
            // 
            this.exitPanel.BackgroundImage = global::CryptographyEx.WinFormsUI.Properties.Resources.key_icon_0;
            this.exitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitPanel.Location = new System.Drawing.Point(235, 286);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(42, 45);
            this.exitPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(639, 456);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.theoryPanel);
            this.Controls.Add(this.encodersPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.theoryLabel);
            this.Controls.Add(this.encodersLabel);
            this.Name = "MainForm";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encodersLabel;
        private System.Windows.Forms.Label theoryLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel encodersPanel;
        private System.Windows.Forms.Panel theoryPanel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Panel exitPanel;
    }
}

