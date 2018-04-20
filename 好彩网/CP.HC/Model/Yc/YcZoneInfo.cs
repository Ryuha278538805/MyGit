using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 预测专题(模板)描述类
    /// </summary>
    public class YcZoneInfo
    {
        /// <summary>
        /// 专题id
        /// </summary>
        public int yzid { get; set; }

        /// <summary>
        /// 专题名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 彩种id
        /// </summary>
        public int czid { get; set; }

        /// <summary>
        /// 预测类型
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 是否自动生成
        /// </summary>
        public bool isautowrite { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int orderint { get; set; }

        /// <summary>
        /// 当前期
        /// </summary>
        public int lastqi { get; set; }       

        /// <summary>
        /// SEO关键字
        /// </summary>
        public string keywords { get; set; }

        /// <summary>
        /// SEO描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 标题模板
        /// </summary>
        public string titlemodel { get; set; }

        /// <summary>
        /// 文章模板
        /// </summary>
        public string contextmodel { get; set; }

        /// <summary>
        /// 文章开始内容
        /// </summary>
        public string contexthead { get; set; }

        /// <summary>
        /// 文章结尾内容
        /// </summary>
        public string contextend { get; set; }

         /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
