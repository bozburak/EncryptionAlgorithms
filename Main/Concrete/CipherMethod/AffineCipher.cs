using Cryptology.Abstract;
using Cryptology.Constant;

namespace Cryptology.Concrete.CipherMethod
{
    public class AffineCipher : IEncryptionMethod
    {
        readonly short _keyA = 3;
        readonly short _keyB = 2;

        /// <summary>
        ///     Affine Enc message
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
                    var formula = _keyA * x + _keyB;

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
