using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class VigenereEncoder : IAlphabetEncoder
    {
        private bool _configurated = false;
        private string _key;
        private IPolyAlphabet _alphabet;

        public VigenereEncoder()
        {
            _alphabet = new VigenereTable();
        }

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _key = (string)args[0];
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Wrong argument.", ex);
            }

            _configurated = true;

            return this;
        }

        private string GetFullKey(int length)
        {
            int count = 0;

            StringBuilder sb = new StringBuilder();

            while (count < length)
            {
                for (int i = 0; i < _key.Length; i++)
                {
                    if (count == length)
                    {
                        break;
                    }

                    sb.Append(_key[i]);
                    count++;
                }
            }

            return sb.ToString().ToUpper();
        }

        public string Decode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            throw new NotImplementedException();
        }

        public string Encode(string message)
        {
           
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            message = message.ToUpper();

            var fullKey = GetFullKey(message.Length);

            StringBuilder sb = new StringBuilder();

            var mono = _alphabet.Value[0];

            int IndexOfMono(char c)
            {
                return mono.Select((v, i) => new { value = v, index = i })
                    .FirstOrDefault(x => x.value == c).index;
            }

            for (int i = 0; i < message.Length; i++)
            {
                sb.Append(_alphabet.Value[IndexOfMono(message[i])]
                    [IndexOfMono(fullKey[i])]);
            }

            return sb.ToString();
        }

        public IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet)
        {
            return this;
        }

        public IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet)
        {
            _alphabet = alphabet;

            return this;
        }
    }
}
