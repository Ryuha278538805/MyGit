using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Base62
    {
        private static string Alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string Encoding(ulong num)
        {
            if (num < 1)
                throw new Exception("num must be greater than 0.");

            StringBuilder sb = new StringBuilder();
            for (; num > 0; num /= 62)
            {
                sb.Append(Alphabet[(int)(num % 62)]);
            }
            return sb.ToString();
        }

        public static ulong Decoding(string str)
        {
            str = str.Trim();
            if (str.Length < 1)
                throw new Exception("str must not be empty.");

            ulong result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += (ulong)(Alphabet.IndexOf(str[i]) * Math.Pow(62, i));
            }
            return result;
        }
    }
}
