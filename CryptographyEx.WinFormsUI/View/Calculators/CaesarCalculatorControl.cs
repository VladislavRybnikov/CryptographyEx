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

using static CryptographyEx.Core.Base.Const.StringConstants;
namespace CryptographyEx.WinFormsUI.View.Calculators
{
    public partial class CaesarCalculatorControl : UserControl
    {
        public MonoAlphabet MonoAlphabet { get; set; }
        public int Key { get; set; } = 5;
        public CodingType CodingType { get; set; }
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
            MonoAlphabet = MonoAlphabets.Default().Alphabet;

            comboBox1.Items.AddRange(MonoAlphabets.GetAllNames());
            CalculationsTypeCmbBx.Items.AddRange(CodingTypes.GetAllNames());
            comboBox1.SelectedIndex = 0;
            CalculationsTypeCmbBx.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonoAlphabet = MonoAlphabets.GetMonoAlphabet(comboBox1.Text);
        }

        private void CalculationsTypeCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodingType = CodingTypes.GetCodingType(CalculationsTypeCmbBx.Text);
        }
    }
}
