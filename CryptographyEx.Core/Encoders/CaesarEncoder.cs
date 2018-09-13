using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class CaesarEncoder : IAlphabetEncoder
    {
        private bool _configurated = false;
        private int _key = 0;
        private IMonoAlphabet _alphabet;

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _key = Convert.ToInt32(args[0]);
            }
            catch
            {
                throw new ArgumentException();
            }

            _configurated = true;
            return this;
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

            var coded = elements.Select(x =>
            {
                var index = alphabetWithIndexes
                .FirstOrDefault(y => y.value == x)
                .index;

                x = _alphabet.Value[(_alphabet.Length + index - _key) 
                    % (_alphabet.Length)];
                
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

            var coded = elements.Select(x => 
            {
                var index = alphabetWithIndexes
                .FirstOrDefault(y => y.value == x)
                .index;

                x = _alphabet.Value[(index + _key) % (_alphabet.Length)];
                
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
