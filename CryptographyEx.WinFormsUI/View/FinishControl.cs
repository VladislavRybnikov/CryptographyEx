using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptographyEx.Core.Entities;

namespace CryptographyEx.WinFormsUI.View
{
    public partial class FinishControl : UserControl
    {
        private Mark _mark;

        public FinishControl(int correctAnswers, int questions)
        {
            InitializeComponent();

            _mark = new Mark(correctAnswers, questions);

            InitView();
        }

        public void InitView()
        {
            label3.Text += _mark.Questions;
            label2.Text += _mark.Correct;
            label4.Text += _mark.Total;
        }
    }
}
