using HCW.Common;
using HCW.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace HCW.Bussiness
{
    public class cpkjService
    {
        private DBHelper dbHelper = new DBHelper(DBHelper.CONN_KJ);
        private static int qitimespan = Int32.Parse(ConfigurationManager.AppSettings["cache_qi"]);

        /// <summary>
        /// 获取开奖信息
        /// </summary>
        /// <returns></returns>
        public T M_GetCPInfo<T>(string tbName, string qi = "") where T : new()
        {
            string sql = "SELECT TOP 1 * FROM  " + tbName + " {0} ORDER BY qi DESC";
            string where = " where 1=1 ";
            if (!string.IsNullOrEmpty(qi))
            {
                where += " and qi='" + qi + "' ";
            }
            sql = string.Format(sql, where);
            return dbHelper.GetEntity<T>(sql);
        }

        /// <summary>
        /// 获取开奖详情
        /// </summary>
        /// <returns></returns>
        public T M_GetCPDetail<T>(string tbName, int id) where T : new()
        {
            string sql = "SELECT * FROM  " + tbName + " {0} ";
            string where = " where id=" + id.ToString();
            sql = string.Format(sql, where);
            return dbHelper.GetEntity<T>(sql);
        }

        /// <summary>
        /// 获取开奖期字典
        /// </summary>
        /// <returns></returns>
        public IList<QiModel> M_GetCPqi(string tbName)
        {
            string cachename = tbName + "_qi";
            string sql = "SELECT id,qi FROM  " + tbName + " where year(date)>= " + (DateTime.Now.Year - 1).ToString() + " order by qi desc";
            IList<QiModel> lst = CacheHelper.GetCache<IList<QiModel>>(cachename);
            if (lst == null)
            {
                lst = dbHelper.GetList<QiModel>(sql);
                CacheHelper.SetCache(cachename, lst, DateTime.Now.AddMinutes(qitimespan), new TimeSpan());
            }
            return lst;
        }

    }
}
