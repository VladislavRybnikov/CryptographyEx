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
      //  public AnswerType AnswerType { get; set; }
       public CodingType CodingType { get; set; }
       public EncodingType EncodingType { get; set; }
    }

    public class QuestionValue : IQuestionValue
    {
        public string Description { get; set; }
    }

    public class AnswerValue : IAnswerValue
    {
        public string Answer { get; set; }
    }
}
