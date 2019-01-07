using CryptographyEx.Core;
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

namespace CryptographyEx.WinFormsUI
{
    public partial class EncodersForm : Form
    {
        private readonly IHistoryPresentation _historyPresentation;
        private QuestionByTesting _currentquestionByTesting;
        private int _currentTask;
        private Guid _guid;

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
        }

        private void Init()
        {
            comboBoxEncoding.Items.AddRange(EncodingNameHolder.GetNames().ToArray());
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

            void SetLocationCentred(Control container, Control element) 
                => element.Location = new Point((container.Width / 2) - element.Width / 2, 
                element.Location.Y);
            void SetLocationRight(Control container, Control element) 
                => element.Location = new Point(container.Width - element.Width - 10, element.Location.Y);

            void SetControlLocationWithXY(Control element, int x, int y) => element.Location = new Point(x, y);
            void SetPanel1ControlLocationWithY(Control element, int y)
                => SetControlLocationWithXY(element, (splitContainer1.Panel1.Width / 2) - element.Width / 2, y);
            void SetPanel2ControlLocationWithY(Control element, int y)
                => SetControlLocationWithXY(element, (splitContainer1.Panel2.Width / 2) - element.Width / 2, y);

            void SetPanel1ControlLocation(Control element) => SetPanel1ControlLocationWithY(element, element.Location.Y);
            void SetPanel2ControlLocation(Control element) => SetPanel2ControlLocationWithY(element, element.Location.Y);

            void SetControlSize(Control element, int width, int height) => element.Size = new Size(width, height);

            SetPanel1ControlLocation(encodersLabel);
            SetPanel1ControlLocation(panel4);
            SetPanel1ControlLocation(panel1);
            SetPanel1ControlLocation(panel10);

            SetPanel1ControlLocationWithY(panel3, splitContainer1.Panel1.Height - 150);
            SetPanel1ControlLocationWithY(lbNameEncoder, splitContainer1.Panel1.Height - 120 - panel3.Height);

            SetControlLocationWithXY(_encodingControl, (int)((splitContainer1.Panel2.Width - _encodingControl.Width)/ 2 * 0.9) - 8,Height / 45);
            
            SetPanel2ControlLocation(panel9);

            SetControlSize(tbTheory, splitContainer1.Panel2.Width - 30, Height - 150);
            SetControlLocationWithXY(tbTheory, splitContainer1.Panel2.Width / 2 - tbTheory.Width / 2 - 10, tbTheory.Location.Y);
            SetControlSize(panel9, tbTheory.Width, panel9.Height);
            SetControlLocationWithXY(panel9, tbTheory.Location.X, panel9.Location.Y);
            SetLocationCentred(panel9, label4);

            SetControlSize(panel5, splitContainer1.Panel2.Width - 50, panel5.Height);
            SetLocationCentred(panel5, label6);
            SetLocationRight(panel5, panel11);
            SetPanel2ControlLocationWithY(button1, (int)(panel2.Height * 0.8));

            SetControlSize(cLB, (int)(panel2.Width * 0.8), cLB.Height);
            SetControlLocationWithXY(cLB, cLB.Location.X, (int)(panel2.Height / 2 * 0.8));
            SetControlLocationWithXY(panel8, panel8.Location.X, cLB.Location.Y - panel8.Height);
            
            
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

            EncoderType enc = EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem);
            fs = new FileStream($"Theory/{enc.ToString()}.txt", FileMode.Open);

            using (StreamReader sr = new StreamReader(fs))
            {
                tbTheory.Text = sr.ReadToEnd();
            }

            Control cntrl = null;

            switch (EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem))
            {
                case EncoderType.Caesar:
                    cntrl = new DecodeEncodeControl(this);
                    break;
                case EncoderType.Vigenere:
                    cntrl = new DecodeEncodeControl(this);
                    break;
                case EncoderType.DiffiHelman:
                    cntrl = new DiffiHelmanControl(this);
                    break;
                default:
                    cntrl = new EmptyEncoderControl();
                    break;
            }
            SelectEncodingControl(cntrl);

            tabPage3.Controls.Clear();
            _currentquestionByTesting = QuestionByTestingHolder.GetQuestionByTestings(EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem)).FirstOrDefault(p => p.AnswerType == AnswerType.Defoult);

            if (_currentquestionByTesting == null)
            {
                return;
            }


            tabPage3.Controls.Add(panel2);
            lbDescription.Text = _currentquestionByTesting.Description;
            lbAllQuestions.Text = QuestionByTestingHolder.GetQuestionByTestings(EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem)).Count.ToString();
            _currentTask++;
            lbCurrentTask.Text = _currentTask.ToString();
            cLB.Items.Clear();

            foreach (var s in _currentquestionByTesting.Questions)
            {
                cLB.Items.Add($"{s.Key}-{s.Value}");
            }

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


            lbCorrectAnswer.Text = QuestionByTestingHolder.GetQuestionByTestings(EncodingNameHolder.GetEncodingType
                         ((string)comboBoxEncoding.SelectedItem)).Count(p => p.AnswerType == AnswerType.Correct).ToString();

            _currentquestionByTesting = QuestionByTestingHolder.GetQuestionByTestings(EncodingNameHolder.GetEncodingType
                       ((string)comboBoxEncoding.SelectedItem)).FirstOrDefault(p => p.AnswerType == AnswerType.Defoult);

            if (_currentquestionByTesting == null)
            {
                tabPage3.Controls.Clear();
                tabPage3.Controls.Add(new FinishControl(null, this));
                _currentTask = 0;
                // _currentquestionByTesting = null;

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

