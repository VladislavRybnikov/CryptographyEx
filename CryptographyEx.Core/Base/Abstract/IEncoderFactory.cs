﻿using CryptographyEx.Core.Base.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IEncoderFactory
    {
        IAlphabetEncoder CreateEncoder(EncoderType encoding);
    }
}
