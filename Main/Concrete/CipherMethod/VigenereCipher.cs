using Cryptology.Abstract;
using Cryptology.Constant;

namespace Cryptology.Concrete.CipherMethod
{
    public class VigenereCipher : IEncryptionMethod
    {
        readonly string _key = "abc";

        /// <summary>
        ///     Ceaser Enc message
        /// </summary>
        /// <param name="messsage">unencrypted message</param>
        /// <returns>encrypted message string</returns>
        public string Encryption(string messsage)
        {
            string encrypted = string.Empty;
            var keyCount = 0;
            for (int i = 0; i < messsage.Length; i++)
            {
                var unencryptedChar = Helper.GetOrderOfAlphabetForChar(messsage[i]);
                var keyChar = -1;
                keyChar = Helper.GetOrderOfAlphabetForChar(_key[keyCount]);
                if (unencryptedChar != -1 && keyChar != -1)
                {
                    var formula = (unencryptedChar + keyChar) % 26;
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

                if (keyCount == 2)
                {
                    keyCount = 0;
                }
                else
                {
                    keyCount++;
                }
            }
            return encrypted;
        }
    }
}
