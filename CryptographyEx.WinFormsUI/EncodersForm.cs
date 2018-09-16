using CryptographyEx.WinFormsUI.Holders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyEx.WinFormsUI
{
    public partial class EncodersForm : Form
    {
        public EncodersForm()
        {
            InitializeComponent();
            FormClosing += SwithToMain;

            splitContainer1.SplitterMoved += ChangeSize;
            Resize += ChangeSize;
        }
        
        private void EncodersForm_Load(object sender, EventArgs e)
        {

        }

        private void SwithToMain(object sender, CancelEventArgs e)
        {
            FormHolder.EncodersForm = null;
            FormHolder.MainForm.Show();
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            tabControl1.Width = splitContainer1.Panel2.Width - 10;
            tabControl1.Height = splitContainer1.Panel2.Height - 10;

            listView1.Width = splitContainer1.Panel1.Width - 10;
            listView1.Height = splitContainer1.Panel1.Height - 120;

            encodersLabel.Location = new Point(
                (splitContainer1.Panel1.Width / 2) - encodersLabel.Width / 2,
                encodersLabel.Location.Y);
        }
    }
}
