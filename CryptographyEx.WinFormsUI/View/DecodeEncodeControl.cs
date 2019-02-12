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

using static CryptographyEx.Core.Base.Const.StringConstants;
namespace CryptographyEx.WinFormsUI.View
{
    public partial class DecodeEncodeControl : UserControl
    {
        private EncodersForm _encodersForm;

        private readonly EncoderType _type;

        public DecodeEncodeControl(EncoderType type)
        {
            InitializeComponent();
            _type = type;
            nameLabel.Text = EncodingTypes.GetName(type);
            InitEnconding();
        }

        private void InitEnconding()
        {
            HelpbtnClickByTest(CodingType.Encoding);
            btnEncoding.BackColor = Color.Gray;
            btnDecoding.BackColor = Color.LightGray;
        }

        private void btnEncoding_Click(object sender, EventArgs e)
        {
            InitEnconding();
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

            switch (_type)
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
                case EncoderType.Trithemius:
                    panelQuestion.Controls.Add(new TrithemiusControl(codingType, this));
                    break;
                case EncoderType.Stierlitz:
                    panelQuestion.Controls.Add(new ShtirlitzControl());
                    break;
                case EncoderType.Des:
                    panelQuestion.Controls.Add(new DesControl());
                    break;
            }
        }
    }
}
