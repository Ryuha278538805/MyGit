using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class RandomNum
    {
        /// <summary>
        /// 产生一个固定长度的不重复随机数组
        /// </summary>
        /// <param name="count">数组长度</param>
        /// <param name="down">下限</param>
        /// <param name="up">上限</param>
        /// <returns></returns>
        public static int[] RandomList(int count, int down, int up)
        {
            int[] result = new int[count];
            Random ran = new Random();
            int tmp, icon;
            int i = 0;
            while(i<count)
            {
                tmp = ran.Next(down, up);
                //已经添加有随机数，进行对比，重复则不添加
                if (i > 0)
                {
                    icon = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (result[j] == tmp)
                        {
                            icon = 1;
                            break;
                        }
                    }
                    //随机数已经存在
                    if (icon == 1)
                        continue;
                    else
                    {
                        result[i++] = tmp;   //赋值后跳到下一个位置
                    }
                }
                else
                {
                    result[i++] = tmp;   //赋值后跳到下一个位置
                }
            }
            return result;
        }
    }
}
