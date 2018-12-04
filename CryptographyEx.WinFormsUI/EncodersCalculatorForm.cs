using CryptographyEx.WinFormsUI.Holders;
using CryptographyEx.WinFormsUI.View.Calculators;
using CryptographyEx.WinFormsUI.View.Calculators.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CryptographyEx.Core.Base.Const.StringConstants;
namespace CryptographyEx.WinFormsUI
{
    public partial class EncodersCalculatorForm : Form
    {
        public EncodersCalculatorForm()
        {
            InitializeComponent();

            FormClosing += SwitсhToMain;
            comboBox1.Items.AddRange(EncodingTypes.GetAllNames());
            comboBox1.SelectedIndex = 0;
        }

        private void SwitсhToMain(object sender, CancelEventArgs e)
        {
            FormHolder.CalculatorForm = null;
            FormHolder.MainForm.Show();
        }

        private void EncodersCalculatorForm_Load(object sender, EventArgs e)
        {
            var caesrCntrl = new CaesarCalculatorControl();
            var baseCntrl = new BaseCalculatorControl(caesrCntrl, this);
            baseCntrl.panel1.Controls.Add(caesrCntrl);

            panel2.Controls.Add(baseCntrl);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
