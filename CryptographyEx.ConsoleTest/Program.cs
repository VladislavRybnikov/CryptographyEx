using CryptographyEx.Core;
using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ENG_ALPHA = Alphabet.CreateMono(MonoAlphabet.ENG);

            IEncoder caesar = EncoderFactory
                .CreateEncoder(EncodingType.Caesar)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2);

            IEncoder trithemius = EncoderFactory
                .CreateEncoder(EncodingType.Trithemius)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2, new Func<int, int>(x => x + 1));

            IEncoder vigener = EncoderFactory
                .CreateEncoder(EncodingType.Vigenere)
                .SetPolyAplhabet(new VigenereTable())
                .Configure("Lemon");

            Console.WriteLine(caesar.Encode("Azb"));

            Console.WriteLine(trithemius.Decode(trithemius.Encode("Azb")));

            Console.WriteLine(vigener.Encode("ATTACKATDAWN"));
            Console.ReadLine();
        }
    }
}
