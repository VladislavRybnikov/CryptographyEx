using CryptographyEx.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public class VigenereTable : DefaultPolyAlphabet, IPolyAlphabet
    {
        public VigenereTable() : base(table())
        {

        }

        private static char[][] table()
        {
            var mono = new ENGMonoAlphabet().Value
                .Take(new ENGMonoAlphabet().Length - 1);

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
