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

        private IHistoryPresentation _historyPresentation;
        public TrithemiusControl(CodingType codingType, DecodeEncodeControl decodeEncodeControl)
        {
            InitializeComponent();
        }

        public void NextTest()
        {
            var function = RandomGenerator.NextTrithemiusFunction();
            var key = RandomGenerator.NextKey();
            var message = RandomGenerator.NextENGMessage();

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncoderType.Trithemius)
                .SetMonoAlphabet(Alphabet.GetMono(MonoAlphabet.ENG))
                .Configure(key, (Func<int, int>)function);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
