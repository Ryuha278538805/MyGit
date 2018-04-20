using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 文章模板
    /// </summary>
    public class NewsTempletInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int tid { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 分类id
        /// </summary>
        public int cid { get; set; }


        /// <summary>
        /// 专题id
        /// </summary>
        public int zid { get; set; }

        /// <summary>
        /// 彩种
        /// </summary>
        public int czid { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string anthor { get; set; }


        public string color { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime addtime { get; set; }


        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime updatetime { get; set; }

        /// <summary>
        /// 置顶情况 
        /// 
        /// </summary>
        public int istop { get; set; }

        /// <summary>
        /// 精华情况 
        /// </summary>
        public int isbest { get; set; }

        /// <summary>
        /// 热门情况
        /// </summary>
        public int ishot { get; set; }

        /// <summary>
        /// 文章模板内容
        /// </summary>
        public string context { get; set; }
    }
}
