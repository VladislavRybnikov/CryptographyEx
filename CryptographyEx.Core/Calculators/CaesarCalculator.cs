using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Calculators
{
    public class CaesarCalculator : IEncoderCalculator
    {
        private int _key;
        
        public CaesarCalculator SetKey(int key)
        {
            _key = key;
            return this;
        }

        public CalculationResult Calculate(string input)
        {
            
            var result = new CalculationResult();
            result.CalculationsPipeline.Add("  --  ");

            result.CalculationsPipeline.Add("Початок обчислень...");
            result.CalculationsPipeline.Add("Тип шифрування: Шифр Цезаря");

            var Eng = Alphabet.CreateMono(MonoAlphabet.ENG);
            result.CalculationsPipeline.Add("Задамо моно алфавіт: Eng");
            result.CalculationsPipeline.Add($"Повідомлення: {input}");

            IAlphabetEncoder caesar = EncoderFactory
                .CreateEncoder(EncodingType.Caesar)
                .SetMonoAlphabet(Eng)
                .Configure(_key);
            result.CalculationsPipeline.Add($"Створимо алгоритм шифрування для ключа: {_key}");
            result.CalculationsPipeline.Add("...");

            result.Encoded = caesar.Encode(input);
            result.CalculationsPipeline.Add($"Результат обчислень: {result.Encoded}.");
            result.CalculationsPipeline.Add("");

            return result;
        }
    }
}
