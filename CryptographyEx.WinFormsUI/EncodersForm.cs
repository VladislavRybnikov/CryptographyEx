﻿using CryptographyEx.Core;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using CryptographyEx.Core.Holder;
using CryptographyEx.Core.Presentation;
using CryptographyEx.WinFormsUI.Holders;
using CryptographyEx.WinFormsUI.View;
using CryptographyEx.WinFormsUI.View.ViewHistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CryptographyEx.WinFormsUI.Util.ControlResizer;
using static CryptographyEx.Core.Base.Const.StringConstants;
using CryptographyEx.WinFormsUI.Util;

namespace CryptographyEx.WinFormsUI
{
    public partial class EncodersForm : Form
    {
        private List<ControlWithResizes> _controlsWithResizes = new List<ControlWithResizes>();

        private Control _testingCach;

        private readonly IHistoryPresentation _historyPresentation;
        private QuestionByTesting _currentquestionByTesting;
        private int _currentTask;
        private Guid _guid;
        private int _testingCount;

        private Control _encodingControl;

        public EncodersForm()
        {
            InitializeComponent();
            _currentTask = 0;
            FormClosing += SwitсhToMain;
            splitContainer1.SplitterMoved += ChangeSize;
            Resize += ChangeSize;
            _historyPresentation = new HistoryPresentation();
            _historyPresentation.Deserialize();
            Init();
            var year = DateTime.Now.Year;
            yearLbl.Text = year.ToString();

            Load += ChangeSize;
            tabControl1.Click += ChangeSize;
            comboBoxEncoding.SelectedIndexChanged += ChangeSize;
        }

        public void GetAnotherTest()
        {
            EncoderType enc = EncodingTypes.GetEncodingType(comboBoxEncoding.SelectedItem.ToString());

           _currentquestionByTesting = QuestionByTestingHolder.GetQuestionByTestings(enc)
                .FirstOrDefault(p => p.AnswerType == AnswerType.Defoult);

            //if (_currentquestionByTesting == null)
            //{
            //    return;
            //}

            if (_testingCach != null)
            {
                tabPage3.Controls.Clear();
                tabPage3.Controls.Add(_testingCach);
            }
            if (_currentquestionByTesting == null) return;

            lbDescription.Text = _currentquestionByTesting.Description;

            _testingCount = QuestionByTestingHolder.GetQuestionByTestings(enc).Count;

            lbAllQuestions.Text = _testingCount.ToString();
            _currentTask = 0;
            lbCurrentTask.Text = _currentTask.ToString();
            cLB.Items.Clear();

            foreach (var s in _currentquestionByTesting.Questions)
            {
                cLB.Items.Add($"{s.Key}-{s.Value}");
            }
        }

        private void Init()
        {
            comboBoxEncoding.Items.AddRange(EncodingTypes.GetAllNames().ToArray());
            comboBoxEncoding.SelectedItem = comboBoxEncoding.Items[0];
        }

        private void EncodersForm_Load(object sender, EventArgs e)
        {
            int number = 1;

            foreach (var entity in _historyPresentation.GetAllHistory())
            {
                ListViewItem listViewItem = new ListViewItem(entity.Item1);
                listViewItem.SubItems.Add(entity.Item2.ToString());

                if (number % 2 == 1)
                {
                    listViewItem.BackColor = Color.LightBlue;
                }
                else
                {
                    listViewItem.BackColor = Color.WhiteSmoke;
                }

                lvHistory.Items.Add(listViewItem);
                number++;
            }
        }

        private void SwitсhToMain(object sender, CancelEventArgs e)
        {
            FormHolder.EncodersForm = null;
            FormHolder.MainForm.Show();
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            tabControl1.Width = splitContainer1.Panel2.Width - 10;
            tabControl1.Height = splitContainer1.Panel2.Height - 10;
            
            SetPanelControlLocation(splitContainer1.Panel1, encodersLabel);
            SetPanelControlLocation(splitContainer1.Panel1, panel4);
            SetPanelControlLocation(splitContainer1.Panel1, panel1);
            SetPanelControlLocation(splitContainer1.Panel1, panel10);

            SetPanelControlLocationWithY(splitContainer1.Panel1, panel3, splitContainer1.Panel1.Height - 150);
            SetPanelControlLocationWithY(splitContainer1.Panel1, lbNameEncoder, splitContainer1.Panel1.Height - 120 - panel3.Height);

            SetControlLocationWithXY(_encodingControl, (int)((splitContainer1.Panel2.Width - _encodingControl.Width)/ 2 * 0.9) - 8,Height / 45);
            
            SetPanelControlLocation(splitContainer1.Panel2, panel9);

            SetControlSize(tbTheory, splitContainer1.Panel2.Width - 50, Height - 150);
            SetControlLocationWithXY(tbTheory, splitContainer1.Panel2.Width / 2 - tbTheory.Width / 2 - 10, tbTheory.Location.Y);
            SetControlSize(panel9, tbTheory.Width, panel9.Height);
            SetControlLocationWithXY(panel9, tbTheory.Location.X, panel9.Location.Y);
            SetLocationCentred(panel9, label4);

            SetControlSize(panel5, splitContainer1.Panel2.Width - 50, panel5.Height);
            SetLocationCentred(panel5, label6);
            SetLocationRight(panel5, panel11);
            SetPanelControlLocationWithY(splitContainer1.Panel2, button1, (int)(panel2.Height * 0.8));

            SetControlSize(cLB, (int)(panel2.Width * 0.8), cLB.Height);
            SetControlLocationWithXY(cLB, cLB.Location.X, (int)(panel2.Height / 2 * 0.8));
            SetControlLocationWithXY(panel8, panel8.Location.X, cLB.Location.Y - panel8.Height);

            SetControlSize(panel12, panel5.Width, Height - 150);

            _controlsWithResizes?.ForEach(cntrl => cntrl.Resize());
        }

