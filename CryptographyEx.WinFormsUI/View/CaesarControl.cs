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
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Presentation;
using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class CaesarControl : UserControl
    {
        private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private DecodeEncodeControl _encodersForm;
        private int _countQuestion;
        private int _countCorrectQuestion;

        public CaesarControl(CodingType codingType, DecodeEncodeControl encodersForm)
        {
            InitializeComponent();
            _countQuestion = 0;
            _countCorrectQuestion = 0;
            _codingType = codingType;
            _mainPresentation = new MainPresentation();
            _encodersForm = encodersForm;
            Init();
        }

        private void Init()
        {
            
            lbAllQuestions.Text = EncodingNameHolder.GetCountByTest
                (EncodingType.Caesar).ToString();
            btnCheck.Visible = true;
            button1.Visible = false;

            InitQuestion();
        }

        private void InitQuestion()
        {
            if(_countQuestion >= EncodingNameHolder.GetCountByTest
                (EncodingType.Caesar))
            {
                _encodersForm.panelQuestion.Controls.Remove(this);

                _encodersForm.panelQuestion.Controls.Add(new FinishControl(_encodersForm));
            }

            lbDescription.Text = _mainPresentation.GenerateQuestion
                (_codingType,EncodingType.Caesar).Description;

            tbAnswer.Text = string.Empty;
            _countQuestion++;
            lbCurrentTask.Text = _countQuestion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnCheck.Visible = true;
            button1.Visible = false;
          
            InitQuestion();
        }

        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int valueConfig = (int)numericUpDownStep.Value;

            Tuple<AnswerType, string> answerType = _mainPresentation.CheckAnswer(new Question()
            {
                Description = new QuestionValue()
                {
                    Description = lbDescription.Text
                },
                Answer = new AnswerValue()
                {
                    Answer = tbAnswer.Text
                },
                CodingType = _codingType,
                EncodingType = EncodingType.Caesar
            }, valueConfig);
         

            _countCorrectQuestion = AnswerType.Correct == answerType.Item1 ?
                _countCorrectQuestion + 1 : _countCorrectQuestion;
            lbCorrectAnswer.Text = _countCorrectQuestion.ToString();
            lbCorrectAnsw.Text = answerType.Item2;

            btnCheck.Visible = false;
            button1.Visible = true;
        }
    }
}
