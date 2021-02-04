using Cryptology.Constant;
using System;
using System.Linq;

namespace Cryptology.Concrete
{
    public static class Helper
    {
        /// <summary>
        ///     generate random string
        /// </summary>
        /// <param name="size">string size</param>
        /// <param name="_chars">chars</param>
        /// <returns>string</returns>
        public static string RandomString(int size, string _chars)
        {
            Random random = new Random();
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[random.Next(_chars.Length)];
                while (buffer.Where(x => x == buffer[i]).Count() > 1)
                {
                    buffer[i] = _chars[random.Next(_chars.Length)];
                }
            }
            return new string(buffer);
        }

        /// <summary>
        ///     Get order of alphaber
        /// </summary>
        /// <param name="_char">char</param>
        /// <returns>int order</returns>
        public static int GetOrderOfAlphabetForChar(Char _char)
        {
            int result = -1;
            for (int x = 0; x < HelperConstant.Alphabet.Length; x++)
            {
                if (_char == HelperConstant.Alphabet[x])
                {
                    result = x;
                }
            }
            return result;
        }
    }
}
