using Cryptology.Concrete;
using Cryptology.Concrete.Manager;
using System;

namespace Cryptology
{
    class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("- Cryptology Algorithm -");
            Console.WriteLine();
            var message = GetMessageManager.GetMessage();
            Processor processor = new Processor();
            processor.Process(message);
        }
    }
}