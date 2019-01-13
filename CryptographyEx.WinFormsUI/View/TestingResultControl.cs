using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class TestingResultControl : UserControl
    {
        EncodersForm _parrent;

        public TestingResultControl(int correct, int count, EncodersForm form)
        {
            InitializeComponent();
            var mark = new Mark(correct, count);
            panel1.Controls.Add(new FinishControl(mark));
            _parrent = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parrent.GetAnotherTest();
        }
    }
}