        private void SelectEncodingControl(Control cntrl)
        {
            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(cntrl);
            _encodingControl = cntrl;
        }

        private void comboBoxEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNameEncoder.Text = $"Шифр : {(string)comboBoxEncoding.SelectedItem}";

            QuestionByTestingHolder.UpdateResult();
            _guid = Guid.NewGuid();
            FileStream fs = null;

            EncoderType enc = EncodingTypes.GetEncodingType(comboBoxEncoding.SelectedItem.ToString());
            string path = $"Theory/{enc.ToString()}.txt";

            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Open);

                using (StreamReader sr = new StreamReader(fs))
                {
                    tbTheory.Text = sr.ReadToEnd();
                }
            }

            Control cntrl = (enc == EncoderType.DiffiHelman ||
                (enc == EncoderType.SHA1) ||
                 (enc == EncoderType.MD5)) ? new BaseEncodeControl(this, enc) 
                : (Control)new DecodeEncodeControl(enc);


            SelectEncodingControl(cntrl);
            GetAnotherTest();
        }

        private void lvHistory_Click(object sender, EventArgs e)
        {

        }

        private void lvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHistory.SelectedItems.Count > 0)
            {
                ListViewItem item = lvHistory.SelectedItems[0];
                string name = item.SubItems[0].Text;
                tPHistory.Controls.Clear();
                tPHistory.Controls.Add(new HistoryCoddingControl(name, _historyPresentation, this));
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                tPHistory.Controls.Clear();
                tPHistory.Controls.Add(lvHistory);
            }
            catch { }

            int number = 1;
            lvHistory.Items.Clear();
            foreach (var entity in _historyPresentation.GetAllHistory())
            {
                ListViewItem listViewItem = new ListViewItem(entity.Item1);
                listViewItem.SubItems.Add(entity.Item2.ToString());

                if (number % 2 == 1)
                {
                    listViewItem.BackColor = Color.LightBlue;
                }
                else
                {
                    listViewItem.BackColor = Color.WhiteSmoke;
                }

                lvHistory.Items.Add(listViewItem);
                number++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void cLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (_currentquestionByTesting == null)
            {
                return;
            }

            string answer = (string)cLB.SelectedItem;

            if (answer == null)
            {
                return;
            }

            if (answer != null)
            {
                string[] splitAnswe = answer.Split('-');
                int index = int.Parse(splitAnswe[0]);

                if (index == _currentquestionByTesting.Answer)
                {
                    _currentquestionByTesting.AnswerType = AnswerType.Correct;
                }
                else
                {
                    _currentquestionByTesting.AnswerType = AnswerType.NotCorrect;
                }
            }

            _historyPresentation.AddHistory(new RequestHistory()
            {
                CodingType = CodingType.Test,
                Question = _currentquestionByTesting.Description,
                Answer = answer,
                CorrectAnswer = _currentquestionByTesting.Questions
                .FirstOrDefault(p => p.Key == _currentquestionByTesting.Answer).Value,
                GuidId = _guid,
                Mark = _currentquestionByTesting.AnswerType == AnswerType.Correct ? 1 : 0,
                Name = (string)comboBoxEncoding.SelectedItem
            });

            var enc = EncodingTypes.GetEncodingType(comboBoxEncoding.SelectedItem.ToString());
            var correct = QuestionByTestingHolder.GetQuestionByTestings(enc)
                .Count(p => p.AnswerType == AnswerType.Correct);

            lbCorrectAnswer.Text = correct.ToString();

            _currentquestionByTesting = QuestionByTestingHolder.GetQuestionByTestings(enc)
                .FirstOrDefault(p => p.AnswerType == AnswerType.Defoult);

            if (_currentquestionByTesting == null)
            {
                _testingCach = panel2;
                lbCorrectAnswer.Text = "0";
                tabPage3.Controls.Clear();
                var testingCntrl = new TestingResultControl(correct, _testingCount, this);
                tabPage3.Controls.Add(testingCntrl);

                // Resize
                var cntrlResize = new ControlWithResizes
                {
                    Control = testingCntrl,
                    Resizes =
                    {
                        SetLocationCentredToParrent,
                        cntrl => SetYIndentToForm(this, cntrl, 0.07)
                    }
                };
                _controlsWithResizes.Add(cntrlResize);

                cntrlResize.Resize();

                _currentTask = 0;
                _currentquestionByTesting = null;
                QuestionByTestingHolder.UpdateResult();
                return;
            }

            _currentTask++;
            lbCurrentTask.Text = _currentTask.ToString();
            lbDescription.Text = _currentquestionByTesting.Description;
            cLB.Items.Clear();

            foreach (var s in _currentquestionByTesting.Questions)
            {
                cLB.Items.Add($"{s.Key}-{s.Value}");
            }
        }

        private void yearLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

