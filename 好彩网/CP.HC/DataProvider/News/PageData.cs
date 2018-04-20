using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    public class PageData : DataConnection
    {

        /// <summary>
        /// 更新页面信息
        /// </summary>
        /// <param name="info"></param>
        public static void UpdatePageInfo(PageInfo info)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_pageinfo", info.id, info.context);
        }

        /// <summary>
        /// 取页面内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataRow GetPageInfoData(int id)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_pageinfo", id);          
        }

        /// <summary>
        ///  按pageid列表
        /// </summary>
        /// <param name="pageid"></param>
        /// <returns></returns>
        public static DataTable GetPageListData(int pageid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_pagelist", pageid);          
        }
    }
}