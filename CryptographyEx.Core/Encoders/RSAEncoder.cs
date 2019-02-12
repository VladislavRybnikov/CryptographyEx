using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace CryptographyEx.Core.Encoders
{
    public class RSAEncoder : IAlphabetEncoder
    {
        private int _p;
        private int _q;
        private bool _configurated = false;

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _p = int.Parse(args[0].ToString()) ;
                _q = int.Parse(args[1].ToString()) ;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Wrong arguments", ex);
            }

            _configurated = true;

            return this;
        }

        public string Decode(string message)
        {
            double n = _p * _q;
            double r = (_p - 1) * (_q - 1);
            double e = 5;
            double d = 1;
            while (true)
            {
                if ((d * e) % r == 1)
                {
                    break;
                }
                d++;
            }

            if (int.TryParse(message, out int c))
            {
                return ((int)(Math.Pow(c    , d) % n)).ToString();
            }

            throw new InvalidOperationException();
        }

        public string Encode(string message)
        {

            double n = _p * _q;
            double e = 5;

            if(int.TryParse(message,out int m))
            {
                return ((int)(Math.Pow(m, e) % n)).ToString();
            }

            throw new InvalidOperationException();
        }

        public IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet)
        {
            return this;
        }

        public IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet)
        {
            return this;
        }
    }
}
