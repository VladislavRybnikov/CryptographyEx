using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Structures;
using CryptographyEx.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class DESEncoder : IBitEncoder
    {
        private const int _sizeOfBlock = 128;
        private const int _rounds = 16;
        private BitMessage[] _binaryBlocks;
        private string[] _stringBlocks;

        private string _key;
        private int _shiftKey = 2;
        private bool _configurated;

        private string StringFormat(string input)
        {
            StringBuilder sb = new StringBuilder(input);

            while (((sb.Length * Bit.SizeOfChar) % _sizeOfBlock) != 0)
                sb.Append("#");

            return sb.ToString();
        }

        private string KeyFormat(string input, int length)
        {
            if (input.Length > length)
                input = input.Substring(0, length);
            else
                while (input.Length < length)
                    input = "0" + input;

            return input;
        }

        private BitMessage EncoderFunction(BitMessage b, BitMessage key)
        {
            return b ^ key;
        }

        private string KeyToNextRound(string key)
        {
            for (int i = 0; i < _shiftKey; i++)
            {
                key = key[key.Length - 1] + key;
                key = key.Remove(key.Length - 1);
            }

            return key;
        }

        private string KeyToPrevRound(string key)
        {
            for (int i = 0; i < _shiftKey; i++)
            {
                key = key + key[0];
                key = key.Remove(0, 1);
            }

            return key;
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
            => BitMessage.Parse(Encode(message.ToString()));

        public string Encode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Not configurated.");
            }

            BitMessage Round(BitMessage mess, BitMessage key)
            {
                BitMessage L = mess.Take(mess.Count() / 2).ToArray();
                BitMessage R = mess.Skip(mess.Count() / 2).ToArray();

                return R + (L ^ EncoderFunction(R, key));
            }

            string[] CutString(string input)
            {
                string[] Blocks = new string[(input.Length * Bit.SizeOfChar) / _sizeOfBlock];

                int lengthOfBlock = input.Length / Blocks.Length;

                for (int i = 0; i < Blocks.Length; i++)
                    Blocks[i] = input.Substring
                        (i * lengthOfBlock, lengthOfBlock);

                return Blocks;
            }

            message = StringFormat(message);

            _binaryBlocks = CutString(message)
                .Select(x => BitMessage.Parse(x)).ToArray();

            var bitKey = BitMessage.Parse
                (KeyFormat(_key, message.Length
                / (2 * _binaryBlocks.Length)));

            for (int i = 0; i < _rounds; i++)
            {
                for (int j = 0; j < _binaryBlocks.Length; j++)
                {
                    _binaryBlocks[j] = Round(_binaryBlocks[j], bitKey);
                }

                bitKey = BitMessage.ParseBinary(KeyToNextRound
                    (bitKey.ToBinaryString()));
            }

            bitKey = BitMessage.ParseBinary(KeyToPrevRound
                (bitKey.ToBinaryString()));

            return BitMessage.ParseBinary(String
                .Concat(_binaryBlocks
                .Select(x => x.ToBinaryString())))
                .ToString();
        }

        public IAlphabetEncoder Configure(params object[] args)
        {
            _key = args[0].ToString();
            _configurated = true;

            return this;
        }

        public IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet)
        {
            throw new NotImplementedException();
        }

        public IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet)
        {
            throw new NotImplementedException();
        }
    }
}
