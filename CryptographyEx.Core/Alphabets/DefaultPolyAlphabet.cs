using CryptographyEx.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Alphabets
{
    public class DefaultPolyAlphabet : IPolyAlphabet
    {
        public char[][] Value { get; set; }

        public int Width => Value.GetLength(0);

        public int Height => Width;

        public DefaultPolyAlphabet(char[][] alpha)
        {
            Value = alpha;
        }

        public bool Contains(char element)
        {
            bool contain = false;

            foreach (var c in Value)
            {
                foreach(var b in c)
                {
                    if (b == element)
                    {
                        contain = true;
                        break;
                    }
                }
                
            }

            return contain;
        }

        public char Get(int x, int y)
        {
            if (x >= Width || y >= Height)
            {
                throw new Exception("Wrong args");
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (x == i && y == j)
                    {
                        return Value[i][j];
                    }
                }
            }

            throw new Exception("No found");
        }
    }
}
