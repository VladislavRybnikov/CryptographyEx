using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Holder
{
    public static class EncodingCountConfiguration
    {
        public const int Default = 5;

        public static Dictionary<EncoderType, int> EncodingCount { get; set; }
        static EncodingCountConfiguration()
        {
            EncodingCount = new Dictionary<EncoderType, int>
            {
                { EncoderType.Caesar, Default },
                { EncoderType.Des, Default },
                { EncoderType.DiffiHelman, Default },
                { EncoderType.Elgamal, Default },
                { EncoderType.Stierlitz, Default },
                { EncoderType.Trithemius, Default },
                { EncoderType.Vigenere, Default },
                 { EncoderType.RSA, Default }
            };
        }
        public static int GetCountByTest(EncoderType encodingType)
        {
            if (EncodingCount.ContainsKey(encodingType))
            {
                return EncodingCount[encodingType];
            }

            return 0;
        }
    }
}
