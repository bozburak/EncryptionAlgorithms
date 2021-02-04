using Cryptology.Abstract;
using System;

namespace Cryptology.Concrete.Factory
{
    static class CipherFactory
    {
        static IEncryptionMethod _cipherMethod;

        /// <summary>
        /// create enc method instance 
        /// </summary>
        /// <returns>object</returns>
        internal static IEncryptionMethod EncryptionMethod()
        {
            if (_cipherMethod == null)
            {
                string locationTypeName = System.Configuration.ConfigurationManager.AppSettings["ciphermethodclass"].ToString();
                Type type = Type.GetType(locationTypeName);
                _cipherMethod = (IEncryptionMethod)Activator.CreateInstance(type);
            }
            return _cipherMethod;
        }
    }
}
