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

namespace CryptographyEx.WinFormsUI
{
    public partial class EncodersCalculatorForm : Form
    {
        public EncodersCalculatorForm()
        {
            InitializeComponent();

            FormClosing += SwitсhToMain;
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
    }
}
