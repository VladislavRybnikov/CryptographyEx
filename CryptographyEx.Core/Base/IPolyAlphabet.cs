using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base
{
    public interface IPolyAlphabet
    {
        char[][] Value { get; }
        int Width { get; }
        int Height { get; }

        bool Contains(char element);
        char Get(int x, int y);
    }
}
