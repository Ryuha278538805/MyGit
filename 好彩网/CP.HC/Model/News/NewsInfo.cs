using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    /// <summary>
    /// 文章简单模型类
    /// </summary>
    public class ShortNewsInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int nid { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string title { get; set; }


        /// <summary>
        /// 分类id的父id
        /// </summary>
        public string pid { get; set; }


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
        /// 期数
        /// </summary>
        public int qi { get; set; }

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
    }

    /// <summary>
    /// 文章完整模型类
    /// </summary>
    public class NewsInfo : ShortNewsInfo
    {
        /// <summary>
        /// 文章内容
        /// </summary>
        public string context { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        public int hits { get; set; }


        /// <summary>
        /// 编辑人员
        /// </summary>
        public string username { get; set; }


        /// <summary>
        /// 编辑人id
        /// </summary>
        public int uid { get; set; }

    }
}
