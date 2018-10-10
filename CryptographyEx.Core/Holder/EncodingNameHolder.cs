using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Holder
{
    public static class EncodingNameHolder
    {
        public static Dictionary<EncodingType,string> Encoding { get; set; }
        public static Dictionary<EncodingType, int> EncodingCount { get; set; }
        static EncodingNameHolder()
        {
            Encoding = new Dictionary<EncodingType, string>();
            EncodingCount = new Dictionary<EncodingType, int>();
            InitEncoding();
            InitEncodingCount();
        }
        private static void InitEncoding()
        {
            Encoding.Add(EncodingType.Caesar, "Caesar");
            Encoding.Add(EncodingType.Des, "Des");
            Encoding.Add(EncodingType.DiffiHelman, "Diffie-Hellman");
            Encoding.Add(EncodingType.Elgamal, "EL-GAMAL + DIFFIE-HELLMAN");
            Encoding.Add(EncodingType.Stierlitz, "Stierlitz");
            Encoding.Add(EncodingType.Trithemius, "Trithemius");
            Encoding.Add(EncodingType.Vigenere, "Vigenere");

        }
        private static void InitEncodingCount()
        {
           EncodingCount.Add(EncodingType.Caesar, 4);
           EncodingCount.Add(EncodingType.Des,4);
           EncodingCount.Add(EncodingType.DiffiHelman,4);
           EncodingCount.Add(EncodingType.Elgamal, 4);
           EncodingCount.Add(EncodingType.Stierlitz, 4);
           EncodingCount.Add(EncodingType.Trithemius, 4);
           EncodingCount.Add(EncodingType.Vigenere, 4);
        }

        public static string GetNameByType(EncodingType encodingType)
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

        public static int GetCountByTest(EncodingType encodingType)
        {
            if (EncodingCount.ContainsKey(encodingType))
            {
                return EncodingCount[encodingType];
            }

            return 0;
        }


        public static EncodingType GetEncodingType(string name)
        {
            if (Encoding.Values.Contains(name))
            {
                return Encoding.FirstOrDefault(p=>p.Value.Equals(name)).Key;
            }

            return EncodingType.Caesar;
        }
    }
}
