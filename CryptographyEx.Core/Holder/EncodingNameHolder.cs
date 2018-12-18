using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Holder
{
    public static class EncodingNameHolder
    {
        public static Dictionary<EncoderType,string> Encoding { get; set; }
        public static Dictionary<EncoderType, int> EncodingCount { get; set; }
        static EncodingNameHolder()
        {
            Encoding = new Dictionary<EncoderType, string>();
            EncodingCount = new Dictionary<EncoderType, int>();
            InitEncoding();
            InitEncodingCount();
        }
        private static void InitEncoding()
        {
            Encoding.Add(EncoderType.Caesar, "Caesar");
            Encoding.Add(EncoderType.Des, "Des");
            Encoding.Add(EncoderType.DiffiHelman, "Diffie-Hellman");
            Encoding.Add(EncoderType.Elgamal, "EL-GAMAL + DIFFIE-HELLMAN");
            Encoding.Add(EncoderType.Stierlitz, "Stierlitz");
            Encoding.Add(EncoderType.Trithemius, "Trithemius");
            Encoding.Add(EncoderType.Vigenere, "Vigenere");

        }
        private static void InitEncodingCount()
        {
           EncodingCount.Add(EncoderType.Caesar, 4);
           EncodingCount.Add(EncoderType.Des,4);
           EncodingCount.Add(EncoderType.DiffiHelman,4);
           EncodingCount.Add(EncoderType.Elgamal, 4);
           EncodingCount.Add(EncoderType.Stierlitz, 4);
           EncodingCount.Add(EncoderType.Trithemius, 4);
           EncodingCount.Add(EncoderType.Vigenere, 4);
        }

        public static string GetNameByType(EncoderType encodingType)
        {

            if (EncodingCount.ContainsKey(encodingType))
            {
                return Encoding[encodingType];
            }

            return null;
        }

        public static List<string> GetNames()
        {
            return Encoding.Select(p => p.Value).ToList();
        }

        public static int GetCountByTest(EncoderType encodingType)
        {
            if (EncodingCount.ContainsKey(encodingType))
            {
                return EncodingCount[encodingType];
            }

            return 0;
        }


        public static EncoderType GetEncodingType(string name)
        {
            if (Encoding.Values.Contains(name))
            {
                return Encoding.FirstOrDefault(p=>p.Value.Equals(name)).Key;
            }

            return EncoderType.Caesar;
        }
    }
}
