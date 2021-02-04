using Cryptology.Abstract;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptology.Concrete.CipherMethod
{
    public class RSACipher : IEncryptionMethod
    {
        private readonly string _publicKey = @"<RSAKeyValue><Modulus>MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC2npbaYJLx/gLigSN69DsxnOod
        tcdopmKF/EfzlL4KrdtzVLE5AcLKb8NlKkSGdQFcEG/HvIeBey3ioFG8+uF36iqb
        gAZ2KA0OCzJ+4Yc/2ASisY8hn05lglNLOEFC6Jr7KNkXgxj75K9ZZ+EyMcDMX1ye
        vCzudNrKmEe9hlJt2QIDAQAB</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        /// <summary>
        ///     RSA Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;
            var testData = Encoding.UTF8.GetBytes(messsage);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.FromXmlString(_publicKey);
                var encryptedData = rsa.Encrypt(testData, true);
                encrypted = Convert.ToBase64String(encryptedData);
            }
            return encrypted;
        }
    }
}
