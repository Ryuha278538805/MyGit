using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
using Common;

namespace DataProvider
{
    /// <summary>
    /// 论坛帖子相类的数据为操作类
    /// 对应表dnt_topic
    /// simwon
    /// </summary>
    public class BbsTopicData : DataConnection
    {
        /// <summary>
        /// 按分类列表
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public static DataTable GetTopicListData(string fid, int pagesize)
        {
            return SqlHelper.ExecuteDatatable(connstrbbs, "sp_st_bbs_topic", fid, pagesize);
        }
    }
}
