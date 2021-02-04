using Cryptology.Abstract;
using System;

namespace Cryptology.Concrete.GetMessageMethod
{
    public class GetMessageForConsole : IGetMessage
    {
        /// <summary>
        ///  Get console message 
        /// </summary>
        /// <returns>string message</returns>
        public string GetMessage()
        {
            Console.WriteLine("Your Message");
            var message = Console.ReadLine().Trim();
            Console.WriteLine();
            while (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("message not be empty or null");
                message = Console.ReadLine().Trim();
                Console.WriteLine();
            }
            message = message.ToLower();
            return message;
        }
    }
}
