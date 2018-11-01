using CryptographyEx.Theory.Entity;
using CryptographyEx.Theory.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Abstract
{
    public interface IJsonParser
    {
        DataResult<TheorysByCript> TheorysByCript(string path = null);
    }
}
