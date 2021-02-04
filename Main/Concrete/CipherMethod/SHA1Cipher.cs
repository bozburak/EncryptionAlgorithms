using Cryptology.Abstract;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptology.Concrete.CipherMethod
{
    public class SHA1Cipher : IEncryptionMethod
    {
        /// <summary>
        ///     SHA1 Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;
            using (var sha = new SHA1CryptoServiceProvider())
            {
                encrypted = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(messsage)));
            }
            return encrypted;
        }
    }
}
