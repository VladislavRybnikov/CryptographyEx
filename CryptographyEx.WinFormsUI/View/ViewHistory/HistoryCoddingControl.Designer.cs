namespace CryptographyEx.WinFormsUI.View.ViewHistory
{
    partial class HistoryCoddingControl
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
            this.lvHistory = new System.Windows.Forms.ListView();
            this.NameCodding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.csdfsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCodding,
            this.csdfsg,
            this.Mark,
            this.columnHeader1});
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvHistory.GridLines = true;
            this.lvHistory.Location = new System.Drawing.Point(0, 0);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(811, 607);
            this.lvHistory.TabIndex = 1;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.SelectedIndexChanged += new System.EventHandler(this.lvHistory_SelectedIndexChanged);
            // 
            // NameCodding
            // 
            this.NameCodding.Text = "Назва алгоритма";
            this.NameCodding.Width = 214;
            // 
            // csdfsg
            // 
            this.csdfsg.DisplayIndex = 2;
            this.csdfsg.Text = "Тип теста";
            this.csdfsg.Width = 262;
            // 
            // Mark
            // 
            this.Mark.DisplayIndex = 1;
            this.Mark.Text = "Оцінка";
            this.Mark.Width = 217;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код теста";
            this.columnHeader1.Width = 113;
            // 
            // HistoryCoddingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvHistory);
            this.Name = "HistoryCoddingControl";
            this.Size = new System.Drawing.Size(811, 607);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader NameCodding;
        private System.Windows.Forms.ColumnHeader csdfsg;
        private System.Windows.Forms.ColumnHeader Mark;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
