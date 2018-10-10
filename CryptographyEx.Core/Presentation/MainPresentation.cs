using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CryptographyEx.Core.Base;

namespace CryptographyEx.Core.Presentation
{
    public class MainPresentation : IMainPresentation
    {
        private static Random _random { get; set; } =new Random();

        public IQuestionValue GenerateQuestion(CodingType codingType, EncodingType encodingType)
        {
            IQuestionValue value = new QuestionValue();

            int countNumber = _random.Next(6, 10);
            StringBuilder question = new StringBuilder();
            List<int> primes = new List<int>();

            switch (encodingType)
            {
                case EncodingType.Caesar:

                    for (int i = 0; i <= countNumber; i++)
                    {
                        char symbol = (char)_random.Next(65, 91);

                        question.Append(symbol);
                    }
                    value.Description =  question.ToString();
                    break;

                case EncodingType.Vigenere:
                    for (int i = 0; i <= countNumber; i++)
                    {
                        char symbol = (char)_random.Next(65, 91);

                        question.Append(symbol);
                    }
                    value.Description =  question.ToString();
                    break;

                case EncodingType.DiffiHelman:
                    value = new DiffiHelmanQuestion();
                    IDiffiHelmanQuestion diffiHelman = (IDiffiHelmanQuestion)value;
                     primes = GetPrimes(203);

                    diffiHelman.N = primes[_random.Next(0, primes.Count)];
                    diffiHelman.Q = _random.Next(2, diffiHelman.N - 1);
                    diffiHelman.X = _random.Next(11, 100);
                    diffiHelman.Y = _random.Next(11, 100);
                    value = diffiHelman;
                    break;
                case EncodingType.Elgamal:
                    primes = GetPrimes(203);
                    value = new ElgamalQuestion();
                    IElgamalQuestion elgmal = (IElgamalQuestion)value;
                    elgmal.P = primes[_random.Next(2, primes.Count)];
                    elgmal.A = _random.Next(3, elgmal.P-1);
                    elgmal.B = _random.Next(1, elgmal.P - 2);
                    elgmal.R = _random.Next(1, elgmal.P - 1);
                    
                    switch(codingType)
                    {
                        case CodingType.Encoding:
                            elgmal.Description = $"{_random.Next(2, 20)},{_random.Next(2, 200)}";
                            break;
                        case CodingType.Decoding:
                            elgmal.Description = $"{_random.Next(2, 20)}";
                            break;
                    }
                    break;
            }

            return value;
        }

        public Tuple<AnswerType,string> CheckAnswer(
            IQuestion currentQuestion, 
            MonoAlphabet mono, 
            PolyAlphabet poly, 
            params object[] args)
        {
            IAlphabetEncoder encoder = EncoderFactory
                      .CreateEncoder(currentQuestion.EncodingType)
                      .SetMonoAlphabet(Alphabet.CreateMono(mono))
                      .Configure(args);
            string answer = String.Empty;

            switch (currentQuestion.CodingType)
            {
                case CodingType.Decoding:
                    answer =
                       encoder.Decode(currentQuestion.Description.Description);

                    if (currentQuestion.Answer.Answer.ToLower()
                        .Equals(answer.ToLower()))
                    {
                        return new Tuple<AnswerType, string>
                            (AnswerType.Correct, answer);
                    }
                    break;
                case CodingType.Encoding:
                    answer =
                        encoder.Encode(currentQuestion.Description.Description);

                    if (currentQuestion.Answer.Answer.ToLower()
                        .Equals(answer.ToLower()))
                    {
                        return new Tuple<AnswerType, string>
                            (AnswerType.Correct, answer);
                    }
                    break;
            }

       
            return new Tuple<AnswerType, string>
                                    (AnswerType.NotCorrect, answer);
        }

        public static List<int> GetPrimes(int n)
        {

            bool[] is_prime = new bool[n + 1];
            for (int i = 2; i <= n; ++i)
                is_prime[i] = true;

            List<int> primes = new List<int>();

            for (int i = 2; i <= n; ++i)
                if (is_prime[i])
                {
                    primes.Add(i);
                    if (i * i <= n)
                        for (int j = i * i; j <= n; j += i)
                            is_prime[j] = false;
                }

            return primes;
        }
    }
}
