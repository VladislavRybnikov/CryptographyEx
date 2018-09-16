using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyEx.WinFormsUI.Holders
{
    public static class FormHolder
    {
        private static Form _mainForm;
        private static Form _encodersForm;

        public static Form MainForm
        {
            get
            {
                if (_mainForm == null)
                {
                    _mainForm = new MainForm();
                }

                return _mainForm;
            }

            set { _mainForm = value; }
        }

        public static Form EncodersForm
        {
            get
            {
                if (_encodersForm == null)
                {
                    _encodersForm = new EncodersForm();
                }

                return _encodersForm;
            }
            set { _encodersForm = value; }
        }
    }
}
