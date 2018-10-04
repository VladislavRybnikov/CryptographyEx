using CryptographyEx.Core;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Holder;
using CryptographyEx.WinFormsUI.Holders;
using CryptographyEx.WinFormsUI.View;
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
            Init();

        }

        private void Init()
        {
            comboBoxEncoding.Items.AddRange(EncodingNameHolder.GetNames().ToArray());
            comboBoxEncoding.SelectedItem = comboBoxEncoding.Items[0];
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

            encodersLabel.Location = new Point(
                (splitContainer1.Panel1.Width / 2) - encodersLabel.Width / 2,
                encodersLabel.Location.Y);
        }

        private void comboBoxEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem))
            {

                case EncodingType.Caesar:
                    tabPage3.Controls.Add(new DecodeEncodeControl(this));
                    break;
                case EncodingType.Vigenere:
                    tabPage3.Controls.Add(new DecodeEncodeControl(this));
                    break;
            }
        }
    }
}
