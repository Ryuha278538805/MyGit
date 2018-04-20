using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 新闻分类(NewsClass)的数据库处理类
    /// </summary>
    public class NewsClassData:DataConnection
    {
        /// <summary>
        /// 所有分类数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetNewsClassListData()
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_news_class");
        }

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="zid"></param>
        public static void DeleteNewsClassInfo(string cid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_delete_newsclassinfo", cid);
        }

        /// <summary>
        /// 生成/更新专题信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int CreateNewsClassInfo(NewsClassInfo info)
        {
            int i = 0;
            i = TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_create_newsclassinfo", info.cid, info.name, info.ename, info.pid, info.rid, info.depth, info.czid, info.everqi, info.keywords, info.description));
            return i;
        }

   }
}
