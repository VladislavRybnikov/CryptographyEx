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
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class DiffiHelmanControl : UserControl
    {
        //  private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private EncodersForm _encodersForm;
        private int _countQuestion;
        private int _countCorrectQuestion;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;
        //  private static Random _random = new Random();

        public DiffiHelmanControl(EncodersForm encodersForm)
        {
            InitializeComponent();
            _historyPresentation = new HistoryPresentation();
            _guid = Guid.NewGuid();
            _countQuestion = 0;
            _countCorrectQuestion = 0;
            //  _codingType = codingType;
            _mainPresentation = new MainPresentation();
            _encodersForm = encodersForm;

            Init();
        }
        private void Init()
        {

            lbAllQuestions.Text = EncodingCountConfiguration.GetCountByTest
                (EncoderType.DiffiHelman).ToString();
            btnCheck.Visible = true;
            btnNext.Visible = false;

            InitQuestion();
        }

        private void InitQuestion()
        {
            if (_countQuestion >= EncodingCountConfiguration.GetCountByTest
                (EncoderType.DiffiHelman))
            {
                _encodersForm.tabPage1.Controls.Remove(this);

                // _encodersForm.tabPage3.Controls.Add(new FinishControl(_encodersForm));
            }
            IDiffiHelmanQuestion diffiHelmanQuestion = (IDiffiHelmanQuestion
                )_mainPresentation.GenerateQuestion
                    (CodingType.Decoding, EncoderType.DiffiHelman);
            tbN.Text = diffiHelmanQuestion.N.ToString();
            tbG.Text = diffiHelmanQuestion.Q.ToString();
            tbX.Text = diffiHelmanQuestion.X.ToString();
            tbY.Text = diffiHelmanQuestion.Y.ToString();

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Tuple<AnswerType, string> answerType = _mainPresentation.CheckAnswer(new Question()
            {
                Answer = new AnswerValue()
                {
                    Answer = tbKey.Text
                },
                Description = new QuestionValue()
                {
                    Description = tbKey.Text
                },
                CodingType = CodingType.Decoding,
                EncodingType = EncoderType.DiffiHelman
            }, MonoAlphabet.ENG, PolyAlphabet.Default,
            Convert.ToInt32(tbN.Text), Convert.ToInt32(tbG.Text),
            new List<int>(){ Convert.ToInt32(tbX.Text),
                Convert.ToInt32(tbY.Text) });

            _countCorrectQuestion = AnswerType.Correct == answerType.Item1 ?
             _countCorrectQuestion + 1 : _countCorrectQuestion;
            lbCorrectAnswer.Text = _countCorrectQuestion.ToString();
            tbKey.Text = answerType.Item2;

            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = CodingType.Decoding,
                CorrectAnswer = answerType.Item2,
                Answer = tbKey.Text,
                Name = StringConstants.EncodingTypes.GetName(EncoderType.DiffiHelman),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
            });

            btnCheck.Visible = false;
            btnNext.Visible = true;
        }
    }
}
