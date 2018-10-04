using CryptographyEx.Core.Base.Abstract.Entities;
using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IMainPresentation
    {

        Tuple<AnswerType, string> CheckAnswer(IQuestion currentQuestion, params object[] args);

        IQuestionValue GenerateQuestion(CodingType codingType, EncodingType encodingType);
    }
}
