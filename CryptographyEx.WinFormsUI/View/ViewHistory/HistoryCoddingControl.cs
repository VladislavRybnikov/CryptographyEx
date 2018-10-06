using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Base.Abstract;

namespace CryptographyEx.WinFormsUI.View.ViewHistory
{
    public partial class HistoryCoddingControl : UserControl
    {
            private string _name;
            private IHistoryPresentation _historyPresentation;
        private EncodersForm _encodersForm;
            public HistoryCoddingControl(string name, IHistoryPresentation historyPresentation, EncodersForm encodersForm )
            {
                InitializeComponent();

                _name = name;
                _encodersForm = encodersForm;
                _historyPresentation = historyPresentation;

                Init();
            }

            private void Init()
            {
                int number = 1;
                lvHistory.Items.Clear();
                foreach (var entity in _historyPresentation.GetHistoryDetailByCoding(_name))
                {
                    ListViewItem listViewItem = new ListViewItem(entity.Item1);
                    listViewItem.SubItems.Add(entity.Item2.CodingType.ToString());
                    listViewItem.SubItems.Add(entity.Item2.Mark.ToString());
                    listViewItem.SubItems.Add(entity.Item2.GuidId.ToString());

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

        private void lvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHistory.SelectedItems.Count > 0)
            {
                ListViewItem item = lvHistory.SelectedItems[0];
                string name = item.SubItems[0].Text;

                Guid guid = Guid.Parse(item.SubItems[3].Text);
                _encodersForm.tPHistory.Controls.Clear();
                _encodersForm.tPHistory.Controls.Add(new HistoryAnswerControl(name, guid,_historyPresentation));
            }
        }
    }
}
