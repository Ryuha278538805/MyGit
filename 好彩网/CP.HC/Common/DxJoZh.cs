using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DxJoZh
    {

        public static string Daxiao(int i)
        {
            if (i < 5)
                return "小";
            else
                return "大";
        }

        public static string DaxiaoStr(int i)
        {
            return i.ToString().Replace("1", "小").Replace("5","大");            
        }

        public static string Jiou(int i)
        {
            if (i%2 ==0)
                return "偶";
            else
                return "奇";
        }

        public static string JiouStr(int i)
        {
            return i.ToString().Replace("3", "奇").Replace("4", "偶");
        }

        public static string Zhihe(int i)
        {
            if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7)
                return "质";
            else
                return "合";
        }

        public static string ZhiheStr(int i)
        {
            return i.ToString().Replace("7", "质").Replace("8", "合");
        }

        public static string Zu(int i)
        {
            if (i == 1)
                return "豹子";
            else if (i == 3)
                return "组三";
            else
                return "组六";
        }

        public static int Kuadu(int a,int b,int c)
        {
            int kd = System.Math.Abs(a - b);
            if (kd < System.Math.Abs(a - c))    kd = System.Math.Abs(a - c);
            if (kd < System.Math.Abs(b - c)) kd = System.Math.Abs(b - c);
            return kd;
        }


    }
}
