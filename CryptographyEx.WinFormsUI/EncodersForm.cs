using CryptographyEx.Core;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Presentation;
using CryptographyEx.WinFormsUI.Holders;
using CryptographyEx.WinFormsUI.View;
using CryptographyEx.WinFormsUI.View.ViewHistory;
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
        private readonly IHistoryPresentation _historyPresentation;
        public EncodersForm()
        {
            InitializeComponent();
            FormClosing += SwithToMain;

            splitContainer1.SplitterMoved += ChangeSize;
            Resize += ChangeSize;
            _historyPresentation = new HistoryPresentation();
            _historyPresentation.Deserialize();
            Init();

        }

        private void Init()
        {
            comboBoxEncoding.Items.AddRange(EncodingNameHolder.GetNames().ToArray());
            comboBoxEncoding.SelectedItem = comboBoxEncoding.Items[0];
        }

        private void EncodersForm_Load(object sender, EventArgs e)
        {
            int number = 1;

            foreach (var entity in _historyPresentation.GetAllHistory())
            {
                ListViewItem listViewItem = new ListViewItem(entity.Item1);
                listViewItem.SubItems.Add(entity.Item2.ToString());

                if (number % 2 == 1)
                {
                    listViewItem.BackColor = Color.LightBlue;
                }
                else
                {
                    listViewItem.BackColor = Color.WhiteSmoke;
                }

                lvHistory.Items.Add(listViewItem);
                number++;
            }
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
            lbNameEncoder.Text = $"Шифр : {(string)comboBoxEncoding.SelectedItem}";

            switch (EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem))
            {

                case EncodingType.Caesar:
                    tabPage3.Controls.Clear();
                    tabPage3.Controls.Add(new DecodeEncodeControl(this));
                    break;
                case EncodingType.Vigenere:
                    tabPage3.Controls.Clear();
                    tabPage3.Controls.Add(new DecodeEncodeControl(this));
                    break;
                case EncodingType.DiffiHelman:
                    tabPage3.Controls.Clear();
                    tabPage3.Controls.Add(new DiffiHelmanControl(this));
                    break;
            }
        }

        private void lvHistory_Click(object sender, EventArgs e)
        {
            
            }

        private void lvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHistory.SelectedItems.Count > 0)
            {
                ListViewItem item = lvHistory.SelectedItems[0];
                string name = item.SubItems[0].Text;
                tPHistory.Controls.Clear();
                   tPHistory.Controls.Add(new HistoryCoddingControl(name, _historyPresentation,this));
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            tPHistory.Controls.Clear();
            tPHistory.Controls.Add(lvHistory);

            int number = 1;
                lvHistory.Items.Clear();
                foreach (var entity in _historyPresentation.GetAllHistory())
                {
                    ListViewItem listViewItem = new ListViewItem(entity.Item1);
                    listViewItem.SubItems.Add(entity.Item2.ToString());

                    if (number % 2 == 1)
                    {
                        listViewItem.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        listViewItem.BackColor = Color.WhiteSmoke;
                    }

                    lvHistory.Items.Add(listViewItem);
                    number++;
                }
        }
    }
    }

