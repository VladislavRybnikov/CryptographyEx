using CryptographyEx.Theory.Entity;
using CryptographyEx.Theory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Config
{
    public static class TheotyStandartConfig
    {
        public static int TitleFontSize { get; } = 22;

        public static int TextFontSize { get; } = 16;

        public static HorisontalAligment TitleHorisontalAligment
        { get; } = HorisontalAligment.Center;

        public static HorisontalAligment TextHorisontalAligment
        { get; } = HorisontalAligment.Left;

        public static Color Color { get; } = new Color() { R=255,G=255,B=255 };

        public static Size ImageSize { get; set; } = new Size { Width = 124, Heght = 124 };
    }
}
