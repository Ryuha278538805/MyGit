using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 社区商店商品分类描述类
    /// </summary>
    public class GoodsClassInfo
    {
        /// <summary>
        /// gcid
        /// </summary>
        public int gcid { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 显示排序
        /// </summary>
        public int orderint { get; set; }

    }
}
