using CryptographyEx.Core.Base.Const;
using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Holder
{
    public static class QuestionByTestingHolder
    {
        public static Dictionary<EncodingType, List<QuestionByTesting>> Testings { get; set; }

        static QuestionByTestingHolder()
        {
            Testings = new Dictionary<EncodingType, List<QuestionByTesting>>();
            Init();
        }

        public static void UpdateResult()
        {
            foreach(var item in Testings)
            {
                item.Value.ForEach(p => p.AnswerType = AnswerType.Defoult);
            }
        }

        public static List<QuestionByTesting> GetQuestionByTestings(EncodingType encodingType)
        {
            if(Testings.ContainsKey(encodingType))
            {
                return Testings[encodingType];
            }

            return new List<QuestionByTesting>();
        }

        private static void Init()
        {
            List<QuestionByTesting> questionByTestings =
              GetQuestinByCaesar();

            Testings.Add(EncodingType.Caesar, questionByTestings);
        }

        private static List<QuestionByTesting> GetQuestinByCaesar()
        {
            List<QuestionByTesting> questionByTestings =
               new List<QuestionByTesting>();

            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Підстановочні криптограми - це",
                Questions = new Dictionary<int, string>()
                {
                    {1, "заміна букв однієї мови буквами іншої мови" },
                    {2, "коли кожної букві алфавіта зпівсталяється певний символ чи буква" },
                    {3, "передстановка букв повідомлення по будь-якому правилу" }
                },
                Answer = 2,
                EncodingType = EncodingType.Caesar,
                AnswerType = AnswerType.Defoult
            });

              questionByTestings.Add(new QuestionByTesting()
              {
                  Description = "Зсув букв в шифрі Цезаря:",
                  Questions = new Dictionary<int, string>()
                {
                    {1, "залежить від лінійной, нелінійной функції" },
                    {2, "букви заміняються буквами поточного текста" },
                    {3, "постійне" }
                },
                  Answer = 3,
                  EncodingType = EncodingType.Caesar,
                  AnswerType = AnswerType.Defoult
              }

            );


            return questionByTestings;
        }
    }
}
