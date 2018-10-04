using CryptographyEx.Core.Alphabets;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
            switch (encodingType)
            {
                case EncodingType.Caesar:

                   

                    for (int i = 0; i <= countNumber; i++)
                    {
                        char symbol = (char)_random.Next(65, 91);

                        question.Append(symbol);
                    }
                    value.Description = "b";// question.ToString();
                    break;

                case EncodingType.Vigenere:

                 

                    for (int i = 0; i <= countNumber; i++)
                    {
                        char symbol = (char)_random.Next(65, 91);

                        question.Append(symbol);
                    }
                    value.Description =  question.ToString();
                    break;
            }

            return value;
        }

        public Tuple<AnswerType,string> CheckAnswer(IQuestion currentQuestion,  params object[] args)
        {
            var ENG_ALPHA = Alphabet.CreateMono(MonoAlphabet.ENG);
            var UTF16 = Alphabet.CreateMono(MonoAlphabet.UTF16);

            string answer = String.Empty;

            switch (currentQuestion.EncodingType)
            {
                case EncodingType.Caesar:
                    IAlphabetEncoder caesar = EncoderFactory
                        .CreateEncoder(EncodingType.Caesar)
                         .SetMonoAlphabet(UTF16)
                          .Configure(args);

                    switch (currentQuestion.CodingType)
                    {
                        case CodingType.Decoding:
                             answer =
                                caesar.Decode(currentQuestion.Description.Description);
                            
                            if(currentQuestion.Answer.Answer.ToLower()
                                .Equals(answer.ToLower()))
                            {
                                return new Tuple<AnswerType, string> 
                                    (AnswerType.Correct, answer);
                            }
                            break;
                        case CodingType.Encoding:
                             answer =
                                 caesar.Encode(currentQuestion.Description.Description);

                            if (currentQuestion.Answer.Answer.ToLower()
                                .Equals(answer.ToLower()))
                            {
                                return new Tuple<AnswerType, string>
                                    (AnswerType.Correct, answer);
                            }
                            break;
                    }
                    break;

                case EncodingType.Trithemius:
                    IAlphabetEncoder trithem = EncoderFactory
                       .CreateEncoder(EncodingType.Caesar)
                        .SetMonoAlphabet(ENG_ALPHA)
                         .Configure(args);
                    break;
                case EncodingType.Vigenere:
                    IAlphabetEncoder vigener = EncoderFactory
                          .CreateEncoder(EncodingType.Vigenere)
                         .Configure(args);
                    switch (currentQuestion.CodingType)
                    {
                        case CodingType.Decoding:
                            //TODO Decode
                            answer =
                               vigener.Encode(currentQuestion.Description.Description);

                            if (currentQuestion.Answer.Answer.ToLower()
                                .Equals(answer.ToLower()))
                            {
                                return new Tuple<AnswerType, string>
                                    (AnswerType.Correct, answer);
                            }
                            break;
                        case CodingType.Encoding:
                            answer =
                                vigener.Encode(currentQuestion.Description.Description);

                            if (currentQuestion.Answer.Answer.ToLower()
                                .Equals(answer.ToLower()))
                            {
                                return new Tuple<AnswerType, string>
                                    (AnswerType.Correct, answer);
                            }
                            break;
                    }
                    break;

            }

            return new Tuple<AnswerType, string>
                                    (AnswerType.NotCorrect, answer);
        }
    }
}
