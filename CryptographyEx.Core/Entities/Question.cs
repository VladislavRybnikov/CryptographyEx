using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Entities
{
    public class Question : IQuestion
    {
       public IQuestionValue Description { get; set; }
       public IAnswerValue Answer { get; set; }

       public CodingType CodingType { get; set; }
       public EncodingType EncodingType { get; set; }
    }

    public class QuestionByTesting
    {
        public string Description { get; set; }

        //public List<string> Questions { get; set; }

        public Dictionary<int,string> Questions { get; set; }
        public int Answer { get; set; }

        public AnswerType AnswerType { get; set; }

        public EncodingType EncodingType { get; set; }
    }

    public class QuestionValue : IQuestionValue
    {
        public string Description { get; set; }
    }

    public class DiffiHelmanQuestion : QuestionValue,IDiffiHelmanQuestion
    {
      public  int N { get; set; }
      public  int Q { get; set; }
      public  int X { get; set; }
      public  int Y { get; set; }
    }
    public class ElgamalQuestion : QuestionValue, IElgamalQuestion
    {
      public  int P { get; set; }
      public  int A { get; set; }
      public  int B { get; set; }
      public  int R { get; set; }
    }
    public class AnswerValue : IAnswerValue
    {
        public string Answer { get; set; }
    }
}
