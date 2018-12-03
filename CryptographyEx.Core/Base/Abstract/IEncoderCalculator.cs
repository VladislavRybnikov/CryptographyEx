using CryptographyEx.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IEncoderCalculator
    {
        CalculationResult Calculate(string input);
    }
}
