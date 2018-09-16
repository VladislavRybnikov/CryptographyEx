using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Structures;
using CryptographyEx.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class DESEncoder : IBitEncoder
    {
        private const int _sizeOfBlock = 128;
        private BitMessage[] _blocks;

        private string StringFormat(string input)
        {
            StringBuilder sb = new StringBuilder(input);

            while (((input.Length * Bit.SizeOfChar) % _sizeOfBlock) != 0)
                sb.Append("#");

            return sb.ToString();
        }

        private void SetBlocks(string fromString)
        {

        }

        public BitMessage Decode(BitMessage message)
        {
            throw new NotImplementedException();
        }

        public string Decode(string message)
        {
            throw new NotImplementedException();
        }

        public BitMessage Encode(BitMessage message)
        {
            throw new NotImplementedException();
        }

        public string Encode(string message)
        {
            throw new NotImplementedException();
        }
    }
}
