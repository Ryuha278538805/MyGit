using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Business;
using Model;
using DataProvider;
using Common;
using System.Text.RegularExpressions;

namespace Www
{
    public class Pages: System.Web.UI.Page
    {
        /// <summary>
        /// 获取到开奖号的总数
        /// </summary>
        public int count=0;

        public Pages()
        {
            Copyright();
        }

        /// <summary>
        /// 绑定开奖号列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cz"></param>
        /// <param name="relist"></param>
        public void BinderTopKjh(int pagesize, int page, int cz, Repeater relist)
        {            
            switch (cz)
            {
                case (int)KjhCz.Cz225:
                    List<Kjh225Info> list225 = Kjh225.GetKjh225PageList(pagesize, page, count, true);
                    if (list225 != null && list225.Count > 0)
                    {
                        relist.DataSource = list225;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Cz3d:
                    List<Kjh3dInfo> list3d = Kjh3d.GetKjh3dPageList(pagesize, page, count, true);
                    if (list3d != null && list3d.Count > 0)
                    {
                        relist.DataSource = list3d;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Czdlt:
                    List<KjhDltInfo> listdlt = KjhDlt.GetKjhDltPageList(pagesize, page, count, true);
                    if (listdlt != null && listdlt.Count > 0)
                    {
                        relist.DataSource = listdlt;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Czp3:
                    List<KjhP3Info> listp3 = KjhP3.GetKjhP3PageList(pagesize, page, count, true);
                    if (listp3 != null && listp3.Count > 0)
                    {
                        relist.DataSource = listp3;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Czqlc:
                    List<KjhQlcInfo> listqlc = KjhQlc.GetKjhQlcPageList(pagesize, page, count, true);
                    if (listqlc != null && listqlc.Count > 0)
                    {
                        relist.DataSource = listqlc;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Czqxc:
                    List<KjhQxcInfo> listqxc = KjhQxc.GetKjhQxcPageList(pagesize, 1, count, true);
                    if (listqxc != null && listqxc.Count > 0)
                    {
                        relist.DataSource = listqxc;
                        relist.DataBind();
                    }
                    break;

                case (int)KjhCz.Czssq:
                    List<KjhSsqInfo> listssq = KjhSsq.GetKjhSsqPageList(pagesize, page, count, true);
                    if (listssq != null && listssq.Count > 0)
                    {
                        relist.DataSource = listssq;
                        relist.DataBind();
                    }
                    break;

            }
            
        }

        /// <summary>
        /// 绑定首页和小块调用的文章列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderTopNews(int pagesize,int cid,int zid, Repeater relist)
        {
            List<NewsInfo> list = News.GetNewsList(pagesize, cid, zid);
            if (list != null && list.Count > 0)
            {
                relist.DataSource = list;
                relist.DataBind();
            }
        }

         /// <summary>
        /// 绑定当前文章前N条文章
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderPreNews(int pagesize,int nid, Repeater relist)
        {
            List<NewsInfo> list = News.GetNewsPreList(pagesize, nid);
            if (list != null && list.Count > 0)
            {
                relist.DataSource = list;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 另外一种形式的专题显示
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public string GetZoneTitle(int zid)
        {
            string str = string.Empty;
            ZoneInfo zinfo = Zone.GetZoneInfo(zid, true);
            NewsInfo info = News.GetNewsInfoByZid(zid);
            string p = string.Empty;
            if (info != null && info.nid > 0)
            {
                if (info.cid == 8 || info.cid == 10)
                    p = "p";
                str = "<a href=\"/" + GetNewsClassInfo(info.cid).ename + "/" + Getdir(info.addtime) + "/" + p + "" + info.nid + ".html\" target=\"_blank\" title=\"" + info.title + "\">" +GetCutString(info.title.Trim(),16) + "</a>";
            }
            else
            {
                str = zinfo.name.Replace("福彩3D", "").Replace("体彩P3", "");
            }

            return str;
        }

        /// <summary>
        /// 绑定论坛最新帖子
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderBBSTopic(Repeater list, string fid, int pagesize)
        {
            DataTable dt = BbsTopicData.GetTopicListData(fid, pagesize);
            if (dt != null && dt.Rows.Count > 0)
            {
                list.DataSource = dt;
                list.DataBind();
            }
        }

        /// <summary>
        /// 绑定首页和小块调用的文章列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderZoneNews(int pagesize, int cid, Repeater relist)
        {
            List<ZoneInfo> list = Zone.GetZoneListByCid(cid, true);
            if (list != null && list.Count > 0)
            {
                if (list.Count > pagesize)
                {
                    for (int i = list.Count; i > pagesize; i--)
                    {
                        list.RemoveAt(i-1);
                    }
                }                       
                relist.DataSource = list;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 获取专题第一条新闻的连接
        /// </summary>
        /// <param name="zid"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public string GetZoneNewsLink(object zid, int len)
        {
            ZoneInfo zinfo = Zone.GetZoneInfo(TypeConverter.ObjectToInt(zid), true);
            NewsInfo newsinfo = News.GetNewsInfoByZid(zinfo.zid);
            string result = string.Empty;
            if (zinfo.zid > 0 && newsinfo.nid > 0)
            {
                result = "<a href=\"/" + GetNewsClassInfo(zinfo.cid).ename + "/" + Getdir(newsinfo.addtime) + "/" + newsinfo.nid.ToString()+ ".html\"  class=\""+GetIsNewQi(zinfo.zid,zinfo.cid)+"\" title=\""+newsinfo.title+"\">" + GetCutString(zinfo.name, len) + "</a>";
            }
            return result;
        }

        public string GetIsNewZone(object zid)
        {
            return "";
        }


        /// <summary>
        /// 绑定首页专题列表
        /// </summary>
        /// <param name="zid"></param>
        /// <param name="len"></param>
        public void BinderZoneList(Repeater relist, object cid, int count)
        {
            List<ZoneInfo> list = Zone.GetZoneListByCid(TypeConverter.ObjectToInt(cid), true);
            if (list.Count > count)
            {
                for (int i = list.Count-1; i > count; i--)
                {
                    list.RemoveAt(i);
                }
            }
            relist.DataSource = list;
            relist.DataBind();
        }


        /// <summary>
        /// 随机绑定专题文章列表
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderRandomZoneNews(int pagesize, int cid, Repeater relist)
        {
            List<ZoneInfo> list = Zone.GetZoneListByCid(cid, true);
            List<ZoneInfo> result = new List<ZoneInfo>();
            if (list != null && list.Count > 0)
            {
                if (list.Count > pagesize)
                {
                    int[] ranlist = RandomNum.RandomList(pagesize, 0, list.Count - 1);  //产生一个不重复随机数组
                    for (int i = 0; i < pagesize; i++)
                    {
                        result.Add(list[ranlist[i]]);
                    }
                }
                else
                {
                    result = list;
                }
                relist.DataSource = result;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 取专题的显示和地址
        /// </summary>
        /// <param name="zid"></param>
        /// <returns></returns>
        public string GetZoneInfo(int zid)
        {
            string str = string.Empty;
            ZoneInfo zinfo = Zone.GetZoneInfo(zid, true);
            NewsInfo info = News.GetNewsInfoByZid(zid);
            
            string p = string.Empty;
            if (info != null && info.nid > 0)
            {
                if (info.cid == 8 || info.cid == 10)
                    p = "p";
                str = "<a href=\"/" + GetNewsClassInfo (info.cid).ename+ "/"+Getdir(info.addtime)+"/"+p+""+info.nid+".html\" target=\"_blank\" title=\""+info.title+"\">" + zinfo.name.Replace("福彩3D", "").Replace("体彩P3", "") + "</a>";
            }
            else {
                str = zinfo.name.Replace("福彩3D","").Replace("体彩P3","");
            }

            return str;
        }

        /// <summary>
        /// 绑定专题列表
        /// </summary>
        /// <param name="rootid"></param>
        /// <param name="pid"></param>
        public void BinderYcZoneList(int czid, int type, Repeater relist)
        {
            List<YcZoneInfo> yczonelist = new List<YcZoneInfo>();
            yczonelist = YcZone.GetYcZoneList(czid, type, true);
            if (yczonelist != null && yczonelist.Count > 0)
            {
                relist.DataSource = yczonelist;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 绑定专题列表
        /// </summary>
        /// <param name="rootid"></param>
        /// <param name="pid"></param>
        public void BinderYcZoneList(int czid, int type, int count, Repeater relist)
        {
            List<YcZoneInfo> yczonelist = new List<YcZoneInfo>();
            yczonelist = YcZone.GetYcZoneList(czid, type, true);
            if (yczonelist != null && yczonelist.Count > 0)
            {
                if (yczonelist.Count > count)
                    yczonelist.RemoveRange(count, yczonelist.Count - count);
                relist.DataSource = yczonelist;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 绑定15条预测信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderYcInfoTop15(int yid, Repeater relist)
        {
            List<YcInfo> list = Yc.GetYcInfoTop15ListByYid(yid);
            if (list != null && list.Count > 0)
            {
                relist.DataSource = list;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 绑定相关预测信息
        /// </summary>
        /// <param name="pagesize"></param>
        /// <param name="cid"></param>
        /// <param name="blist"></param>
        public void BinderXgYcInfo(int czid, int type, int yzid, int count, Repeater relist)
        {
            string where = "";
            if (czid > 0)
                where = "czid=" + czid.ToString();
            if (type > 0)
            {
                if (string.IsNullOrEmpty(where))
                    where = "type=" + type.ToString();
                else
                    where +=" and type="+ type.ToString();
            }
            if (yzid > 0)
            {
                if (string.IsNullOrEmpty(where))
                    where = "yzid=" + type.ToString();
                else
                    where += " and yzid=" + type.ToString();
            }
            DataSet ds = YcData.GetPageList(count, 1, "vv_ycinfo", "yid desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                relist.DataSource = ds.Tables[0];
                relist.DataBind();
            }
            else
            {
                relist.DataSource = null;
                relist.DataBind();
            }
        }

        /// <summary>
        /// 获取当前预测专题前两个预测内容聚合
        /// </summary>
        /// <param name="yzid"></param>
        /// <returns></returns>
        public string GetTop2YcInfoStrByYZID(object yzid)
        {
            string result = string.Empty;
            YcZoneInfo yczoneinfo = YcZone.GetYcZoneByYzID(TypeConverter.ObjectToInt(yzid));
            if (!string.IsNullOrEmpty(yczoneinfo.name))
            {
                YcInfo infotop1 = Yc.GetYcInfoNoChkTop1ByYzid(yczoneinfo.yzid);
                YcInfo infotop2 = Yc.GetYcInfoChkTop1ByYzid(yczoneinfo.yzid);
                result = "<div class=\"title_h1\"><a href=\"/dsyc/" + Getdir(infotop1.addtime) + "/" + infotop1.yid+ ".html\">" + infotop1.title + "</a></div>";
                result += "<div class=\"title_h2\"><a href=\"/dsyc/" + Getdir(infotop1.addtime) + "/" + infotop1.yid + ".html\">"+infotop1.context+"<br />";
                result += infotop2.context+"</a></div>";
            }
            return result;
        }

        /// <summary>
        /// Copy
        /// </summary>
        public static void Copyright()
        {
            string host = string.Empty;
            if (HttpContext.Current.Request.Url != null) 
                host = HttpContext.Current.Request.Url.Host.ToLower();

            if (!(host.Contains(Config.domain) || host.Contains("localhost") || host.Contains("127.0.0.1")))
            {
                //if (News.GetNewsUI() == 0)
                //   HttpContext.Current.Response.End();                                
                HttpContext.Current.Response.Write("<h2 style=\"font-family:'Microsoft YaHei';font-size:22px;color:#333;\">平台在非正常模式下运行！</h2><hr />您可以：<ul style=\"line-height:22px;\"><li>让平台在正常模式下运行，即在绑定的域名" + Config.domain + "下运行</li><li>联系我 " + Config.developer + "</li></ul>");
                HttpContext.Current.Response.End();
            }           
        }

        #region aspx方法
        public void AlertMessage(string msg)
        {
            AlertMessage(msg, null);
        }

        /// <summary>
        /// 提示窗口
        /// </summary>
        /// <param name="msg"></param>
        public void AlertMessage(string msg, string url)
        {
            if (!string.IsNullOrEmpty(url))
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "myscript", "alert('" + msg + "');location.href='" + url + "'", true);
            else
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "myscript", "alert('" + msg + "');", true);
        }

        public string GetCutString(string str, int len)
        {
            return Utils.GetCutString(str, len);
        }

        public NewsClassInfo GetNewsClassInfo(object cid)
        {
            return NewsClass.GetNewsClassInfo( TypeConverter.ObjectToInt(cid), true);
        }

        public static string Getdir(object dt)
        {
            return Convert.ToDateTime(dt).ToString("MMdd");
        }

        public string GetDate(object dt)
        {
            return Convert.ToDateTime(dt).ToString("MM-dd");
        }

        public string GetDateStr(object dt)
        {
            return Convert.ToDateTime(dt).ToString("yyyy-MM-dd");
        }

        public string GetKjh(object num)
        {
            return Convert.ToInt32(num).ToString("00");
        }

        public string GetQi(object qi)
        {
            return TypeConverter.ObjectToInt(qi).ToString().Substring(4);
        }

        public string GetNumStr(object num)
        {
            return string.Format("{0:0,00}", TypeConverter.ObjectToInt(num));
        }

        public string ChkIsToday(string week)
        {
            int inde = -1;
            inde = week.IndexOf(((int)DateTime.Now.DayOfWeek).ToString());
            if (inde >= 0)
                return "1";   //黄色
            else
                return "0";   //灰色
        }

        public string[] GetSplit(string str)
        { 
            return str.Split('/');
        }

        public string GetIsHot(object ishot, object isbest, object istop)
        {
            string result ="tx1";
            if (TypeConverter.ObjectToBool(ishot)) result = "txr";
            if (TypeConverter.ObjectToBool(isbest)) result = "txj";
            if (TypeConverter.ObjectToBool(istop)) result = "txd";
            return result;
        }

        protected string GetZoneNewsUrl(object id)
        {
            string url = "";
            int zid = TypeConverter.ObjectToInt(id);
            NewsInfo info = News.GetNewsInfoByZid(zid);
            ZoneInfo zinfo = Zone.GetZoneInfo(zid, true);
            if (info.nid > 0)
            {
                url += "/" + NewsClass.GetNewsClassInfo(zinfo.cid, true).ename + "/" + Getdir(info.addtime) + "/" + info.nid + ".html";
            }
            else
            {
                url = "";
            }
            return url;
        }

        protected string GetZoneNewsTitle(object id)
        {
            string result = "";
            int zid = TypeConverter.ObjectToInt(id);
            NewsInfo info = News.GetNewsInfoByZid(zid);
            ZoneInfo zinfo = Zone.GetZoneInfo(zid, true);
            if (info.nid > 0)
            {
                result += info.title;
            }
            else
            {
                result = "";
            }
            return result;
        }

        public static string striphtml(string str)
        {
            Regex regex = new Regex(@"<[^>]+>|</[^>]+>");
            str = regex.Replace(str, "");
            str = str.Replace(" ", "");
            str = str.Replace("	 ", "");
            str = str.Replace("&nbsp;", "");
            str = str.Replace("\r\n", "");
            str = str.Replace("\r", "");
            return str;
        }

        public static string GetIsNewQi(object zid, object cid)
        {
            bool ishave = false;
            string result = "gray";
            int _zid = TypeConverter.ObjectToInt(zid);
            List<ZoneInfo> AddedZone = Zone.GetZoneList(TypeConverter.ObjectToInt(cid), false);            
            if (_zid > 0)
            {
                for (int i = 0; i < AddedZone.Count; i++)
                {
                    if (AddedZone[i].zid == _zid)
                    {
                        ishave = true;
                        break;
                    }
                }
            }            
            if (ishave)
                result = "";
            return result;
        }
        
        #endregion
    }
}