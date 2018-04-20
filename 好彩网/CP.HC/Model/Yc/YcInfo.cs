using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 预测内容描述类
    /// </summary>
    public class YcInfo
    {
        /// <summary>
        /// 预测 id
        /// </summary>
        public int yid { get; set; }

        /// <summary>
        /// 专题id
        /// </summary>
        public int yzid { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        public int qi { get; set; }

        /// <summary>
        /// 预测内容
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// 开奖号
        /// </summary>
        public string kjh { get; set; }

        /// <summary>
        /// 是否正确
        /// </summary>
        public bool isright { get; set; }

        /// <summary>
        /// 显示标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 显示内容
        /// </summary>
        public string context { get; set; }

        /// <summary>
        /// 点击数
        /// </summary>
        public int hits { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
