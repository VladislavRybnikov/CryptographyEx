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

            List<QuestionByTesting> questionByTr =
            GetQuestinByTrithemius();

            Testings.Add(EncodingType.Trithemius, questionByTestings);

            List<QuestionByTesting> questinByDiffiHelman
                = GetQuestinByDiffiHelman();
            Testings.Add(EncodingType.DiffiHelman, questinByDiffiHelman);

            
            List<QuestionByTesting> questionByTestingsElgamal =
                GetQuestinByElgamal();
            Testings.Add(EncodingType.Elgamal, questionByTestingsElgamal);
            
            

        }
        
        private static List<QuestionByTesting> GetQuestinByElgamal()
        {
            List<QuestionByTesting> questionByTestings = new List<QuestionByTesting>();
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Для чого використовується алгоритм Ель-Гамаль?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Для провірки цілісності передачі повідомлення" },
                    {2,"Для шифрування/дешифрування повідомлень" },
                    {3,"Для генерації псевдовипадкових чисел" }
                },
                Answer = 2,
                EncodingType = EncodingType.Elgamal,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Ключ - це інформація, яка використовується для",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Для шифрування текстів" },
                    {2,"Для дешифрування текстів" },
                    {3,"Для шифрування і дешифрування текстів" }
                },
                Answer = 3,
                EncodingType = EncodingType.Elgamal,
                AnswerType = AnswerType.Defoult
            });

            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Для алгоритма Ель-Гамаль в формулі відкритого ключа b = a^x mod P закритим ключем являється?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"х (0<x<P)" },
                    {2,"a (0<a<P)" },
                    {3,"P (0<P<a)" }
                },
                Answer = 1,
                EncodingType = EncodingType.Elgamal,
                AnswerType = AnswerType.Defoult
            });

            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Якщо відкриті ключі двох абонентів в алгориті Діффі-Хеллман" +
                "а g^x mod n и g^y mod n відповідно, то секретний ключ дорівнює",
                Questions = new Dictionary<int, string>()
                {
                    {1,"g^(x+y) mod n" },
                    {2,"g^(xy) mod n" },
                    {3,"g^(ln xy)mod n" }
                },
                Answer = 2,
                EncodingType = EncodingType.Elgamal,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Якщо відкриті ключі двох абонентів в алгориті Діффі-Хеллман" +
                "а g^x mod n и g^y mod n відповідно, то секретний ключ дорівнює",
                Questions = new Dictionary<int, string>()
                {
                    {1,"g^(x+y) mod n" },
                    {2,"g^(xy) mod n" },
                    {3,"g^(ln xy)mod n" }
                },
                Answer = 2,
                EncodingType = EncodingType.Elgamal,
                AnswerType = AnswerType.Defoult
            });


            return questionByTestings;
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

        private static List<QuestionByTesting> GetQuestinByTrithemius()
        {
            List<QuestionByTesting> questionByTestings =
               new List<QuestionByTesting>();
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Що оприділяє криптостійкість даної системи?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Стійкість до дешифрування" },
                    {2,"Стійкість до шифрування" },
                    {3,"Стійкість ключа" },

                },
                Answer = 1,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult
                
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Що являється секретною частиною даної криптосистеми?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Алгоритм" },
                    {2,"Ключ" },
                    {3,"Ключ і алгоритм" },

                },
                Answer = 2,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яким чином в шифрі Тритеміуса задається крок зміщення?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Гама" },
                    {2,"ПСЧ" },
                    {3,"Функція і текст" },

                },
                Answer = 3,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "У чому різниця шифра Тритеміуса і шифра Цезаря?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Різні ключі" },
                    {2,"Шаг зміщення" },
                    {3,"Різний алгоритм" },

                },
                Answer = 2,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яким являється крок у даній системі шифрування?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Змінним" },
                    {2,"Постійним" },
                    {3,"Його немає взагалі" },

                },
                Answer = 1,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Чим оприділяється стійкість даного шифра?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Таємністю ключа" },
                    {2,"Таємністю алгоритма" },
                    {3,"Нічим" },

                },
                Answer = 1,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яка основна мета шифрування?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Висока криптостійкість" },
                    {2,"Простота шифрування" },
                    {3,"Простота дешифрування" },

                },
                Answer = 1,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яку головну функцію виконує криптографія?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Захист інформації від несанкційного доступу" },
                    {2,"Перетворення тексту" },
                    {3,"Вибір ключа" },

                },
                Answer = 1,
                EncodingType = EncodingType.Trithemius,
                AnswerType = AnswerType.Defoult

            });


            return questionByTestings;
        }

        private static List<QuestionByTesting> GetQuestinByDiffiHelman()
        {
            List<QuestionByTesting> questionByTestings 
                = new List<QuestionByTesting>();

            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Для чого використовується алгоритм Diffie-Hellman?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Шифрування повідомлень" },
                    {2,"Обмін таємним ключом" },
                    {3,"Два варіанти" }
                },
                Answer = 2,
                EncodingType = EncodingType.DiffiHelman,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яким необхідно обрати чисо n?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Комплексне число" },
                    {2,"Велике просте число" },
                    {3,"Можливі два варіанти" }
                },
                Answer = 2,
                EncodingType = EncodingType.DiffiHelman,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яким необхідно обрати чисо g?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"Будь-яке g, яке являється примітивом mod n" },
                    {2,"Будь-яке число" },
                    {3,"Тільки великі прості числа" }
                },
                Answer = 1,
                EncodingType = EncodingType.DiffiHelman,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яке число найбільшим чином впливає на безпеку шифру?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"x" },
                    {2,"g" },
                    {3,"n" }
                },
                Answer = 3,
                EncodingType = EncodingType.DiffiHelman,
                AnswerType = AnswerType.Defoult
            });
            questionByTestings.Add(new QuestionByTesting()
            {
                Description = "Яка умова вибору числа n?",
                Questions = new Dictionary<int, string>()
                {
                    {1,"n - велике просте число" },
                    {2,"(n-1)/2 - просте число" },
                    {3,"Два варіанти" }
                },
                Answer = 3,
                EncodingType = EncodingType.DiffiHelman,
                AnswerType = AnswerType.Defoult
            });


            return questionByTestings;
        }
    }
}
