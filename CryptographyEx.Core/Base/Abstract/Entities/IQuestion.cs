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

    public interface IDiffiHelmanQuestion : IQuestionValue
    {
        int N { get; set; }
        int Q { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }

    public interface IElgamalQuestion : IQuestionValue
    {
        int P { get; set; }
        int A { get; set; }
        int B { get; set; }
        int R { get; set; }
    }

    public interface IAnswerValue
    {
        string Answer { get; set; }
    }
}
