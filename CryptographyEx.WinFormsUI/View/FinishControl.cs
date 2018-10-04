using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class FinishControl : UserControl
    {
        private DecodeEncodeControl _encodersForm;

        public FinishControl(DecodeEncodeControl encodersForm)
        {
            _encodersForm = encodersForm;

            InitializeComponent();
        }
    }
}
