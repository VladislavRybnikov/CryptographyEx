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
using CryptographyEx.WinFormsUI.Const;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class CaesarControl : UserControl
    {
        private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private DecodeEncodeControl _encodersForm;
        private int _questionCount;
        private int _correctQuestionCount;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;

        public CaesarControl(CodingType codingType, DecodeEncodeControl encodersForm)
        {
            InitializeComponent();
            _guid = Guid.NewGuid();
            _historyPresentation = new HistoryPresentation();
            _questionCount = 0;
            _correctQuestionCount = 0;
            _codingType = codingType;
            _mainPresentation = new MainPresentation();
            _encodersForm = encodersForm;
            Init();
        }

        private void Init()
        {
            lbAllQuestions.Text = EncodingCountConfiguration.GetCountByTest
                (EncoderType.Caesar).ToString();
            btnCheck.Visible = true;
            button1.Visible = false;

            switch (_codingType)
            {
                case CodingType.Encoding:
                    upLabel.Text = Messages.InMessage;
                    downLabel.Text = Messages.OutMessage;
                    break;
                case CodingType.Decoding:
                    upLabel.Text = Messages.OutMessage;
                    downLabel.Text = Messages.InMessage;
                    break;
            }

            InitQuestion();
        }

        private void ClearAnswerInfo()
        {
            lblAnswerInfo.Text = "";
            lbCorrectAnsw.Text = "";
        }

        private void InitQuestion()
        {
            ClearAnswerInfo();

            if(_questionCount >= EncodingCountConfiguration.GetCountByTest
                (EncoderType.Caesar))
            {
                _encodersForm.panelQuestion.Controls.Remove(this);

                _encodersForm.panelQuestion.Controls
                    .Add(new FinishControl(_correctQuestionCount, _questionCount));
            }

            lbDescription.Text = _mainPresentation.GenerateQuestion
                (_codingType,EncoderType.Caesar).Description;

            tbAnswer.Text = string.Empty;
            _questionCount++;
            lbCurrentTask.Text = _questionCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAnswerInfo();
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
                EncodingType = EncoderType.Caesar
            },
            MonoAlphabet.ENG,
            PolyAlphabet.Default,
            valueConfig);


            if (answerType.Item1 == AnswerType.Correct)
            {
                _correctQuestionCount++;
                lblAnswerInfo.ForeColor = Color.Green;
                lblAnswerInfo.Text = Messages.Right;
            }
            else
            {
                lblAnswerInfo.ForeColor = Color.Red;
                lblAnswerInfo.Text = Messages.Wrong;
                lbCorrectAnsw.Text = $"{Messages.Answer} {answerType.Item2}";
            }

            //lbCorrectAnswer.Text = _countCorrectQuestion.ToString();
            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = _codingType,
                CorrectAnswer = answerType.Item2,
                Answer = tbAnswer.Text,
                Name = StringConstants.EncodingTypes.GetName(EncoderType.Caesar),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
                Question = lbDescription.Text
            });

            btnCheck.Visible = false;
            button1.Visible = true;
        }

        private void CaesarControl_Load(object sender, EventArgs e)
        {

        }
    }
}
