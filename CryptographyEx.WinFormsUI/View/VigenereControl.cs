﻿using System;
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
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Entities;
using CryptographyEx.Core.Presentation;
using System.Diagnostics;
using CryptographyEx.Core.Util;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class VigenereControl : UserControl
    {
        private CodingType _codingType;
        private IMainPresentation _mainPresentation;
        private DecodeEncodeControl _encodersForm;
        private int _countQuestion;
        private int _countCorrectQuestion;
        private IHistoryPresentation _historyPresentation;
        private Guid _guid;

        public VigenereControl
            (CodingType codingType, DecodeEncodeControl encodersForm)
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
            lbAllQuestions.Text = EncodingCountConfiguration.GetCountByTest
                (EncoderType.Vigenere).ToString();
            btnCheck.Visible = true;
            btnNext.Visible = false;

            InitQuestion();
        }

        private void InitQuestion()
        {
            string valueConfig = RandomGenerator.NextENGMessage(3);
            lbKey.Text = valueConfig;

            if (_countQuestion >= EncodingCountConfiguration.GetCountByTest
                (EncoderType.Vigenere))
            {
                _encodersForm.panelQuestion.Controls.Remove(this);

                _encodersForm.panelQuestion.Controls
                    .Add(new FinishControl(_countCorrectQuestion, _countQuestion));
            }

            lbDescription.Text = _mainPresentation.GenerateQuestion
                (_codingType, EncoderType.Vigenere).Description;

            tbAnswer.Text = string.Empty;
            _countQuestion++;
            lbCurrentTask.Text = _countQuestion.ToString();
            lbCorrectAnsw.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCheck.Visible = true;
            btnNext.Visible = false;

            InitQuestion();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string valueConfig = lbKey.Text;

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
                EncodingType = EncoderType.Vigenere
            },
            MonoAlphabet.ENG,
            PolyAlphabet.VigenereTable,
            valueConfig);


            _countCorrectQuestion = AnswerType.Correct == answerType.Item1 ?
                _countCorrectQuestion + 1 : _countCorrectQuestion;
            lbCorrectAnswer.Text = _countCorrectQuestion.ToString();
            lbCorrectAnsw.Text = answerType.Item2;

            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = _codingType,
                CorrectAnswer = answerType.Item2,
                Answer = tbAnswer.Text,
                Name = StringConstants.EncodingTypes.GetName(EncoderType.Vigenere),
                GuidId = _guid,
                Mark = AnswerType.Correct == answerType.Item1 ? 1 : 0,
                Question = lbDescription.Text
            });

            btnCheck.Visible = false;
            btnNext.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var info = new ProcessStartInfo(linkLabel1.Text);
            Process.Start(info);
        }
    }
}
