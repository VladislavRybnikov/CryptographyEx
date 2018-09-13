using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public static class Alphabet
    {
        public static IMonoAlphabet CreateMono(MonoAlphabet alphabetType)
        {
            switch (alphabetType)
            {
                case MonoAlphabet.ENG:
                    return new ENGMonoAlphabet();
            }

            return null;
        }

        public static IPolyAlphabet DefaultPolyAlphabet(char[][] alpha)
        {
            return new DefaultPolyAlphabet(alpha);
        }
    }
}
