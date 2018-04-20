using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class MD5
    {
        /// <param name="sDataIn">需要加密的字符串</param>
        /// <param name="move">偏移量</param>
        /// <returns>sDataIn加密后的字符串</returns>
        public static string GetMD5(string sDataIn, string move)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(move + sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("x").PadLeft(2, '0');
            }
            return sTemp;
        }

        /// <summary>
        /// MD5加密，小写
        /// </summary>
        /// <param name="toCryString"></param>
        /// <returns></returns>
        public static string GetMD5Smple(string toCryString)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider hashmd5;
            hashmd5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            return BitConverter.ToString(hashmd5.ComputeHash(Encoding.Default.GetBytes(toCryString))).Replace("-", "").ToUpper();//把所有字符变小写
        }

    }
}
