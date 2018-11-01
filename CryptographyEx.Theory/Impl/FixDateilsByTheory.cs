using CryptographyEx.Core.Base.Const;
using CryptographyEx.Theory.Abstract;
using CryptographyEx.Theory.Config;
using CryptographyEx.Theory.Entity;
using CryptographyEx.Theory.Entity.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Impl
{
    public class FixDateilsByTheory : IFixDateilsByTheory
    {
        private readonly JsonParser _jsonParser;
        public FixDateilsByTheory()
        {
            _jsonParser = new JsonParser();
        }
        public Result FixTheory(TheorysByCript theorysBy)
        {
            throw new NotImplementedException();
        }

        public DataResult<TheoryEntity> GetTheory(EncodingType encodingType)
        {
            DataResult<TheoryEntity> methodResult = new DataResult<TheoryEntity>();

           DataResult<TheorysByCript> dataResult =
                _jsonParser.TheorysByCript();

            if(!dataResult.Success)
            {
                methodResult.Message = dataResult.Message;

                return methodResult;
            }

            foreach(var theor in dataResult.Data.TheoryEntitys)
            {
                if(theor.EncodingType!= encodingType)
                {
                    continue;
                }
                if (theor.Title != null)
                {
                    if (theor.Title.FontSize < 2)
                    {
                        theor.Title.FontSize = TheotyStandartConfig.TitleFontSize;
                    }
                    if(theor.Title.Color==null)
                    {
                        theor.Title.Color = TheotyStandartConfig.Color;
                    }
                   
                }

                if(theor.TheoryTextByImages!=null && theor.TheoryTextByImages.Any())
                {
                    foreach(var textByImage in theor.TheoryTextByImages)
                    {
                        if(textByImage.TheoryTextEntity!=null)
                        {
                            if (textByImage.TheoryTextEntity.FontSize < 2)
                            {
                                textByImage.TheoryTextEntity.FontSize = TheotyStandartConfig.TitleFontSize;
                            }
                            if (theor.Title.Color == null)
                            {
                                textByImage.TheoryTextEntity.Color = TheotyStandartConfig.Color;
                            }
                        }
                        if(textByImage.TheoryImageEntity!=null)
                        {
                            if (!File.Exists(textByImage.TheoryImageEntity.Path))
                            {
                                textByImage.TheoryImageEntity = null;

                                if (textByImage.TheoryTextEntity != null)
                                {
                                    textByImage.TheoryTextEntity.HorisontalAligment =
                                        Enum.HorisontalAligment.Center;
                                }
                            }
                            else
                            {
                                if (textByImage.TheoryImageEntity.Size == null)
                                {
                                    textByImage.TheoryImageEntity.Size = TheotyStandartConfig.ImageSize;
                                }
                                if (
                                    textByImage.TheoryImageEntity.HorisontalAligment
                                    ==Enum.HorisontalAligment.Center && textByImage.TheoryTextEntity!=null)
                                {
                                    textByImage.TheoryImageEntity.HorisontalAligment
                                  = Enum.HorisontalAligment.Left;
                                    textByImage.TheoryTextEntity.HorisontalAligment =
                                  Enum.HorisontalAligment.Right;
                                }
                                if (textByImage.TheoryTextEntity!=null 
                                    && textByImage.TheoryTextEntity.HorisontalAligment==
                                    textByImage.TheoryImageEntity.HorisontalAligment)
                                {
                                    textByImage.TheoryImageEntity.HorisontalAligment
                                = Enum.HorisontalAligment.Left;
                                    textByImage.TheoryTextEntity.HorisontalAligment =
                                  Enum.HorisontalAligment.Right;
                                }
                            }
                        }
                    }
                }

                methodResult.Success = true;
                methodResult.Data = theor;

                return methodResult;
            }

            return methodResult;
        }
    }
}
