using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class DiffiHelmanEncoder : IAlphabetEncoder
    {

        private List<int> _members;
        private int _n;
        private int _q;
        private bool _configurated = false;


        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _n = Convert.ToInt32(args[0]);
                _q = Convert.ToInt32(args[1]);
                _members = (List<int>)args[2];
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Wrong arguments", ex);
            }

            _configurated = true;

            return this;
        }

        public string Decode(string message=null)
        {
            if (!_configurated)
            {
                throw new Exception("Encoder doesn't configurated!");
            }

            // string key = string.Empty;
            //List<int> results = new List<int>();

            //foreach(var member in _members)
            //{
            //    long result = (long)Math.Pow(_q, member) % _n;
            //   // results.Add(result);
            //}
            double result = (double)Math.Pow(_q, _members[1]) % _n;

            double key = (double)Math.Pow(result, _members[0]) % _n;

            return key.ToString();
        }

        public string Encode(string message)
        {
            throw new NotImplementedException();
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
