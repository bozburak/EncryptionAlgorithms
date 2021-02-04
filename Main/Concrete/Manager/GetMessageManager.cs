using Cryptology.Abstract;
using Cryptology.Concrete.Factory;

namespace Cryptology.Concrete.Manager
{
    static class GetMessageManager
    {
        /// <summary>
        ///     get message
        /// </summary>
        /// <returns>string message</returns>
        public static string GetMessage()
        {
            IGetMessage instance = GetMessageFactory.GetMessage();
            return instance.GetMessage();
        }
    }
}
