using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract.Entities
{
    public interface IQuestion
    {
        IQuestionValue Description { get; set; }

        IAnswerValue Answer { get; set; }

       // AnswerType AnswerType { get; set; }

        CodingType CodingType { get; set; }

        EncodingType EncodingType { get; set; }
    }

    public interface IQuestionValue
    {
        string Description { get; set; }
    }

    public interface IAnswerValue
    {
        string Answer { get; set; }
    }
}
