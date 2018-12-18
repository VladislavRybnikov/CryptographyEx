using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public static class Alphabet
    {
        private static Dictionary<MonoAlphabet, IMonoAlphabet> _alphabets
            = new Dictionary<MonoAlphabet, IMonoAlphabet>
            {
                [MonoAlphabet.ENG] = new ENGMonoAlphabet(),
                [MonoAlphabet.RU] = new RUMonoAlphabet(),
                [MonoAlphabet.UTF16] = new UTF16Alphabet() 
            };

        public static IMonoAlphabet GetMono(MonoAlphabet alphabetType) => _alphabets[alphabetType];
        public static IEnumerable<IMonoAlphabet> GetAllMonoAlphabets() => _alphabets.Select(x => x.Value);

        public static (IMonoAlphabet, MonoAlphabet) DetectMonoFromString(string input)
        {
            input = input.ToUpper();
            foreach (var alpha in _alphabets)
            {
                if (alpha.Value.Value.Contains(input[0]))
                {
                    bool finded = true;

                    foreach (var c in input)
                    {
                        if (!alpha.Value.Value.Contains(c))
                        {
                            finded = false;
                            break;
                        }
                    }

                    if (finded)
                        return (alpha.Value, alpha.Key);
                }
            }

            throw new ArgumentException("Cann't detect alphabet.");
        }

        public static IPolyAlphabet DefaultPolyAlphabet(char[][] alpha)
        {
            return new DefaultPolyAlphabet(alpha);
        }
    }
}
