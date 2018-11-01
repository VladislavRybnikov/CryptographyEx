using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Entity
{
    public class TheoryEntity
    {
        public EncodingType EncodingType { get; set; }

        public TheoryTextEntity Title { get; set; }

        public List<TheoryTextByImageEntity> TheoryTextByImages { get; set; }
    }
}
