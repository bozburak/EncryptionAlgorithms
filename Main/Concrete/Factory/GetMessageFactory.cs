using Cryptology.Abstract;
using System;

namespace Cryptology.Concrete.Factory
{
    static class GetMessageFactory
    {
        static IGetMessage _getMessage;

        /// <summary>
        /// create getmessage instance 
        /// </summary>
        /// <returns>object</returns>
        internal static IGetMessage GetMessage()
        {
            if (_getMessage == null)
            {
                string locationTypeName = System.Configuration.ConfigurationManager.AppSettings["getnessageclass"].ToString();
                Type type = Type.GetType(locationTypeName);
                _getMessage = (IGetMessage)Activator.CreateInstance(type);
            }
            return _getMessage;
        }
    }
}
