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

namespace CryptographyEx.WinFormsUI.View
{
    public partial class TrithemiusControl : UserControl
    {
        public TrithemiusControl(CodingType codingType, DecodeEncodeControl decodeEncodeControl)
        {
            InitializeComponent();
        }
    }
}
