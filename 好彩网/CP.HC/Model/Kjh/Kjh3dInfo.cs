using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   /// <summary>
   /// 3D开奖号模型
   /// </summary>
    public class Kjh3dInfo
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
        /// 和值
        /// </summary>
        public int hz { get; set; }

        /// <summary>
        /// 一等奖个数
        /// </summary>
        public int zj1 { get; set; }

        /// <summary>
        /// 二等奖个数
        /// </summary>
        public int zj2 { get; set; }

        /// <summary>
        /// 三等奖个数
        /// </summary>
        public int zj3 { get; set; }

        /// <summary>
        /// 试机号
        /// </summary>
        public int sjh { get; set; }

        /// <summary>
        /// 试机号类型
        /// </summary>
        public string sjx { get; set; }

        /// <summary>
        /// 投注额
        /// </summary>
        public string tzmoney { get; set; }

        /// <summary>
        /// 开奖号三位数
        /// </summary>
        public int kjh { get; set; }

        /// <summary>
        /// 开机号
        /// </summary>
        public int kjih { get; set; }

        /// <summary>
        /// 开奖号组
        /// </summary>
        public int kjh_zu { get; set; }

        /// <summary>
        /// 开奖号奇偶
        /// </summary>
        public int kjh_jo { get; set; }

        /// <summary>
        /// 开奖号大小
        /// </summary>
        public int kjh_dx { get; set; }

        /// <summary>
        /// 开奖号质合
        /// </summary>
        public int kjh_zh { get; set; }

        /// <summary>
        /// 开奖号和值大小
        /// </summary>
        public int kjh_hz_dx { get; set; }

        /// <summary>
        /// 开奖号和值奇偶
        /// </summary>
        public int kjh_hz_jo { get; set; }

        /// <summary>
        /// 试机号组
        /// </summary>
        public int sjh_zu { get; set; }

        /// <summary>
        /// 试机号奇偶
        /// </summary>
        public int sjh_jo { get; set; }

        /// <summary>
        /// 试机号大小
        /// </summary>
        public int sjh_dx { get; set; }

        /// <summary>
        /// 试机号质合
        /// </summary>
        public int sjh_zh { get; set; }

        /// <summary>
        /// 试机号和值
        /// </summary>
        public int sjh_hz { get; set; }

        /// <summary>
        /// 试机号和值大小
        /// </summary>
        public int sjh_hz_dx { get; set; }

        /// <summary>
        /// 试机号和值奇偶
        /// </summary>
        public int sjh_hz_jo { get; set; }


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
