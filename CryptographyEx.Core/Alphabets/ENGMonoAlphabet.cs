using CryptographyEx.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public class ENGMonoAlphabet : IMonoAlphabet
    {
        public char[] Value
        {
            get
            {
                List<char> value = new List<char>();

                for (int i = 65; i <= 90; i++)
                {
                    value.Add((char)i);
                }

                value.Add(' ');

                return value.ToArray();
            }
        }

        public int Length => Value.Length;
    }
}
