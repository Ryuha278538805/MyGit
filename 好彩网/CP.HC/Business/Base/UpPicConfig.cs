using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    /// <summary>
    /// 传图设置
    /// </summary>
    public class UpPicConfig
    {
        /// <summary>
        /// 商店产品缩略图目录
        /// </summary>
        public const string GOODSIMG_PATH = "shop";

        /// <summary>
        /// 商店产品图宽
        /// </summary>
        public const int GOODSIMG_WIDTH = 800;

        /// <summary>
        /// 商店产品图高
        /// </summary>
        public const int GOODSIMG_HEIGHT = 600;

        /// <summary>
        /// 商店产品缩略图宽
        /// </summary>
        public const int GOODSIMG_TH_WIDTH = 196;

        /// <summary>
        /// 商店产品缩略图高
        /// </summary>
        public const int GOODSIMG_TH_HEIGHT = 240;

        /// <summary>
        /// 文章大图宽
        /// </summary>
        public const int NEWSIMG_BIG_WIDTH = 1024;

        /// <summary>
        /// 文章大图高
        /// </summary>
        public const int NEWSIMG_BIG_HEIGHT = 768;
                
        /// <summary>
        /// 文章略图宽
        /// </summary>
        public const int NEWSIMG_TH_WIDTH = 240;

        /// <summary>
        /// 文章略图高
        /// </summary>
        public const int NEWSIMG_TH_HEIGHT = 180;
    }

    /// <summary>
    /// 后台小图标
    /// </summary>
    public class AdminIcons
    {
        /// <summary>
        /// 勾勾
        /// </summary>
        public const string OK = "<img src=\"/resources/images/icons/tick_circle.png\"/>";

        /// <summary>
        /// 叉叉
        /// </summary>
        public const string NO = "<img src=\"/resources/images/icons/cross_circle.png\"/>";

        /// <summary>
        /// 黄色感叹号
        /// </summary>
        public const string WARNING = "<img src=\"/resources/images/icons/exclamation.png\"/>";

        /// <summary>
        /// 蓝色信息
        /// </summary>
        public const string INFO = "<img src=\"/resources/images/icons/information.png\"/>";
    }
}
