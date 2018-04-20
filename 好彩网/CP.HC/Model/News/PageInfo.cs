using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 页面推荐模型类
    /// </summary>
    public class PageInfo
    {
        public int id { get; set; }

        /// <summary>
        /// 标题说明
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string context { get; set; }

        /// <summary>
        /// 页面id
        /// </summary>
        public int pageid { get; set; }

    }
}
