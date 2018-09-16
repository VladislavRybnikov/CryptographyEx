using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class ElgamalEncoder : IAlphabetEncoder
    {
        private int _p;
        private int _g;
        private int _x;
        private int _k;
        private bool _configurated;

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _p = Convert.ToInt32(args[0]);
                _g = Convert.ToInt32(args[1]);
                _x = Convert.ToInt32(args[2]);
                _k = Convert.ToInt32(args[3]);

                if (_p > 4 && isSimple(_p) && _p > _g + 1 &&
                    _x > 0 && _x < _p && _k > 0 && _k < _p - 1)
                {
                    _configurated = true;

                    return this;
                }
                else
                {
                    throw new ArgumentException("Wring arguments");
                }


            }
            catch (Exception ex)
            {
                throw new ArgumentException("Wring arguments", ex);
            }
        }

        private bool isSimple(int number)
        {
            for (int i = 2; i < (int)(number / 2); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        public string Decode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            if (int.TryParse(message, out int kode))
            {
                long y = (long)Math.Pow(_g, _x) % _p;
                long a = (long)Math.Pow(_g, _k) % _p;
                long b = (long)Math.Pow(y, _k) * kode % _p;

                return $"({a},{b})";
            }

            throw new Exception("Error for message!");
        }

        public string Encode(string message)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            var texts = message.Split(',');

            if (int.TryParse(texts[0], out int a) && int.TryParse(texts[1], out int b))
            {
                var d = (double)Math.Pow(Math.Pow(a, _x), -1);
                var bd = (b * d).ToString();
                int ibd = int.Parse(bd.Substring(0, bd.IndexOf(',')));
                var m = ibd % _p;

                return m.ToString();
            }

            throw new Exception("Error for message!");
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
