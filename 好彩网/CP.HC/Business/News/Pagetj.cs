using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using DataProvider;
using Common;

namespace Business
{
    public class Pagetj
    {
        /// <summary>
        /// 取页面内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PageInfo GetPageInfo(int id)
        {
            PageInfo info = new PageInfo();
            DataRow dr = PageData.GetPageInfoData(id) ;
            if (dr != null)
            {
                info.id = TypeConverter.ObjectToInt(dr["id"]);
                info.pageid = TypeConverter.ObjectToInt(dr["pageid"]);
                info.title = dr["title"].ToString().Trim();
                if (dr["context"] != null)
                {
                    info.context = dr["context"].ToString().Trim();
                }
            }
            return info;
        }

        /// <summary>
        ///  按pageid列表
        /// </summary>
        /// <param name="pageid"></param>
        /// <returns></returns>
        public static List<PageInfo> GetPageList(int pageid)
        {
            DataTable dt = PageData.GetPageListData(pageid);
            List<PageInfo> list = new List<PageInfo>();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    PageInfo info = new PageInfo();
                    info.id = TypeConverter.ObjectToInt(dr["id"]);
                    info.pageid = TypeConverter.ObjectToInt(dr["pageid"]);
                    info.title = dr["title"].ToString().Trim();

                    list.Add(info);
                }
            }
            return list;
        }

        /// <summary>
        /// 更新页面信息
        /// </summary>
        /// <param name="info"></param>
        public static void UpdatePageInfo(PageInfo info)
        {
            PageData.UpdatePageInfo(info);
        }
    }
}
