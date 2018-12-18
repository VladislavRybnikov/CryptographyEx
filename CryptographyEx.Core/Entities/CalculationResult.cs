using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

using static CryptographyEx.Core.Base.Const.StringConstants;
namespace CryptographyEx.Core.Entities
{
    public class CalculationResult
    {
        public string Output { get; set; }
        public List<string> CalculationsPipeline { get; private set; }

        public CalculationResult()
        {
            CalculationsPipeline = new List<string>();
        }

        public static CalculationResult Empty => new CalculationResult();

        public static CalculationResult StartCalculations(string input, MonoAlphabet alpha, 
            EncoderType encoderType, CodingType codingType, out IMonoAlphabet monoAlphabet)
        {
            var result = Empty;

            var alphabetInfo = "";

            if (alpha == MonoAlphabet.Auto)
            {
                var autoDetected = Alphabet.DetectMonoFromString(input);
                alphabetInfo = $"За вхідним повідомленням визначено алфавіт: " +
                $"{MonoAlphabets.GetName(autoDetected.Item2)}";
                monoAlphabet = autoDetected.Item1;
            }
            else
            {
                alphabetInfo = $"Задано алфавіт: {MonoAlphabets.GetName(alpha)}";
                monoAlphabet = Alphabet.GetMono(alpha);
            }

            result.CalculationsPipeline.AddRange(new string[]
            {
                "  --  ",
                "Початок обчислень...",
                $"Тип шифрування: {EncodingTypes.GetName(encoderType)}",
                $"Тип операції: {CodingTypes.GetName(codingType)}",
                alphabetInfo,
                $"Повідомлення: {input}"
            });

            return result;
        }

        public CalculationResult WithKey(string key)
        {
            CalculationsPipeline.Add($"Створимо алгоритм шифрування для ключа: {key}");
            return this;
        }

        public CalculationResult EndCalculations(string output)
        {
            Output = output;

            CalculationsPipeline.Add("...");
            CalculationsPipeline.Add($"Результат обчислень: {Output}.");
            return this;
        }

        public CalculationResult WithFunction(string function)
        {
            CalculationsPipeline.Add($"Задамо функцію перетворення ключа: {function}");
            return this;
        }
        
    }
}
