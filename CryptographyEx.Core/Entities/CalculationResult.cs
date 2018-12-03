using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Entities
{
    public class CalculationResult
    {
        public string Encoded { get; set; }
        public List<string> CalculationsPipeline { get; private set; }

        public CalculationResult()
        {
            CalculationsPipeline = new List<string>();
        }

    }
}
