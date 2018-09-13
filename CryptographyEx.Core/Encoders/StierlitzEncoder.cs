using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class StierlitzEncoder : IAlphabetEncoder
    {
        private IPolyAlphabet _alphabet;

        public IAlphabetEncoder Configure(params object[] args)
        {
            return this;
        }

        public string Decode(string message)
        {
            var splited = message.Split(' ');

            try
            {
                splited.Select(x => Convert.ToInt32(x));
            }
            catch(Exception ex)
            {
                throw new Exception("WrongMessage", ex);
            }

            var codes = splited.Select(x => 
            {
                var half = x.Length / 2;

                return new Tuple<int, int>
                ( 
                    Convert.ToInt32(x.Substring(0, half)),
                    Convert.ToInt32(x.Substring(half, half))
                );
            });

            var decoded = new string(codes
                .Select(x => _alphabet.Get(x.Item1, x.Item2))
                .ToArray());

            return decoded;
        }

        public string Encode(string message)
        {
            var splited = message.ToUpper().ToCharArray();

            splited.ToList().ForEach(x => {
                if (_alphabet.Contains(x))
                {
                    throw new Exception("Wrong message.");
                }
            });

            string strFormat = (_alphabet.Width > _alphabet.Height
                ? _alphabet.Width : _alphabet.Height).ToString()
                .Select(x => "0").ToString();

            StringBuilder sb = new StringBuilder();

            for (int current = 0; current < message.Length; current++)
            {
                for (int i = 0; i < _alphabet.Height; i++)
                {
                    for (int j = 0; j < _alphabet.Width; j++)
                    {
                        if (_alphabet.Value[i][j] == splited[current])
                        {
                            sb.Append(i.ToString(strFormat));
                            sb.Append(j.ToString(strFormat));
                            sb.Append(" ");
                            break;
                        }
                    }
                }
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
