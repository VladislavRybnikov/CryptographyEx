using CryptographyEx.Core.Base.Const;
using CryptographyEx.Theory.Entity;
using CryptographyEx.Theory.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Abstract
{
    public interface IFixDateilsByTheory
    {
        Result FixTheory(TheorysByCript theorysBy);
        DataResult<TheoryEntity> GetTheory(EncoderType encodingType);
    }
}
