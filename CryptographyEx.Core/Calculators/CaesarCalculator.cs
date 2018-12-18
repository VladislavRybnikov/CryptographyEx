using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static CryptographyEx.Core.Base.Const.StringConstants;

namespace CryptographyEx.Core.Calculators
{
    public class CaesarCalculator : IEncoderCalculator
    {
        private int _key = 5;
        private MonoAlphabet _monoAlphabet = MonoAlphabet.ENG;
        private CodingType _codingType;

        public CaesarCalculator SetKey(int key)
        {
            _key = key;
            return this;
        }

        public CaesarCalculator SetAlphabet(MonoAlphabet alphabet)
        {
            _monoAlphabet = alphabet;
            return this;
        }

        public CaesarCalculator SetCodingType(CodingType type)
        {
            _codingType = type;
            return this;
        }

        public CalculationResult Calculate(string input)
        {
            var result = CalculationResult.StartCalculations
                (input, _monoAlphabet, EncoderType.Caesar, _codingType, out IMonoAlphabet alpha);
            
            IAlphabetEncoder caesar = EncoderFactory
                .CreateEncoder(EncoderType.Caesar)
                .SetMonoAlphabet(alpha)
                .Configure(_key);
            
            var output = _codingType == CodingType.Encoding 
                ? caesar.Encode(input) : caesar.Decode(input);

            return result.WithKey(_key.ToString()).EndCalculations(output);
        }
    }
}
