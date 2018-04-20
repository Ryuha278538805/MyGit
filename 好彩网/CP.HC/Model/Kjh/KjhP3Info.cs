using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 体彩P3模型
    /// </summary>
    public class KjhP3Info
    {
        public int id { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        public int qi { get; set; }

        /// <summary>
        /// 第一个号
        /// </summary>
        public int a { get; set; }

        /// <summary>
        /// 第二个号
        /// </summary>
        public int b { get; set; }

        /// <summary>
        /// 第三个号
        /// </summary>
        public int c { get; set; }

        /// <summary>
        /// P5第四个号
        /// </summary>
        public int d { get; set; }

        /// <summary>
        /// P5第五个号
        /// </summary>
        public int e { get; set; }

        /// <summary>
        /// 直选个数
        /// </summary>
        public int zj1 { get; set; }

        /// <summary>
        /// 组三个数
        /// </summary>
        public int zj2 { get; set; }

        /// <summary>
        /// 组六个数
        /// </summary>
        public int zj3 { get; set; }

        /// <summary>
        /// P5中奖
        /// </summary>
        public int zjp5 { get; set; }

        /// <summary>
        /// 和值
        /// </summary>
        public int hz { get; set; }

        /// <summary>
        /// 投注额
        /// </summary>
        public string tzmoney { get; set; }

        /// <summary>
        /// P5投注额
        /// </summary>
        public string tzmoneyp5 { get; set; }

        /// <summary>
        /// 试机号
        /// </summary>
        public string sjh { get; set; }

        /// <summary>
        /// 开奖号（包含P5）
        /// </summary>
        public string kjh { get; set; }

        /// <summary>
        /// 试机号机球类型
        /// </summary>
        public string sjhtype { get; set; }

        /// <summary>
        /// 开奖日期
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
