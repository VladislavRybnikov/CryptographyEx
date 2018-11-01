using CryptographyEx.Theory.Abstract;
using CryptographyEx.Theory.Config;
using CryptographyEx.Theory.Entity;
using CryptographyEx.Theory.Entity.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyEx.Theory.Impl
{
    public class JsonParser : IJsonParser
    {

        public DataResult<TheorysByCript> TheorysByCript(string path=null)
        {
            DataResult<TheorysByCript> methodResult =
                new DataResult<TheorysByCript>();

            Result validateResult = ValidatePath(path);

            if(!validateResult.Success)
            {
                path = TheotyCriptConfig.NameFile;
            }
            TheorysByCript theorysByCript;

            try
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    using (StreamReader reader =
                        new StreamReader(stream))
                    {
                        theorysByCript = JsonConvert
                            .DeserializeObject<TheorysByCript>
                            (reader.ReadToEnd());
                    }
                }
                methodResult.Data = theorysByCript;
                methodResult.Success = true;

                return methodResult;
            }
            catch(JsonException e)
            {
                methodResult.Message = e.Message;

                return methodResult;
            }
            throw new NotImplementedException();
        }

        private Result ValidatePath(string path)
        {
            Result methodResult = new Result();

            if (path==null || !File.Exists(path))
            {
                methodResult.Success = false;

                return methodResult;
            }

            if(!Path.GetExtension(path).Equals(TheotyCriptConfig.ExtensionJson))
            {
                methodResult.Success = false;

                return methodResult;
            }
            methodResult.Success = true;

            return methodResult;
        }
    }
}
