using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract.Entities
{
    public interface IResultTest
    {
        bool Success { get; set; }
        string Message { get; set; }
        int CountCorectAnswer { get; set; }
        int CountQuestions { get; set; }
    }
}
