using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class TrithemiusEncoder : IAlphabetEncoder
    {
        private bool _configurated = false;
        private int _key = 0;
        private Func<int, int> _encodeFunc;
        private IMonoAlphabet _alphabet;
       

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                ConfigureTrithemius((int)args[0], (Func<int, int>)args[1]);
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Wring arguments", ex);
            }

            return this;
        }

        private void ConfigureTrithemius(int key,
            Func<int, int> encodeFunction)
        {
            _key = key;
            _encodeFunc = encodeFunction;
            _configurated = true;
        }

        public string Decode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            var elements = message.ToUpper().ToCharArray();

            elements.ToList().ForEach(x
                => {
                    if (!_alphabet.Value.Contains(x))
                        throw new Exception("wrong message!");
                });

            var alphabetWithIndexes = _alphabet.Value
                .Select((value, index) => new { value, index });

            var key = _key;

            var coded = elements.Select(x =>
            {
                var index = alphabetWithIndexes
                .FirstOrDefault(y => y.value == x)
                .index;

                    x = _alphabet.Value[(_alphabet.Length + index - key)
                    % (_alphabet.Length)];

                key = _encodeFunc(key);

                return x;
            });

            return new string(coded.ToArray());
        }

        public string Encode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            var elements = message.ToUpper().ToCharArray();

            elements.ToList().ForEach(x
                => {
                    if (!_alphabet.Value.Contains(x))
                        throw new Exception("wrong message!");
                });

            var alphabetWithIndexes = _alphabet.Value
                .Select((value, index) => new { value, index });

            var key = _key;

            var coded = elements.Select(x =>
            {
                
                var index = alphabetWithIndexes
                .FirstOrDefault(y => y.value == x)
                .index;

                x = _alphabet.Value[(index + key) % (_alphabet.Length)];

                key = _encodeFunc(key);

                return x;
            });

            return new string(coded.ToArray());
        }

        public IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet)
        {
            _alphabet = alphabet;

            return this;
        }

        public IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet)
        {
            return this;
        }
    }
}
