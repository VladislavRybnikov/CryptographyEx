using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Util;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class TrithemiusControl : UserControl
    {
        private IMainPresentation _mainPresentation;
        private int _questionCount;
        private int _correctQuestionCount;
        private bool _check = true;

        private IHistoryPresentation _historyPresentation;
        public TrithemiusControl(CodingType codingType, DecodeEncodeControl decodeEncodeControl)
        {
            InitializeComponent();
            lbCorrectAnsw.Visible = false;
            label9.Visible = false;
            button1.Visible = false;
            NextTest(false);
        }

        private IAlphabetEncoder _enc;
        private string _mes;
        private int _count;

        public void NextTest(bool increment)
        {
            if (_count == 5)
            {
                this.Controls.Clear();
                Controls.Add(new FinishControl(0, 5));
            }

            var function = RandomGenerator.NextTrithemiusFunction();
            var key = RandomGenerator.NextKey();
            var message = RandomGenerator.NextENGMessage();

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncoderType.Trithemius)
                .SetMonoAlphabet(Alphabet.GetMono(MonoAlphabet.ENG))
                .Configure(key, (Func<int, int>)function);

            _enc = trithemius;
            _mes = message;

            label7.Text = function.ToString();
            label8.Text = key.ToString();
            lbDescription.Text = message;

            if (increment)
                _count++;

            lbCurrentTask.Text = _count.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lbCorrectAnsw.Visible = true;
            label9.Visible = true;
            label9.Text = _enc.Encode(_mes);
            btnCheck.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCorrectAnsw.Visible = false;
            label9.Visible = false;
            NextTest(true);

            btnCheck.Visible = true;
            button1.Visible = false;
        }
    }
}
