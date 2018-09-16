using CryptographyEx.Core;
using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Messages;
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
            var UTF16 = Alphabet.CreateMono(MonoAlphabet.UTF16);

            IAlphabetEncoder caesar = EncoderFactory
                .CreateEncoder(EncodingType.Caesar)
                .SetMonoAlphabet(UTF16)
                .Configure(1);

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncodingType.Trithemius)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2, new Func<int, int>(x => x + 1));

            IAlphabetEncoder vigener = EncoderFactory
                .CreateEncoder(EncodingType.Vigenere)
                .Configure("Lemon");

            Console.WriteLine(caesar.Encode("Azb12365.,&^%$@"));

            Console.WriteLine(trithemius.Decode(trithemius.Encode("Azb")));

            Console.WriteLine(vigener.Encode("ATTACKATDAWN"));

            string input = "Input";

            BitMessage mess = BitMessage.Parse(input);
            string binary = mess.ToBinaryString();

            string output = mess.ToString();

            Console.WriteLine($"\n{input}\n{binary}\n{output}");

            Console.ReadLine();
        }
    }
}
