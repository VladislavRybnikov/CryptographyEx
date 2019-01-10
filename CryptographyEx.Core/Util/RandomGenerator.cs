using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Util.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Util
{
    public static class RandomGenerator
    {
        private static Random _random = new Random();

        public static MapFunction<int> NextTrithemiusFunction()
        {
            var randomOperation = _random.Next(1, 3);

            char operation = ' ';

            if (randomOperation == 1)
                operation = '+';
            else if (randomOperation == 2)
                operation = '-';
            else if (randomOperation == 3)
                operation = '*';

            const char left = 'x';
            var right = _random.Next(1, 4);

            return $"{left} {operation} {right}";
        }

        public static int NextKey() => _random.Next(1, 5);

        public static string NextENGMessage()
        {
            var count = _random.Next(4, 6);
            var alpha = new ENGMonoAlphabet();

            return new string(Enumerable.Range(1, count).Select(x => _random.Next(0, alpha.Length - 1))
                .Select(x => new ENGMonoAlphabet().Value[x]).ToArray());
        }
        
    }
}
