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
            private static Dictionary<EncodingType, string> _data
                = new Dictionary<EncodingType, string> {
                    { EncodingType.Caesar, "Шифр Цезаря" },
                    { EncodingType.Des, "Шифр Des"}
                };

            public static string[] GetAllNames() => _data.Select(x => x.Value).ToArray();
            public static EncodingType[] GetAllEncodingTypes() => _data.Select(x => x.Key).ToArray();
            public static string GetName(EncodingType type) => _data[type];
            public static EncodingType GetEncodingType(string Name) 
                => _data.FirstOrDefault(x => x.Value == Name).Key;
        }

        public static class MonoAlhabets
        {
            private static Dictionary<EncodingType, string> _data
                = new Dictionary<EncodingType, string> {
                    { EncodingType.Caesar, "Шифр Цезаря" },
                    { EncodingType.Des, "Шифр Des"}
                };
        }
    }
}
