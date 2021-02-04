using Cryptology.Abstract;
using System;
using System.IO;
using System.Security.Cryptography;


namespace Cryptology.Concrete.CipherMethod
{
    public class DESCipher : IEncryptionMethod
    {
        /// <summary>
        ///     Des Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;

            using (var cryptoProvider = new DESCryptoServiceProvider())
            {
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cs))
                        {
                            writer.Write(messsage);
                            writer.Flush();
                            cs.FlushFinalBlock();
                            writer.Flush();
                            encrypted = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                        }
                    }
                }
            }

            return encrypted;
        }
    }
}
