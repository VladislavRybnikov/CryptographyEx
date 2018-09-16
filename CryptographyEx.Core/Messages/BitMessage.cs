using CryptographyEx.Core.Base.Structures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyEx.Core.Messages
{
    public class BitMessage : IEnumerable<Bit>
    {
        private Bit[] _bits { get; }

        public Bit this[int index]
        {
            get
            {
                return _bits[index];
            }
        }

        public BitMessage(bool[] array)
        {
            if (array.Length != 64)
            {
                throw new ArgumentException("Invalid bool array." +
                    " Length are less then 64.");
            }

            _bits = array.Select(x => new Bit(x)).ToArray();
        }

        public BitMessage(Bit[] bits)
        {
            _bits = bits;
        }

        public BitArray ToBitArray()
        {
            return new BitArray(_bits.Select(x => x.BoolValue).ToArray());
        }


        public BitMessage XOR(BitMessage bitMessage)
        {
            List<Bit> bits = new List<Bit>();

            for (int i = 0; i < this.Count(); i++)
            {
                bits.Add(this[i] ^ bitMessage[i]);   
            }

            return new BitMessage(bits.ToArray());
        }

        public static BitMessage operator ^(BitMessage first,
            BitMessage second)
        {
            return first ^ second;
        }

        public static BitMessage Parse(String fromString) 
            => new BitMessage(String.Concat(fromString.Select(x =>                                                                  
            {
                var charBinary = Convert.ToString(x, 2);

                while (charBinary.Length < Bit.SizeOfChar)
                    charBinary = "0" + charBinary;

                return charBinary;

            })).Select(x => Bit.Parse(x))
                .ToArray());

        public string ToBinaryString()
        {
            return String.Concat(this.Select(x => x.NumValue));
        }

        public override string ToString()
        {
            string input = ToBinaryString();
            StringBuilder sb = new StringBuilder();

            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, Bit.SizeOfChar);
                input = input.Remove(0, Bit.SizeOfChar);

                int a = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                sb.Append((char)a).ToString();
            }

            return sb.ToString();
        }

        public IEnumerator<Bit> GetEnumerator()
        {
            foreach (var b in _bits)
            {
                yield return b;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
