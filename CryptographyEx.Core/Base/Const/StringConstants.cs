using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Base.Const
{
    public static class StringConstants
    {
        public static class EncodingTypes
        {
            private static Dictionary<EncoderType, string> _data
                = new Dictionary<EncoderType, string> {
                    { EncoderType.Caesar, "Шифр Цезаря" },
                    { EncoderType.Des, "Шифр Des"},
                    { EncoderType.DiffiHelman, "Шифр Диффи Хелмана" },
                    { EncoderType.Elgamal, "Шифр Ельгамала"},
                    { EncoderType.Stierlitz, "Шифр Штірліца" },
                    { EncoderType.Trithemius, "Шифр Трітеміуса" },
                    { EncoderType.Vigenere, "Шифр Виженера"}

                };

            public static string[] GetAllNames() => _data.Select(x => x.Value).ToArray();
            public static EncoderType[] GetAllEncodingTypes() => _data.Select(x => x.Key).ToArray();
            public static string GetName(EncoderType type) => _data[type];
            public static EncoderType GetEncodingType(string Name) 
                => _data.FirstOrDefault(x => x.Value == Name).Key;
        }

        public static class MonoAlphabets
        {
            private static Dictionary<MonoAlphabet, string> _data
                = new Dictionary<MonoAlphabet, string> {
                    { MonoAlphabet.Auto, "Auto"},
                    { MonoAlphabet.ENG, "ENG" },
                    { MonoAlphabet.RU, "RU"},
                    { MonoAlphabet.UTF16, "UTF16"}
                };

            public static (MonoAlphabet Alphabet, string Name) Default() 
                => _data.Where(x => x.Key == MonoAlphabet.ENG).Select(x => (x.Key, x.Value)).FirstOrDefault();

            public static string[] GetAllNames() => _data.Select(x => x.Value).ToArray();
            public static MonoAlphabet[] GetAllEncodingTypes() => _data.Select(x => x.Key).ToArray();
            public static string GetName(MonoAlphabet type) => _data[type];
            public static MonoAlphabet GetMonoAlphabet(string Name)
                => _data.FirstOrDefault(x => x.Value == Name).Key;
        }

        public static class CodingTypes
        {
            private static Dictionary<CodingType, string> _data = new Dictionary<CodingType, string>
            {
                [CodingType.Decoding] = "Дешифрування",
                [CodingType.Encoding] = "Шифрування"
            };

            public static string[] GetAllNames() => _data.Select(x => x.Value).ToArray();
            public static CodingType[] GetAllCodingTypes() => _data.Select(x => x.Key).ToArray();
            public static string GetName(CodingType type) => _data[type];
            public static CodingType GetCodingType(string name) => _data.FirstOrDefault(x => x.Value == name).Key;
        }
    }
}
