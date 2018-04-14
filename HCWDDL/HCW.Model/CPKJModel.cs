using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCW.Model
{
    public class CPKJModel
    {
        public string GetWeekName(DateTime? dt)
        {
            //获取日期对应的星期
            if (dt.HasValue)
            {
                DateTime date = dt.Value;
                int n = (int)date.DayOfWeek;
                string[] weekDays = { "周日", "周一", "周二", "周三", "周四", "周五", "周六" };
                return weekDays[n];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获取显示奖池金额
        /// </summary>
        /// <param name="strMoney"></param>
        /// <returns></returns>
        public double GetJCMoney(string strMoney)
        {
            if (string.IsNullOrEmpty(strMoney))
            {
                return 0;
            }
            else
            {
                return double.Parse(strMoney);
            }
        }
    }
}
