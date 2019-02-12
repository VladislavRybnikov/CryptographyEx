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
using CryptographyEx.Core.Presentation;
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using CryptographyEx.Core.Base.Abstract.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class RSAControl : UserControl
    {
          private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private DecodeEncodeControl _encodersForm;
        private int _countQuestion;
        private int _countCorrectQuestion;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;
        //  private static Random _random = new Random();

        public RSAControl(CodingType codingType, DecodeEncodeControl encodersForm)
        {
            InitializeComponent();
            _historyPresentation = new HistoryPresentation();
            _guid = Guid.NewGuid();
            _countQuestion = 0;
            _countCorrectQuestion = 0;
             _codingType = codingType;
            tbE.Text = "5";
            _mainPresentation = new MainPresentation();
            _encodersForm = encodersForm;

            Init();
        }
        private void Init()
        {

            lbAllQuestions.Text = EncodingCountConfiguration.GetCountByTest
                (EncoderType.RSA).ToString();
            btnCheck.Visible = true;
            btnNext.Visible = false;

            InitQuestion();
        }

        private void InitQuestion()
        {
            if (_countQuestion >= EncodingCountConfiguration.GetCountByTest
                (EncoderType.DiffiHelman))
            {
                _encodersForm.panelQuestion.Controls.Remove(this);

                _encodersForm.panelQuestion.Controls
                    .Add(new FinishControl(_countCorrectQuestion, _countQuestion));

                // _encodersForm.tabPage3.Controls.Add(new FinishControl(_encodersForm));
            }
            IDiffiHelmanQuestion diffiHelmanQuestion = (IDiffiHelmanQuestion
                )_mainPresentation.GenerateQuestion
                    (_codingType, EncoderType.RSA);
            tbN.Text = diffiHelmanQuestion.N.ToString();
            tbG.Text = diffiHelmanQuestion.Q.ToString();
            tbX.Text = diffiHelmanQuestion.X.ToString();

            tbKey.Text = string.Empty;
            _countQuestion++;
            lbCurrentTask.Text = _countQuestion.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            btnCheck.Visible = true;
            btnNext.Visible = false;

            InitQuestion();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {

            Tuple<AnswerType, string> answerType = _mainPresentation.CheckAnswer(new Question()
            {
                Answer = new AnswerValue()
                {
                    Answer = tbKey.Text
                },
                Description = new QuestionValue()
                {
                    Description = tbX.Text
                },
                CodingType = _codingType,
                EncodingType = EncoderType.RSA
            }, MonoAlphabet.ENG, PolyAlphabet.Default,
            Convert.ToInt32(tbN.Text), Convert.ToInt32(tbG.Text)
            );

            _countCorrectQuestion = AnswerType.Correct == answerType.Item1 ?
             _countCorrectQuestion + 1 : _countCorrectQuestion;
            lbCorrectAnswer.Text = _countCorrectQuestion.ToString();
           

            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = _codingType,
                CorrectAnswer = answerType.Item2,
                Answer = tbKey.Text,
                Name = StringConstants.EncodingTypes.GetName(EncoderType.RSA),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
            });
            tbKey.Text = answerType.Item2;
            btnCheck.Visible = false;
            btnNext.Visible = true;
        }
    }
}
