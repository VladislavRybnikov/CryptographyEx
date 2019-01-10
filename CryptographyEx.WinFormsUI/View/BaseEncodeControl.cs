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

namespace CryptographyEx.WinFormsUI.View
{
    public partial class BaseEncodeControl : UserControl
    {
        private EncodersForm _encodersForm;

        public BaseEncodeControl(EncodersForm encodersForm)
        {
            InitializeComponent();
            _encodersForm = encodersForm;
            nameLabel.Text = _encodersForm.lbNameEncoder.Text;

            LoadEncoding();
        }

        private void LoadEncoding()
        {
            panelQuestion.Controls.Clear();

            switch (EncodingNameHolder.GetEncodingType
                           ((string)_encodersForm.comboBoxEncoding.SelectedItem))
            {

                case EncoderType.DiffiHelman:
                    panelQuestion.Controls.Add(new DiffiHelmanControl(_encodersForm));
                    break;
                  
            }
        }
    }
}
