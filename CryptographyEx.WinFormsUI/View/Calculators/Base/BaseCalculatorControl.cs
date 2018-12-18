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

namespace CryptographyEx.WinFormsUI.View.Calculators.Base
{
    public partial class BaseCalculatorControl : UserControl
    {
        private UserControl _control;
        private readonly EncodersCalculatorForm _parrent;
        EncoderType _encoder;

        public BaseCalculatorControl(UserControl cntrl, EncodersCalculatorForm parrent, EncoderType encoder)
        {
            InitializeComponent();
            _control = cntrl;
            _parrent = parrent;
            _encoder = encoder;
            label1.Text = StringConstants.EncodingTypes.GetName(_encoder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEncoderCalculator calc = null;
            string input = "";

            switch (_encoder)
            {
                case EncoderType.Caesar:
                    calc = new CaesarCalculator();
                    var caesarCntrl = _control as CaesarCalculatorControl;

                    (calc as CaesarCalculator).SetCodingType(caesarCntrl.CodingType)
                        .SetKey(caesarCntrl.Key).SetAlphabet(caesarCntrl.MonoAlphabet);

                    input = caesarCntrl.Input;
                    break;

                case EncoderType.Trithemius:
                    calc = new TrithemiusCalculator();
                    var tritemiusCntrl = _control as TrithemiusCalculatorControl;

                    (calc as TrithemiusCalculator).SetCodingType(tritemiusCntrl.CodingType)
                        .SetKey(tritemiusCntrl.Key)
                        .SetMappingFunction(tritemiusCntrl.MappingFunctionAsString)
                        .SetAlphabet(tritemiusCntrl.MonoAlphabet);

                    input = tritemiusCntrl.Input;
                    break;
            }
            
            try
            {
                var res = calc.Calculate(input);
                res.CalculationsPipeline.ForEach(x => _parrent.listBox1.Items.Add(x));
                _parrent.AnswerLbl.Text = res.Output;
            }
            catch (Exception ex)
            {
                _parrent.listBox1.Items.Add("[ERROR] - Не вірно вибраний алфавіт.");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
