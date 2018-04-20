using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 社区商店商品描述类
    /// </summary>
    public class GoodsInfo
    {
        /// <summary>
        /// gid
        /// </summary>
        public int gid { get; set; }

        /// <summary>
        ///分类ID
        /// </summary>
        public int gcid { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string gname { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string img { get; set; }

        /// <summary>
        /// 未出售的卡密
        /// </summary>
        public string codes { get; set; }

        /// <summary>
        /// 未出售的卡密
        /// </summary>
        public string[] codeslist { get; set; }

        /// <summary>
        /// 已出售的卡密
        /// </summary>
        public string codesselled { get; set; }

        /// <summary>
        /// 已出售的卡密
        /// </summary>
        public string[] codesselledlist { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string aboutshort { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string about { get; set; }

        /// <summary>
        /// 商品总数
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// 已售出数量
        /// </summary>
        public int countselled { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public int payextcredits { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// 点击
        /// </summary>
        public int hits { get; set; }

        /// <summary>
        /// 是否自动发货
        /// </summary>
        public bool isautopost { get; set; }

        /// <summary>
        /// 是否在售
        /// </summary>
        public bool issell { get; set; }

        /// <summary>
        /// 是否限购每天一件
        /// </summary>
        public bool iseveryday { get; set; }

        /// <summary>
        /// 是否需要邮寄发货
        /// </summary>
        public bool needpost { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public string gettime { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime addtime { get; set; }

    }
}
