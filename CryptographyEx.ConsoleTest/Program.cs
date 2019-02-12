using CryptographyEx.Core;
using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
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
                .SetMonoAlphabet(UTF16)
                .Configure(2, new Func<int, int>(x => x + 1));

            IAlphabetEncoder vigener = EncoderFactory
                .CreateEncoder(EncoderType.Vigenere)
                .Configure("Lemon");

            IAlphabetEncoder diffiHelman = EncoderFactory
                .CreateEncoder(EncoderType.DiffiHelman)
                .Configure(5,23,new List<int>() {23,43 });
            IAlphabetEncoder DSA = EncoderFactory
               .CreateEncoder(EncoderType.DSA)
               .Configure(19,5).Configure("OBCDEFQW","ABCDEFQW");
            IAlphabetEncoder elgamal = EncoderFactory
             .CreateEncoder(EncoderType.Elgamal)
             .Configure(11, 2,8,9); 

            IAlphabetEncoder des = EncoderFactory
                .CreateBitEncoder(BitEncodingType.Des)
                .Configure("чр3Ъ");

            // Console.WriteLine(caesar.Encode("Azb12365.,&^%$@"));
            Console.WriteLine(trithemius.Encode("<Azb"));
            Console.WriteLine(trithemius.Decode(trithemius.Encode("Azb")));

          
            //Console.WriteLine(diffiHelman.Decode(null));
            //string v = DSA.Encode("Here is some data to encrypt.");
            //Console.WriteLine(v);
            //Console.WriteLine(DSA.Decode(v));
            //Console.WriteLine(elgamal.Encode("6,9"));

            //string input = "Input";

            //BitMessage mess = BitMessage.Parse(input);
            //string binary = mess.ToBinaryString();

            //string output = mess.ToString();

            //Console.WriteLine($"\n{input}\n{binary}\n{output}");
            //byte[] b = new UnicodeEncoding().GetBytes(des.Encode("Do you know"));
            //string str = new UnicodeEncoding().GetString(b);
            //Console.WriteLine(str);
            //b.ToList().ForEach(x => Console.WriteLine(x));
            //var mark = new Mark(1, 5);
            //Console.WriteLine(mark.Total);

            Console.ReadLine();
        }
    }
}
