using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Encoders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core
{
    public static class EncoderFactory
    {
        public static IEncoder CreateEncoder(EncodingType encoding)
        {
            switch (encoding)
            {
                case EncodingType.Caesar:
                    return new CaesarEncoder();

                case EncodingType.Trithemius:
                    return new TrithemiusEncoder();

                case EncodingType.Stierlitz:
                    return new StierlitzEncoder();

                case EncodingType.Vigenere:
                    return new VigenereEncoder();
            }

            throw new Exception("Not implemented encoding.");
        }
    }
}
