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
    public partial class HistoryAnswerControl : UserControl
    {
        private string _name;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;
        public HistoryAnswerControl(string name,Guid guid, IHistoryPresentation historyPresentation)
        {
            InitializeComponent();

            _name = name;
            _guid = guid;
            _historyPresentation = historyPresentation;

            Init();
        }

        private void Init()
        {
            int number = 1;
            lvHistory.Items.Clear();
            foreach (var entity in _historyPresentation.GetHistoryDetailByAnswers(_name,_guid))
            {
                ListViewItem listViewItem = new ListViewItem(entity.Item1);
                listViewItem.SubItems.Add(entity.Item2.ToString());
                listViewItem.SubItems.Add(entity.Item3.CorrectAnswer.ToString());
                listViewItem.SubItems.Add(entity.Item3.Answer.ToString());
                listViewItem.SubItems.Add(entity.Item3.Mark.ToString());

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

        }
    }
}
