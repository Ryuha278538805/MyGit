using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    /// <summary>
    /// 广告事务处理类
    /// </summary>
    public class Ad
    {

        /// <summary>
        /// 删除广告
        /// </summary>
        /// <param name="nid"></param>
        public static void DeleteAdDataInfo(string czid)
        {
            AdData.DeleteAdDataInfo(czid);
        }

        /// <summary>
        /// 生成/更新广告信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateAdDataInfo(ADmanagerInfo info)
        {
            int i = 0;
            i = AdData.CreateAdDataInfo(info);
            return i;
        }

        /// <summary>
        /// 某广告的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ADmanagerInfo GetAdInfo(int id)
        {
            List<ADmanagerInfo> list = GetAdDataListData();
            ADmanagerInfo info = new ADmanagerInfo();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                    return list[i];
            }
            return info;
        }

        public static List<ADmanagerInfo> GetAdDataListData()
        {
            List<ADmanagerInfo> list = new List<ADmanagerInfo>();
            DataTable dt = AdData.GetAdDataListData();

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    ADmanagerInfo info = new ADmanagerInfo();
                    DataRow dr = dt.Rows[i];
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.title = TypeConverter.ObjectToString(dr["title"]);
                    info.link = TypeConverter.ObjectToString(dr["link"]);
                    info.source = TypeConverter.ObjectToInt(dr["source"], 0);
                    info.sort = TypeConverter.ObjectToFloat(dr["sort"], 0);
                    info.PositonType = TypeConverter.ObjectToInt(dr["PositonType"], 1);
                    list.Add(info);
                }
            }

            return list;
        }
    }
}