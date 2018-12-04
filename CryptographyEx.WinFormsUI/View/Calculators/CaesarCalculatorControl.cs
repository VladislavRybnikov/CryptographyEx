using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Calculators;
using CryptographyEx.Core.Base.Const;

namespace CryptographyEx.WinFormsUI.View.Calculators
{
    public partial class CaesarCalculatorControl : UserControl
    {
        private readonly IEncoderCalculator _calc;

        public MonoAlphabet MonoAlphabet { get; set; }
        public int Key { get; set; } = 5;
        public string Input { get; set; }

        public CaesarCalculatorControl()
        {
            InitializeComponent();
        }

        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {
            Key = (int)numericUpDownStep.Value;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            Input = inputTextBox.Text;
        }

        private void CaesarCalculatorControl_Load(object sender, EventArgs e)
        {
            MonoAlphabet = MonoAlphabet.ENG;
            comboBox1.Items.AddRange(new string[] {"ENG", "RU", "UTF16"});
            comboBox1.SelectedIndex = 0;
        }
    }
}
