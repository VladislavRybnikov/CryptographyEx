using CryptographyEx.Core.Base.Const;
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
            ChangeEncoder();
        }

        private void ChangeEncoder()
        {
            panel2.Controls.Clear();
            UserControl cntrl = null;
            var type = EncodingTypes.GetEncodingType(comboBox1.Text);

            switch (type)
            {
                case EncoderType.Caesar:
                    cntrl = new CaesarCalculatorControl();
                    break;
                case EncoderType.Trithemius:
                    cntrl = new TrithemiusCalculatorControl();
                    break;

            }

            var baseCntrl = new BaseCalculatorControl(cntrl, this, type);
            baseCntrl.panel1.Controls.Add(cntrl);

            panel2.Controls.Add(baseCntrl);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeEncoder();
        }
    }
}
