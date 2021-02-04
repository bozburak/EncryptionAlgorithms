using Cryptology.Abstract;
using Cryptology.Concrete.Factory;

namespace Cryptology.Concrete.Manager
{
    static class CipherManager
    {
        /// <summary>
        /// invoke enc method
        /// </summary>
        /// <param name="message">unencr message</param>
        /// <returns>enc message</returns>
        public static string Encryption(string message)
        {
            IEncryptionMethod instance = CipherFactory.EncryptionMethod();
            return instance.Encryption(message);
        }
    }
}
