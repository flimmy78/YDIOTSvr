using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.YDIOTSvrUtil
{
    //工具类
    public class ByteUtils
    {
        protected long BCDtoDec(byte[] Data, int start, int leng)
        {
            long num = 0;
            if (Data != null && start > 0 && leng > 0 && start + leng < Data.Length)
            {
                for (int i = 0; i < leng; i++)
                {
                    num = num * 10 + Data[start + i] / 16;
                    num = num * 10 + Data[start + i] % 16;
                }
            }
            return num;
        }

        protected long BCDLowHightoDec(byte[] Data, int start, int leng)
        {
            long num = 0;
            if (Data != null && start > 0 && leng > 0 && start + leng < Data.Length)
            {
                for (int i = leng - 1; i >= 0; i--)
                {
                    num = num * 10 + Data[start + i] / 16;
                    num = num * 10 + Data[start + i] % 16;
                }
            }
            return num;
        }

        protected string BCDtoString(byte[] Data, int start, int leng)
        {
            string num = "";
            if (Data != null && start > 0 && leng > 0 && start + leng < Data.Length)
            {
                for (int i = 0; i < leng; i++)
                {
                    num += (Data[start + i] / 16).ToString();
                    num += (Data[start + i] % 16).ToString();
                }
            }
            return num;
        }

        protected string BCDLowHightoString(byte[] Data, int start, int leng)
        {
            string num = "";
            if (Data != null && start > 0 && leng > 0 && start + leng < Data.Length)
            {
                for (int i = leng - 1; i >= 0; i--)
                {
                    num += (Data[start + i] / 16).ToString();
                    num += (Data[start + i] % 16).ToString();
                }
            }
            return num;
        }
        protected long BinToDec(byte[] Data, int start, int leng)
        {
            long num = 0;
            if (Data != null && start > 0 && leng > 0 && start + leng < Data.Length)
            {
                for (int i = 0; i < leng; i++)
                {
                    num = num * 256 + Data[start + i];
                }
            }
            return num;
        }


        public static bool ByteArrayEquals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length)
                return false;
            if (b1 == null || b2 == null)
                return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 比较前两位是否一致
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static bool ByteArrayEquals2(byte[] b1, byte[] b2)
        {
            if (b1.Length < 2 || b2.Length < 2)
                return false;
            for (int i = 0; i < 2; i++)
            {
                if (b1[i] != b2[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 把byte数组变成10进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static String GetStringFromByteArray(byte[] bytes)
        {
            String str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str = str + bytes[i] + " ";
            }
            return str;
        }

    }
}
