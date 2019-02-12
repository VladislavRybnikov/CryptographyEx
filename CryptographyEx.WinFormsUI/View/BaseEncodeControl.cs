using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Base.Const;

using static CryptographyEx.Core.Base.Const.StringConstants;
namespace CryptographyEx.WinFormsUI.View
{
    public partial class BaseEncodeControl : UserControl
    {
        private EncoderType _type;
        private EncodersForm _encodersForm;

        public BaseEncodeControl(EncodersForm encodersForm, EncoderType type)
        {
            InitializeComponent();
            _type = type;
            nameLabel.Text = EncodingTypes.GetName(type);
            _encodersForm = encodersForm;
            LoadEncoding();
        }

        private void LoadEncoding()
        {
            panelQuestion.Controls.Clear();

            switch (_type)
            {

                case EncoderType.DiffiHelman:
                    panelQuestion.Controls.Add(new DiffiHelmanControl(_encodersForm));
                    break;
                case EncoderType.SHA1:
                    panelQuestion.Controls.Add(new SHA1Control(_encodersForm));
                    break;
                case EncoderType.MD5:
                    panelQuestion.Controls.Add(new MD5Control(_encodersForm));
                    break;

            }
        }
    }
}
