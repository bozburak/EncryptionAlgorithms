using Cryptology.Abstract;
using Cryptology.Concrete.Manager;
using System;

namespace Cryptology
{
    public class Processor
    {
        string encryptionMessage;

        /// <summary>
        ///     start process
        /// </summary>
        /// <param name="message">unencrypted message</param>
        public void Process(string message)
        {
            encryptionMessage = CipherManager.Encryption(message);
            WriteEncryptedMessage();
        }

        /// <summary>
        ///     Return encryption message
        /// </summary>
        private void WriteEncryptedMessage()
        {
            Console.WriteLine("Encrypted Message");
            Console.WriteLine(encryptionMessage);
            Console.ReadLine();
        }
    }
}
