using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Structures
{
    public struct Bit
    {
        public static readonly int SizeOfChar = 16;

        public bool BoolValue { get;}

        public int NumValue { get; }

        public Bit(bool fromBool)
        {
            BoolValue = fromBool;
            NumValue = fromBool ? 1 : 0;
        }

        public Bit(int fromNumber)
        {
            NumValue = fromNumber;
            BoolValue = fromNumber == 1 ? true : false;
        }

        public Bit AddMod2(Bit bit)
        {
            return new Bit((bit.NumValue + this.NumValue) % 2);
        }

        public static Bit Parse(char c)
        {
            int x = (c == '0' || c == '1') ? Convert.ToInt32(c.ToString()) 
                : throw new ArgumentException();

            return new Bit(x);
        }

        public Bit XOR(Bit bit)
        {
            return new Bit(BoolValue ^ bit.BoolValue);
        }

        public static Bit operator ^(Bit a, Bit b)
        {
            return a.XOR(b);
        }

    }
}
