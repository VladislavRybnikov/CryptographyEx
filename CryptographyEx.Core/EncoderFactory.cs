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
        public static IBitEncoder Create64Encoder()
        {
            return null;
        }

        public static IAlphabetEncoder CreateEncoder(EncodingType encoding)
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
                case EncodingType.DiffiHelman:
                    return new DiffiHelmanEncoder();
                case EncodingType.Elgamal:
                    return new ElgamalEncoder();
            }

            throw new Exception("Not implemented encoding.");
        }
    }
}
