using CryptographyEx.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public class VigenereTable : DefaultPolyAlphabet, IPolyAlphabet
    {
        public VigenereTable() : base(Table())
        {

        }

        private static char[][] Table()
        {
            var mono = new UTF16Alphabet().Value
                .Take(new UTF16Alphabet().Length - 1);

            char[] ReplacePart(int fromIndex)
            {
                return mono.Skip(fromIndex)
                    .Concat(mono.Take(fromIndex)).ToArray();
            }

            var result = new char[mono.Count()][];

            for (int i = 0; i < mono.Count(); i++)
            {
                result[i] = ReplacePart(i);
            }

            return result;
        }
    }
}
