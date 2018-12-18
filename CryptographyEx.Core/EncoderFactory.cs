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
        public static IBitEncoder CreateBitEncoder
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
                case EncoderType.Elgamal:
                    return new ElgamalEncoder();
            }

            throw new Exception("Not implemented encoding.");
        }
    }
}
