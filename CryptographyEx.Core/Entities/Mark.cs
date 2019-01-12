﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Entities
{
    public class Mark
    {
        public double Questions { get; private set; }
        public double Correct { get; private set; }

        public int Total { get; private set; }

        public Mark(int correct, int questions)
        {
            Questions = questions;
            Correct = correct;

            Total = (int)Math.Round((double)(correct / questions * 100));
        }

        public static implicit operator double(Mark m) => m.Total;
    }
}
