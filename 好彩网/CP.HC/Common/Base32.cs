using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Base32
    {
        private const String DefaultBase32Map = "ABCDEFGHIJKLMNPQRSTUVWXYZ3456789";
        private const Int32 Base32MapLength = 32;
        private static Char[] m_acBase32Map = null;
        public static String Base32Map
        {
            get
            {
                return DefaultBase32Map.ToString();
            }
            set
            {
                if (value != null && value.Length >= Base32MapLength)
                {
                    m_acBase32Map = value.ToCharArray();
                }
                else
                {
                    m_acBase32Map = DefaultBase32Map.ToCharArray();
                }
            }
        }

        public static Int32 GetCharIndex(Char cData)
        {
            Int32 dwIndex = -1, dwLoop = 0;

            if (Base32Map != null)
            {
                for (dwLoop = 0; dwLoop < Base32Map.Length; dwLoop++)
                {
                    if (Base32Map[dwLoop] == cData)
                    {
                        dwIndex = dwLoop;
                        break;
                    }
                }
            }
            return dwIndex;
        }

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string Decode(string code)
        {
            return System.Text.Encoding.UTF8.GetString(Decodes(code));
        }

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="sData"></param>
        /// <returns></returns>
        private static Byte[] Decodes(String sData)
        {
            Int32 dwLoop = 0, dwLength = 0;
            Int32[] dwCharIndex = null;
            Byte[] abOutput = null;
            Char[] acInput = null;

            if (sData == null || sData == String.Empty)
                return null;

            acInput = sData.ToCharArray();
            if (acInput == null)
                return null;

            try
            {
                dwLength = (Int32)(acInput.Length / 8f * 5f) + 1;
                abOutput = new Byte[dwLength];
                dwCharIndex = new Int32[8];
            }
            catch (Exception e)
            {
                //Trace.WriteLine("CBase32.Decode: Initialize buffer failed! " + e.Message);
            }
            if (acInput == null)
                return null;

            dwLength = 0;
            for (dwLoop = 0; dwLoop < acInput.Length; dwLoop += 8)
            {
                Array.Clear(dwCharIndex, 0, dwCharIndex.Length);
                // 根据Encode计算，这里差值的长度只可能是2、4、5、7、8
                switch (acInput.Length - dwLoop)
                {
                    case 2:
                        dwCharIndex[0] = GetCharIndex(acInput[dwLoop]);
                        dwCharIndex[1] = GetCharIndex(acInput[dwLoop + 1]);

                        abOutput[dwLength] = (Byte)((dwCharIndex[0] << 3) + (dwCharIndex[1] >> 2));
                        abOutput[dwLength + 1] = (Byte)((dwCharIndex[1] & 0x3) << 6);
                        break;

                    case 4:
                        dwCharIndex[0] = GetCharIndex(acInput[dwLoop]);
                        dwCharIndex[1] = GetCharIndex(acInput[dwLoop + 1]);
                        dwCharIndex[2] = GetCharIndex(acInput[dwLoop + 2]);
                        dwCharIndex[3] = GetCharIndex(acInput[dwLoop + 3]);

                        abOutput[dwLength] = (Byte)((dwCharIndex[0] << 3) + (dwCharIndex[1] >> 2));
                        abOutput[dwLength + 1] = (Byte)(((dwCharIndex[1] & 0x3) << 6) + (dwCharIndex[2] << 1) + (dwCharIndex[3] >> 4));
                        abOutput[dwLength + 2] = (Byte)((dwCharIndex[3] & 0xF) << 4);
                        break;

                    case 5:
                        dwCharIndex[0] = GetCharIndex(acInput[dwLoop]);
                        dwCharIndex[1] = GetCharIndex(acInput[dwLoop + 1]);
                        dwCharIndex[2] = GetCharIndex(acInput[dwLoop + 2]);
                        dwCharIndex[3] = GetCharIndex(acInput[dwLoop + 3]);
                        dwCharIndex[4] = GetCharIndex(acInput[dwLoop + 4]);

                        abOutput[dwLength] = (Byte)((dwCharIndex[0] << 3) + (dwCharIndex[1] >> 2));
                        abOutput[dwLength + 1] = (Byte)(((dwCharIndex[1] & 0x3) << 6) + (dwCharIndex[2] << 1) + (dwCharIndex[3] >> 4));
                        abOutput[dwLength + 2] = (Byte)(((dwCharIndex[3] & 0xF) << 4) + (dwCharIndex[4] >> 1));
                        abOutput[dwLength + 3] = (Byte)(((dwCharIndex[4] & 0x1) << 7));
                        break;

                    case 7:
                        dwCharIndex[0] = GetCharIndex(acInput[dwLoop]);
                        dwCharIndex[1] = GetCharIndex(acInput[dwLoop + 1]);
                        dwCharIndex[2] = GetCharIndex(acInput[dwLoop + 2]);
                        dwCharIndex[3] = GetCharIndex(acInput[dwLoop + 3]);
                        dwCharIndex[4] = GetCharIndex(acInput[dwLoop + 4]);
                        dwCharIndex[5] = GetCharIndex(acInput[dwLoop + 5]);
                        dwCharIndex[6] = GetCharIndex(acInput[dwLoop + 6]);

                        abOutput[dwLength] = (Byte)((dwCharIndex[0] << 3) + (dwCharIndex[1] >> 2));
                        abOutput[dwLength + 1] = (Byte)(((dwCharIndex[1] & 0x3) << 6) + (dwCharIndex[2] << 1) + (dwCharIndex[3] >> 4));
                        abOutput[dwLength + 2] = (Byte)(((dwCharIndex[3] & 0xF) << 4) + (dwCharIndex[4] >> 1));
                        abOutput[dwLength + 3] = (Byte)(((dwCharIndex[4] & 0x1) << 7) + (dwCharIndex[5] << 2) + (dwCharIndex[6] >> 3));
                        abOutput[dwLength + 4] = (Byte)((dwCharIndex[6] & 0x7) << 5);
                        break;

                    default:
                        dwCharIndex[0] = GetCharIndex(acInput[dwLoop]);
                        dwCharIndex[1] = GetCharIndex(acInput[dwLoop + 1]);
                        dwCharIndex[2] = GetCharIndex(acInput[dwLoop + 2]);
                        dwCharIndex[3] = GetCharIndex(acInput[dwLoop + 3]);
                        dwCharIndex[4] = GetCharIndex(acInput[dwLoop + 4]);
                        dwCharIndex[5] = GetCharIndex(acInput[dwLoop + 5]);
                        dwCharIndex[6] = GetCharIndex(acInput[dwLoop + 6]);
                        dwCharIndex[7] = GetCharIndex(acInput[dwLoop + 7]);

                        abOutput[dwLength] = (Byte)((dwCharIndex[0] << 3) + (dwCharIndex[1] >> 2));
                        abOutput[dwLength + 1] = (Byte)(((dwCharIndex[1] & 0x3) << 6) + (dwCharIndex[2] << 1) + (dwCharIndex[3] >> 4));
                        abOutput[dwLength + 2] = (Byte)(((dwCharIndex[3] & 0xF) << 4) + (dwCharIndex[4] >> 1));
                        abOutput[dwLength + 3] = (Byte)(((dwCharIndex[4] & 0x1) << 7) + (dwCharIndex[5] << 2) + (dwCharIndex[6] >> 3));
                        abOutput[dwLength + 4] = (Byte)(((dwCharIndex[6] & 0x7) << 5) + dwCharIndex[7]);
                        break;
                }
                dwLength += 5;
            }

            return abOutput;
        }

        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encode(string str)
        {
            return Encode(System.Text.Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="abData"></param>
        /// <returns></returns>
        private static String Encode(Byte[] abData)
        {
            Int32 dwLoop = 0, dwCharIndex = 0, dwCharCount;
            Char[] acPart = null;
            StringBuilder sbOutput = null;

            if (abData == null || Base32Map == null || Base32Map.Length < Base32MapLength)
                return null;

            try
            {
                dwCharCount = (Int32)(abData.Length / 5f * 8f) + 1;
                sbOutput = new StringBuilder(dwCharCount);
                acPart = new Char[8];
            }
            catch (Exception e)
            {
               // Trace.WriteLine("CBase32.Encode: Initialize buffer failed! " + e.Message);
            }
            if (acPart == null || sbOutput == null)
                return null;

            dwCharCount = 0;
            for (dwLoop = 0; dwLoop < abData.Length; dwLoop += 5)
            {
                Array.Clear(acPart, 0, acPart.Length);
                // every 5 bytes is a unit,can convert to 8 chars
                // data format:
                //            AAAAABBB BBCCCCCD DDDDEEEE EFFFFFGG GGGHHHHH
                switch (abData.Length - dwLoop - 1)
                {
                    case 0: break;
                    case 1:
                        dwCharIndex = abData[dwLoop] >> 3;                // AAAAA
                        acPart[0] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop] & 0x7) << 2;        // BBB00
                        acPart[1] = Base32Map[dwCharIndex];
                        dwCharCount = 2;
                        break;

                    case 2:
                        dwCharIndex = abData[dwLoop] >> 3;                // AAAAA
                        acPart[0] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop] & 0x7) << 2) + (abData[dwLoop + 1] >> 6);    // BBBBB
                        acPart[1] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 1] & 0x3F) >> 1;    // CCCCC
                        acPart[2] = Base32Map[dwCharIndex];
                        dwCharIndex = abData[dwLoop + 1] & 0x1;            // D0000
                        acPart[3] = Base32Map[dwCharIndex];
                        dwCharCount = 4;
                        break;

                    case 3:
                        dwCharIndex = abData[dwLoop] >> 3;                // AAAAA
                        acPart[0] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop] & 0x7) << 2) + (abData[dwLoop + 1] >> 6);    // BBBBB
                        acPart[1] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 1] & 0x3F) >> 1;    // CCCCC
                        acPart[2] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 1] & 0x1) << 4) + (abData[dwLoop + 2] >> 4);// DDDDD
                        acPart[3] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 2] & 0xF) << 1;    // EEEE0
                        acPart[4] = Base32Map[dwCharIndex];
                        dwCharCount = 5;
                        break;

                    case 4:
                        dwCharIndex = abData[dwLoop] >> 3;                // AAAAA
                        acPart[0] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop] & 0x7) << 2) + (abData[dwLoop + 1] >> 6);    // BBBBB
                        acPart[1] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 1] & 0x3F) >> 1;    // CCCCC
                        acPart[2] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 1] & 0x1) << 4) + (abData[dwLoop + 2] >> 4);// DDDDD
                        acPart[3] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 2] & 0xF) << 1) + (abData[dwLoop + 3] >> 7);// EEEEE
                        acPart[4] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 3] & 0x7F) >> 2;    // FFFFF
                        acPart[5] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 3] & 0x3) << 3;    // GG000
                        acPart[6] = Base32Map[dwCharIndex];
                        dwCharCount = 7;
                        break;

                    default:        // >= 5
                        dwCharIndex = abData[dwLoop] >> 3;                // AAAAA
                        acPart[0] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop] & 0x7) << 2) + (abData[dwLoop + 1] >> 6);    // BBBBB
                        acPart[1] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 1] & 0x3F) >> 1;    // CCCCC
                        acPart[2] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 1] & 0x1) << 4) + (abData[dwLoop + 2] >> 4);// DDDDD
                        acPart[3] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 2] & 0xF) << 1) + (abData[dwLoop + 3] >> 7);// EEEEE
                        acPart[4] = Base32Map[dwCharIndex];
                        dwCharIndex = (abData[dwLoop + 3] & 0x7F) >> 2;    // FFFFF
                        acPart[5] = Base32Map[dwCharIndex];
                        dwCharIndex = ((abData[dwLoop + 3] & 0x3) << 3) + (abData[dwLoop + 4] >> 5);// GGGGG
                        acPart[6] = Base32Map[dwCharIndex];
                        dwCharIndex = abData[dwLoop + 4] & 0x1F;        // HHHHH
                        acPart[7] = Base32Map[dwCharIndex];
                        dwCharCount = 8;
                        break;
                }

                sbOutput.Append(acPart, 0, dwCharCount);
            }

            return sbOutput.ToString();
        }
    }
}
