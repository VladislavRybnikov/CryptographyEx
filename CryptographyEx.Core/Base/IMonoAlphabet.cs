using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base
{
    public interface IMonoAlphabet
    {
        char[] Value { get; }
        int Length { get; }

    }
}
