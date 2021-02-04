using Cryptology.Abstract;
using Cryptology.Constant;
using System.Collections.Generic;
using System.Linq;

namespace Cryptology.Concrete.CipherMethod
{
    public class SubstitutionCipher : IEncryptionMethod
    {
        readonly List<KeyValuePair<char, char>> randomList = new List<KeyValuePair<char, char>>();

        public SubstitutionCipher()
        {
            string randomAlpha = Helper.RandomString(26, HelperConstant.Alphabet);
            for (int i = 0; i < HelperConstant.Alphabet.Length; i++)
            {
                randomList.Add(new KeyValuePair<char, char>(HelperConstant.Alphabet[i], randomAlpha[i]));
            }
        }

        /// <summary>
        ///     Substitution Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;
            foreach (var item in messsage)
            {
                encrypted += randomList.Where(x => x.Key == item).FirstOrDefault().Value;
            }
            return encrypted;
        }
    }
}
