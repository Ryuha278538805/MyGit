using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using System.Text;
using Common;
using Model;
using Business;
using Www;

namespace Admin
{
    /// <summary>
    /// 后台所有aspx页面的基类
    /// </summary>
    public class Pages : Www.Pages
    {
        protected internal int aid = 0;
        protected internal string ausername = "";
        protected internal string anickname = "";
        protected internal int groupid = 0;
        protected Allow allow; //初始化权限
        protected string[] PayMethod = {"威望","金钱","彩贝"};
        public Pages()
        { 
            ///取后台用户信息
            GetAUserInfo();
            if (aid == 0 || string.IsNullOrEmpty(ausername))
                HttpContext.Current.Response.Write("<script>top.location.href='login.aspx';</script>");
            allow = new Allow(aid);
        }


        #region 提示窗口
        /// <summary>
        /// 提示窗口
        /// </summary>
        /// <param name="msg"></param>
        public  void AlertMessage(string msg,string url)
        {
            if(!string.IsNullOrEmpty(url))
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "myscript", "alert('"+msg+"');location.href='"+url+"'", true);
            else
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "myscript", "alert('" + msg + "');", true);
        }

        /// <summary>
        /// JS跳转
        /// </summary>
        /// <param name="url"></param>
        public void JsRedirect(string url)
        {
            if (!string.IsNullOrEmpty(url))
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "myscript", "location.href='" + url + "'", true);
        } 

        public void AllowMessage(string msg)
        {
            Response.Write("<h2 style=\"font-family:'Microsoft YaHei';font-size:20px;\">" + msg + "</h2><hr />您可以：<ul style=\"line-height:22px;\"><li><a href=\"/home.aspx\">返回管理平台首页</a></li><li>向其他管理员询问</li></ul>");
            Response.End();
        }
        #endregion

        #region aspx方法
         protected string GetSexName(object sex)
        {
            int s = Convert.ToInt32(sex);
            string str = "不限";
            switch (s)
            { 
                case 0:
                    str =  "不限";
                    break;
                case 1:
                    str =  "男";
                    break;
                case 2:
                    str =  "女";
                    break;
            }
            return str;
        }

        protected string Cutstr(string str, int len)
        {
            return Utils.GetCutString(str, len);
        }

        public void  AlertMessage(string msg)
        {
            AlertMessage(msg, null);
        }

        public static string CreateWord(int len)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append("  ├  ");
            }
            return sb.ToString();
        }

        public static int GetHits(object nid)
        {
            return News.GetNewsInfo(TypeConverter.ObjectToInt(nid)).hits;
        }

        public string GetDate(object dt)
        {
            return Convert.ToDateTime(dt).ToString("yyyy-MM-dd");
        }

        public string GetTime(object dt)
        {
            return Convert.ToDateTime(dt).ToString("MM-dd hh:mm");
        }

        public string GetIs(object isok)
        {
            bool al = TypeConverter.ObjectToBool(isok);
            if (al)
                return AdminIcons.OK;
            else
                return AdminIcons.NO;
        }

        public string GetPayMethod(object payextcredits)
        {
            return PayMethod[TypeConverter.ObjectToInt(payextcredits) - 1];
        }

        protected string GetCname(object cid)
        {
            return NewsClass.GetNewsClassInfo(TypeConverter.ObjectToInt(cid), false).name;
        }

        protected string GetCzname(object czid)
        {
            return Cz.GetCzInfo(TypeConverter.ObjectToInt(czid), false).czname;
        }

        protected string GetZonename(object zid)
        {
            return Zone.GetZoneInfo(TypeConverter.ObjectToInt(zid), false).name;
        }

        protected string GetYcTypeName(object yctype)
        {
            if (TypeConverter.ObjectToInt(yctype) > 0)
                return YcUtil.YcType[TypeConverter.ObjectToInt(yctype) - 1];
            else
                return "";
        }

        protected string GetYzName(object yzid)
        {
            return YcZone.GetYcZoneInfo(TypeConverter.ObjectToInt(yzid), false).name;
        }


        protected string GetQi(object qi)
        {
            string qistr = qi.ToString();
            if (qistr.Length > 2)
                return qi.ToString().Replace(DateTime.Now.Year.ToString(), "") + "期 —";
            else
                return "";
        }

        #endregion

        /// <summary>
        ///绑定彩种 
        /// </summary>
        public void BinderCzDrp(DropDownList dp)
        {
            List<CzInfo> list = Cz.GetCzList(true);
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListItem li = new ListItem(list[i].czname, list[i].czid.ToString());
                    dp.Items.Add(li);
                }
            }
        }

        /// <summary>
        ///绑定预测类型 
        /// </summary>
        public void BinderYcType(DropDownList dp)
        {
            for (int i = 0; i < YcUtil.YcType.Length; i++)
            {
                ListItem li = new ListItem(YcUtil.YcType[i], (i + 1).ToString());
                dp.Items.Add(li);
            }
        }

        #region 取后台用户登录信息
        /// <summary>
        /// 取后台用户信息
        /// </summary>
        private void GetAUserInfo()
        {
            string code = CookieUtil.GetCookie("htcode");
            
            if (!string.IsNullOrEmpty(code))
            {
                code = XXTEA.Decode(code);
                string[] strs = code.Split(',');
                if (strs.Length == 4)
                {
                    aid = Convert.ToInt32(strs[0]);
                    groupid = Convert.ToInt32(strs[3]);
                    ausername = strs[1];
                    anickname = strs[2];
                }
                else
                {
                    ///有cookie值，但不符合规则，强制清除.
                    CookieUtil.ClearHtCookie();
                }
            }
        }
        #endregion

    }
}

