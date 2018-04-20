using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
namespace DataProvider
{
    public class DataConnection
    {
        
        /// <summary>
        /// 首页数据库 连接....
        /// </summary>
        protected internal static string connstr
        {
            get
            {
                    if (System.Configuration.ConfigurationManager.ConnectionStrings["connstr"] != null)
                        return System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ToString().Trim();
                    else
                        return "";
            }
        }

        /// <summary>
        /// 开奖号数据库 连接....
        /// </summary>
        protected internal static string connstrkjh
        {
            get
            {
                if (System.Configuration.ConfigurationManager.ConnectionStrings["connstrkjh"] != null)
                    return System.Configuration.ConfigurationManager.ConnectionStrings["connstrkjh"].ToString().Trim();
                else
                    return "";
            }
        }

        /// <summary>
        /// 论坛数据库 连接....
        /// </summary>
        protected internal static string connstrbbs
        {
            get
            {
                if (System.Configuration.ConfigurationManager.ConnectionStrings["connstrbbs"] != null)
                    return System.Configuration.ConfigurationManager.ConnectionStrings["connstrbbs"].ToString().Trim();
                else
                    return "";
            }
        }

        /// <summary>
        /// 数据库直接翻页的方法
        /// 可用于所有表
        /// datatable[0]中存放列表
        /// datatable[1].Rows[0]中存放记录条数
        /// </summary>
        /// <param name="pagesize">每页数量</param>
        /// <param name="page">当前页码</param>
        /// <param name="table">表名/视图名</param>
        /// <param name="order">排序,如按aa字段排序,写成 aa desc(ac)</param>
        /// <param name="where">条件,如 uid=1</param>
        /// <returns></returns>
        public static DataSet GetPageList(int pagesize,int page,string table,string order,string where)
        {
            return SqlHelper.ExecuteDataset(connstr, "sp_st_page", pagesize, page, table, order, where);
        }

        /// <summary>
        /// 数据库直接翻页的方法Kjh
        /// 可用于所有表
        /// datatable[0]中存放列表
        /// datatable[1].Rows[0]中存放记录条数
        /// </summary>
        /// <param name="pagesize">每页数量</param>
        /// <param name="page">当前页码</param>
        /// <param name="table">表名/视图名</param>
        /// <param name="order">排序,如按aa字段排序,写成 aa desc(ac)</param>
        /// <param name="where">条件,如 uid=1</param>
        /// <returns></returns>
        public static DataSet GetPageListKjh(int pagesize, int page, string table, string order, string where)
        {
            return SqlHelper.ExecuteDataset(connstrkjh, "sp_st_page", pagesize, page, table, order, where);
        }

        /// <summary>
        /// 数据库直接翻页的方法Kjh
        /// 可用于所有表
        /// datatable[0]中存放列表
        /// datatable[1].Rows[0]中存放记录条数
        /// </summary>
        /// <param name="pagesize">每页数量</param>
        /// <param name="page">当前页码</param>
        /// <param name="table">表名/视图名</param>
        /// <param name="order">排序,如按aa字段排序,写成 aa desc(ac)</param>
        /// <param name="where">条件,如 uid=1</param>
        /// <returns></returns>
        public static DataSet GetPageListBbs(int pagesize, int page, string table, string order, string where)
        {
            return SqlHelper.ExecuteDataset(connstrbbs, "sp_st_page", pagesize, page, table, order, where);
        }
    }
}
