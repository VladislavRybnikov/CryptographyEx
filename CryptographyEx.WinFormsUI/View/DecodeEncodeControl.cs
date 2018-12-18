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
using CryptographyEx.Core.Holder;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class DecodeEncodeControl : UserControl
    {
        private EncodersForm _encodersForm;

        public DecodeEncodeControl(EncodersForm encodersForm)
        {
            InitializeComponent();
            _encodersForm = encodersForm;
            nameLabel.Text = _encodersForm.lbNameEncoder.Text;
        }

        private void btnEncoding_Click(object sender, EventArgs e)
        {
            HelpbtnClickByTest(CodingType.Encoding);
            btnEncoding.BackColor = Color.Gray;
            btnDecoding.BackColor = Color.LightGray;
        }

        private void btnDecoding_Click(object sender, EventArgs e)
        {
            HelpbtnClickByTest(CodingType.Decoding);
            btnEncoding.BackColor = Color.LightGray;
            btnDecoding.BackColor = Color.Gray;
        }

        private void HelpbtnClickByTest(CodingType codingType)
        {
            panelQuestion.Controls.Clear();

            switch (EncodingNameHolder.GetEncodingType
                           ((string)_encodersForm.comboBoxEncoding.SelectedItem))
            {

                case EncoderType.Caesar:
                    panelQuestion.Controls.Add(new CaesarControl(codingType, this));
                    break;
                case EncoderType.Vigenere:
                    panelQuestion.Controls.Add(new VigenereControl(codingType, this));
                    break;
                case EncoderType.Elgamal:
                    panelQuestion.Controls.Add(new ElgamalControl(codingType, this));
                    break;
            }
        }
    }
}
