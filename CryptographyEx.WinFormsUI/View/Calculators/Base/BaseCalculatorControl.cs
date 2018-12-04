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

namespace CryptographyEx.WinFormsUI.View.Calculators.Base
{
    public partial class BaseCalculatorControl : UserControl
    {
        private UserControl _control;
        private readonly EncodersCalculatorForm _parrent;

        public BaseCalculatorControl(UserControl cntrl, EncodersCalculatorForm parrent)
        {
            InitializeComponent();
            _control = cntrl;
            _parrent = parrent;
            label1.Text = "Шифр Цезаря";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new CaesarCalculator();
            var caesarCntrl = _control as CaesarCalculatorControl;
            calc.SetKey(caesarCntrl.Key);

            var res = calc.Calculate(caesarCntrl.Input);
            res.CalculationsPipeline.ForEach(x => _parrent.listBox1.Items.Add(x));
            _parrent.AnswerLbl.Text = res.Encoded;
        }
    }
}
