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

            IAlphabetEncoder caesar = EncoderFactory
                .CreateEncoder(EncodingType.Caesar)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2);

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncodingType.Trithemius)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2, new Func<int, int>(x => x + 1));

            IAlphabetEncoder vigener = EncoderFactory
                .CreateEncoder(EncodingType.Vigenere)
                .Configure("Lemon");
            IAlphabetEncoder diffiHelman = EncoderFactory
                .CreateEncoder(EncodingType.DiffiHelman)
                .Configure(5,23,new List<int>() {23,43 });
            IAlphabetEncoder elgamal = EncoderFactory
             .CreateEncoder(EncodingType.Elgamal)
             .Configure(11, 2,8,9); 

            Console.WriteLine(caesar.Encode("Azb"));

            Console.WriteLine(trithemius.Decode(trithemius.Encode("Azb")));

            Console.WriteLine(vigener.Encode("ATTACKATDAWN"));
            Console.WriteLine(diffiHelman.Decode(null));
            Console.WriteLine(elgamal.Decode("5"));
            Console.WriteLine(elgamal.Encode("6,9"));


            Console.ReadLine();
        }
    }
}
