using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Presentation;
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
    public partial class MainForm : Form
    {
        private List<KeyValuePair<Label, Panel>> _manuButtons;
        private readonly IHistoryPresentation _historyPresentation;

        public MainForm()
        {
            InitializeComponent();
            FormHolder.MainForm = this;
            _historyPresentation = new HistoryPresentation();
            _historyPresentation.Deserialize();
            _manuButtons = new Dictionary<Label, Panel>
            {
                { encodersLabel, encodersPanel },
                { theoryLabel, theoryPanel },
                { aboutLabel, aboutPanel },
                { exitLabel, exitPanel }
            }.ToList();

            _manuButtons.ForEach(x => 
            {
                x.Value.Hide();

                x.Key.MouseEnter += (s, e) => LabelMouseEnter(x);

                x.Key.MouseLeave += (s, e) => LabelMouseLeave(x);

            });
        }

        private void EncodersLabel_Click(object sender, EventArgs e)
        {
            Hide();
            FormHolder.EncodersForm.Show();
        }

        private void LabelMouseEnter(KeyValuePair<Label, Panel> btn)
        {
            _manuButtons.ForEach(x => x.Value.Hide());
            btn.Value.Show();
            btn.Key.ForeColor = Color.DarkGreen;
        }

        private void LabelMouseLeave(KeyValuePair<Label, Panel> btn)
        {
            btn.Key.ForeColor = Color.DimGray;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
