using Cryptology.Abstract;

namespace Cryptology.Concrete.GetMessageMethod
{
    public class GetMessageForAppConfig : IGetMessage
    {
        /// <summary>
        /// get appconfig message
        /// </summary>
        /// <returns>string message</returns>
        public string GetMessage()
        {
            return System.Configuration.ConfigurationManager.AppSettings["exampleMessage"].ToString();
        }
    }
}
