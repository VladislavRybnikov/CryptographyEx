using CryptographyEx.Core.Base;
using CryptographyEx.Core.Base.Abstract;
using CryptographyEx.Core.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyEx.Core.Encoders
{
    public class DSAEncoder : IAlphabetEncoder
    {
        private string _key;
        private string _iv;
        private bool _configurated = false;

        public IAlphabetEncoder Configure(params object[] args)
        {
            try
            {
                _key = args[0].ToString();
                _iv = args[1].ToString();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Wrong arguments", ex);
            }

            _configurated = true;

            return this;
        }

        public string Decode(string message)
        {
            try
            {
                var tempStrs = message.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] b = new byte[tempStrs.Length];
                int i = 0;
                foreach (var str in tempStrs)
                {
                    b[i] = byte.Parse(str);
                    i++;
                }

                MemoryStream msDecrypt = new MemoryStream(b);

                DES DESalg = DES.Create();

                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    DESalg.CreateDecryptor(ASCIIEncoding.ASCII.GetBytes(_key), ASCIIEncoding.ASCII.GetBytes(_iv)),
                    CryptoStreamMode.Read);

                byte[] fromEncrypt = new byte[b.Length];

                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                return new ASCIIEncoding().GetString(fromEncrypt);
            }
            catch
            {
                return string.Empty;
            }

        }


        public string Encode(string message)
        {
            MemoryStream mStream = new MemoryStream();

            DES DESalg = DES.Create();

            CryptoStream cStream = new CryptoStream(mStream,
                DESalg.CreateEncryptor(ASCIIEncoding.ASCII.GetBytes(_key), ASCIIEncoding.ASCII.GetBytes(_iv)),
                CryptoStreamMode.Write);

            byte[] toEncrypt = new ASCIIEncoding().GetBytes(message);

            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();

            byte[] ret = mStream.ToArray();

            cStream.Close();
            mStream.Close();

            StringBuilder sb = new StringBuilder();

            foreach (var b in ret)
            {
                sb.Append(b + " ");
            }

            return sb.ToString();
        }


        public IAlphabetEncoder SetMonoAlphabet(IMonoAlphabet alphabet)
        {
            return this;
        }

        public IAlphabetEncoder SetPolyAplhabet(IPolyAlphabet alphabet)
        {
            return this;
        }
    }
}
