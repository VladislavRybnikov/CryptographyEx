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
        public static IAlphabetEncoder CreateBitEncoder
            (BitEncodingType encoding)
        {
            switch (encoding)
            {
                case BitEncodingType.Des:
                    return new DESEncoder();
            }

            throw new Exception("Not implemented encoding.");
        }

        public static IAlphabetEncoder CreateEncoder(EncoderType encoding)
            {
            switch (encoding)
            {
                case EncoderType.Caesar:
                    return new CaesarEncoder();
                case EncoderType.Trithemius:
                    return new TrithemiusEncoder();
                case EncoderType.Stierlitz:
                    return new StierlitzEncoder();
                case EncoderType.Vigenere:
                    return new VigenereEncoder();
                case EncoderType.DiffiHelman:
                    return new DiffiHelmanEncoder();
                case EncoderType.SHA1:
                    return new SHA1Encoder();
                case EncoderType.MD5:
                    return new MD5Encoder();
                case EncoderType.DSA:
                    return new DSAEncoder();
                case EncoderType.Elgamal:
                    return new ElgamalEncoder();
                case EncoderType.RSA:
                    return new RSAEncoder();
            }

            throw new Exception("Not implemented encoding.");
        }
    }
}
