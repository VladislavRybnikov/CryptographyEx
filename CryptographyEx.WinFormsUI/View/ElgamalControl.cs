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
using CryptographyEx.Core.Entities;
using CryptographyEx.Core.Base.Abstract.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class ElgamalControl : UserControl
    {
        private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private DecodeEncodeControl _encodersForm;
        private int _countQuestion;
        private int _countCorrectQuestion;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;

        public ElgamalControl(CodingType codingType, DecodeEncodeControl encodersForm)
        {
            InitializeComponent();
            _historyPresentation = new HistoryPresentation();
            _guid = Guid.NewGuid();
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
                (EncodingType.Elgamal).ToString();
            btnCheck.Visible = true;
            button1.Visible = false;

            InitQuestion();
        }

        private void InitQuestion()
        {
            if (_countQuestion >= EncodingNameHolder.GetCountByTest
                (EncodingType.Elgamal))
            {
                _encodersForm.panelQuestion.Controls.Remove(this);

                _encodersForm.panelQuestion.Controls.Add(new FinishControl(_encodersForm,null));
            }

            IElgamalQuestion elgamalQuestion =(IElgamalQuestion)_mainPresentation
                .GenerateQuestion
                (_codingType, EncodingType.Elgamal);

            tbA.Text = elgamalQuestion.A.ToString();
            tbP.Text = elgamalQuestion.P.ToString();
            tbB.Text = elgamalQuestion.B.ToString();
            tbR.Text = elgamalQuestion.R.ToString();

            switch(_codingType)
            {
                case CodingType.Decoding:
                    tbMessage.Text = elgamalQuestion.Description;
                   // tbMessage.ReadOnly = true;
                    tbO.Text=String.Empty;
                    tbW.Text = String.Empty;
                    break;
                case CodingType.Encoding:
                    string descript = elgamalQuestion.Description;
                    var values = descript.Split(',');
                    tbO.Text = values[0];
                    tbW.Text = values[1];
                 //   tbO.ReadOnly = true;
                 //   tbW.ReadOnly = true;
                    tbMessage.Text = String.Empty;
                    break;
            }

         
            _countQuestion++;
            lbCurrentTask.Text = _countQuestion.ToString();
        }
        private void ElgamalControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string answer = String.Empty;
            string descript = String.Empty;

            switch (_codingType)
            {
                case CodingType.Decoding:
                    answer = $"{ tbO.Text},{ tbW.Text}";
                    descript = tbMessage.Text;
                    break;
                case CodingType.Encoding:
                    answer = tbMessage.Text;
                    descript = $"{ tbO.Text},{ tbW.Text}";
                    break;
            }

            Tuple<AnswerType, string> answerType = _mainPresentation.CheckAnswer(new Question()
            {
                Description = new QuestionValue()
                {
                    Description = descript
                },
                Answer = new AnswerValue()
                {
                    Answer = answer
                },
                CodingType = _codingType,
                EncodingType = EncodingType.Elgamal
            },MonoAlphabet.ENG, PolyAlphabet.Default,
            Convert.ToInt32(tbP.Text), Convert.ToInt32(tbA.Text),
            Convert.ToInt32(tbB.Text),
                Convert.ToInt32(tbR.Text));

            _countCorrectQuestion = AnswerType.Correct == answerType.Item1 ?
             _countCorrectQuestion + 1 : _countCorrectQuestion;
            lbCorrectAnswer.Text = _countCorrectQuestion.ToString();

            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = _codingType,
                CorrectAnswer = answerType.Item2,
                Answer = answer,
                Name = EncodingNameHolder.GetNameByType(EncodingType.Elgamal),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
                Question = descript
            });

            btnCheck.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCheck.Visible = true;
            button1.Visible = false;

            InitQuestion();
        }
    }
}
