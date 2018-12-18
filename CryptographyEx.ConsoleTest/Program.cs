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
            var ENG_ALPHA = Alphabet.GetMono(MonoAlphabet.ENG);
            var UTF16 = Alphabet.GetMono(MonoAlphabet.UTF16);

            IAlphabetEncoder caesar = EncoderFactory
                .CreateEncoder(EncoderType.Caesar)
                .SetMonoAlphabet(UTF16)
                .Configure(1);

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncoderType.Trithemius)
                .SetMonoAlphabet(ENG_ALPHA)
                .Configure(2, new Func<int, int>(x => x + 1));

            IAlphabetEncoder vigener = EncoderFactory
                .CreateEncoder(EncoderType.Vigenere)
                .Configure("Lemon");

            IAlphabetEncoder diffiHelman = EncoderFactory
                .CreateEncoder(EncoderType.DiffiHelman)
                .Configure(5,23,new List<int>() {23,43 });
            IAlphabetEncoder elgamal = EncoderFactory
             .CreateEncoder(EncoderType.Elgamal)
             .Configure(11, 2,8,9); 

            IBitEncoder des = EncoderFactory
                .CreateBitEncoder(BitEncodingType.Des)
                .Configure("чр3Ъ");

            Console.WriteLine(caesar.Encode("Azb12365.,&^%$@"));

            Console.WriteLine(trithemius.Decode(trithemius.Encode("Azb")));

            Console.WriteLine(vigener.Encode("ATTACKATDAWN"));
            Console.WriteLine(diffiHelman.Decode(null));
            Console.WriteLine(elgamal.Decode("5"));
            Console.WriteLine(elgamal.Encode("6,9"));

            string input = "Input";

            BitMessage mess = BitMessage.Parse(input);
            string binary = mess.ToBinaryString();

            string output = mess.ToString();

            Console.WriteLine($"\n{input}\n{binary}\n{output}");
            byte[] b = new UnicodeEncoding().GetBytes(des.Encode("Do you know"));
            string str = new UnicodeEncoding().GetString(b);
            Console.WriteLine(str);
            b.ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }
    }
}
