﻿using CryptographyEx.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptographyEx.Core.Base.Abstract
{
    public interface IBitEncoder : IBaseGenericEncoder<BitMessage>,
        IBaseGenericEncoder<string>, IAlphabetEncoder
    {
        IAlphabetEncoder Configure(params object[] args);
    }
}
