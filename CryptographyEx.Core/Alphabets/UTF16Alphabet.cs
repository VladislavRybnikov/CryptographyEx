using CryptographyEx.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public class UTF16Alphabet : IMonoAlphabet
    {
        public char[] Value {
            get
            {
                List<char> value = new List<char>();

                for (int i = 1; i < 256; i++)
                {
                    value.Add((char)i);
                }

                return value.ToArray();
            }
        }

        public int Length => throw new NotImplementedException();
    }
}
