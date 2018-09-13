using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IAlphabetEncoder : IBaseGenericEncoder<string>
    { 
        IAlphabetEncoder Configure(params object[] args);
        IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet);
        IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet);
    }
}
