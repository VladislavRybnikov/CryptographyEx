using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Entity
{
    public class TheoryTextEntity : TheoryBaseEntity
    {
        public string Text { get; set; }
        public Color Color { get; set; }
        public int FontSize { get; set; }
    }
}
