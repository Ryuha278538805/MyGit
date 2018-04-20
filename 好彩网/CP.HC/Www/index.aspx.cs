using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Business;
using Common;

namespace Www
{
    public partial class index : Pages
    {
        protected Kjh225Info info225 = Kjh225.GetKjh225InfoTop1(true);
        protected Kjh3dInfo info3dnew = Kjh3d.GetKjh3dInfoTop1(0,true);
        protected Kjh3dInfo info3d = Kjh3d.GetKjh3dInfoTop1(1, true); 
        protected KjhDltInfo infodlt = KjhDlt.GetKjhDltInfoTop1(true);
        protected KjhQlcInfo infoqlc = KjhQlc.GetKjhQlcInfoTop1(true);
        protected KjhQxcInfo infoqxc = KjhQxc.GetKjhQxcInfoTop1(true);
        protected KjhP3Info infop3 = KjhP3.GetKjhP3InfoTop1(true);
        protected KjhSsqInfo infossq = KjhSsq.GetKjhSsqInfoTop1(true);
        protected string gg = "";   //公告
        protected string sdycad = "";   //3D预测广告
        protected string sdzmad = "";   //3D字谜广告
        protected string friendlink = "";
        protected CzInfo czinfo = Cz.GetCzInfo(1, true);

        protected void Page_Load(object sender, EventArgs e)
        {
            gg = Pagetj.GetPageInfo(2).context;
            sdycad = Pagetj.GetPageInfo(3).context;
            sdzmad = Pagetj.GetPageInfo(4).context;
            friendlink = Pagetj.GetPageInfo(1).context;
            //把最新的值赋予显示的值
            if (info3dnew.tzmoney != null && info3dnew.tzmoney.Length > 0) info3d = info3dnew;
            BinderZoneList(buyitukuzonelist, 7, 28);  //布衣图库 ok
            BinderZoneList(sanmaotukuzonelist, 50, 28);  //三毛图库 ok
            BinderZoneList(jptzonelist, 51, 28);   //红五图库 ok
            BinderZoneNews(8, 26, huizongzonelist);   //3D汇总专题 ok
            BinderZoneNews(10, 23, tumizonelist);   //彩报图迷专题 ok
            BinderTopNews(11, 26, 0, fc3djthlist);   //3D解太湖11条  ok
            BinderTopNews(30, 27, 0, fc3dyclist);   //3D预测30条  ok
            BinderTopNews(15, 28, 0, fc3dzmlist);   //3D字谜15条  ok
            BinderTopNews(30, 29, 0, tcp3yclist);   //P3预测30条  ok
            BinderTopNews(15, 30, 0, tcp3zmlist);   //P3字谜15条 ok
            BinderTopNews(30, 31, 0, fcssqyclist);   //双色球预测30条   ok
            BinderTopNews(15, 32, 0, fcssqzmlist);   //双色球字谜15条  ok
            BinderYcZoneList(1, 1, 4, danmalist);   //预测胆码列表4条    ok
            BinderYcZoneList(1, 3, 4, shamalist);   //预测杀码列表4条    ok

            //胆码与杀码TOP9条
            BinderTopNews(9, 52, 0, fc3ddmlist);
            BinderTopNews(9, 53, 0, fcsdsmlist);
        }

        /// <summary>
        /// 只处理胆码与杀码
        /// </summary>
        /// <param name="ishot"></param>
        /// <param name="isbest"></param>
        /// <param name="istop"></param>
        /// <returns></returns>
        protected string GetNewIsHot(object ishot, object isbest, object istop)
        {
            string result = "rtDy";
            if (TypeConverter.ObjectToBool(ishot)) result = "rtDyr";
            if (TypeConverter.ObjectToBool(isbest)) result = "rtDyj";
            if (TypeConverter.ObjectToBool(istop)) result = "rtDyd";
            return result;
        }
    }
}