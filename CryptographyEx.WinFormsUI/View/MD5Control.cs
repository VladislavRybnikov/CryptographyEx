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
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Presentation;
using CryptographyEx.Core.Holder;
using CryptographyEx.WinFormsUI.Const;
using CryptographyEx.Core.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class MD5Control : UserControl
    {
        private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private EncodersForm _encodersForm;
        private int _questionCount;
        private int _correctQuestionCount;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;

        public MD5Control(EncodersForm encodersForm)
        {
            InitializeComponent();
            _guid = Guid.NewGuid();
            _historyPresentation = new HistoryPresentation();
            _questionCount = 0;
            _correctQuestionCount = 0;

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


            upLabel.Text = Messages.InMessage;
            downLabel.Text = Messages.OutMessage;


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

            if (_questionCount >= EncodingCountConfiguration.GetCountByTest
                (EncoderType.Caesar))
            {
                _encodersForm.tabPage1.Controls.Remove(this);
            }

            lbDescription.Text = _mainPresentation.GenerateQuestion
                (CodingType.Encoding, EncoderType.Caesar).Description;

            tbAnswer.Text = string.Empty;
            _questionCount++;
            lbCurrentTask.Text = _questionCount.ToString();
        }


        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {


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
                CodingType = CodingType.Encoding,
                EncodingType = EncoderType.MD5
            },
            MonoAlphabet.ENG,
            PolyAlphabet.Default
            );


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
                CodingType = CodingType.Encoding,
                CorrectAnswer = answerType.Item2,
                Answer = tbAnswer.Text,
                Name = StringConstants.EncodingTypes.GetName(EncoderType.MD5),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
                Question = lbDescription.Text
            });

            btnCheck.Visible = false;
            button1.Visible = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ClearAnswerInfo();
            btnCheck.Visible = true;
            button1.Visible = false;

            InitQuestion();
        }
    }
}
