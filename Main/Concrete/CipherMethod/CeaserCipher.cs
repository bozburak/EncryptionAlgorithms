using Cryptology.Abstract;
using Cryptology.Constant;

namespace Cryptology.Concrete.CipherMethod
{
    public class CeaserCipher : IEncryptionMethod
    {
        readonly short _key = 2;

        /// <summary>
        ///     Ceaser Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;
            for (int i = 0; i < messsage.Length; i++)
            {
                var x = Helper.GetOrderOfAlphabetForChar(messsage[i]);
                if (x != -1)
                {
                    var formula = x + _key % 26;
                    if (formula >= HelperConstant.Alphabet.Length)
                    {
                        int outSideKey = HelperConstant.Alphabet.Length - formula;
                        encrypted += HelperConstant.Alphabet[outSideKey < 0 ? -outSideKey : outSideKey];
                    }
                    else
                    {
                        encrypted += HelperConstant.Alphabet[formula];
                    }
                }
            }
            return encrypted;
        }
    }
}
