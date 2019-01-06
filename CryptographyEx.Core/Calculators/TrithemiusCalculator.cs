using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using CryptographyEx.Core.Util.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using static CryptographyEx.Core.Base.Const.StringConstants;

namespace CryptographyEx.Core.Calculators
{
    public class TrithemiusCalculator : IEncoderCalculator
    {
        private MapFunction<int> _map = new MapFunction<int>(x => x);
        private int _key = 5;

        private MonoAlphabet _monoAlphabet = MonoAlphabet.ENG;
        private CodingType _codingType;

        public TrithemiusCalculator SetAlphabet(MonoAlphabet alphabet)
        {
            _monoAlphabet = alphabet;
            return this;
        }

        public TrithemiusCalculator SetKey(int key)
        {
            _key = key;
            return this;
        }

        public TrithemiusCalculator SetCodingType(CodingType type)
        {
            _codingType = type;
            return this;
        }

        public TrithemiusCalculator SetMapFunction(MapFunction<int> map)
        {
            _map = map;
            return this;
        }

        public CalculationResult Calculate(string input)
        {
            var result = CalculationResult.StartCalculations
                (input, _monoAlphabet, EncoderType.Trithemius, _codingType, out IMonoAlphabet alpha);

            IAlphabetEncoder trithemius = EncoderFactory
                .CreateEncoder(EncoderType.Trithemius)
                .SetMonoAlphabet(alpha)
                .Configure(_key, (Func<int, int>)_map);

            var output = _codingType == CodingType.Encoding
                ? trithemius.Encode(input) : trithemius.Decode(input);

            return result.WithKey(_key.ToString()).WithFunction(_map).EndCalculations(output);
        }
    }
}
