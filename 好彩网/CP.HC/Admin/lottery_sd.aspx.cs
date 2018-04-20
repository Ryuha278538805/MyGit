using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Text;
using System.Xml;
using Common;
using Business;
using Model;
using DataProvider;

namespace Admin
{
    public partial class lottery_sd : Pages
    {
        protected int id;
        protected int CzMode = (int)KjhCz.Cz3d;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 3;   //左边menu样式选中
            id = BBRequest.GetQueryInt("id", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (id > 0)
                    BinderKjh3dInfo();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = Kjh3dData.GetPageListKjh(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_3d", "qi desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderKjh3dInfo()
        {
            Kjh3dInfo info = Kjh3d.GetKjh3dInfo(id, 0, false);
            if (info != null && info.id > 0)
            {
                qi.Text = info.qi.ToString().Trim();
                kjih.Text = info.kjih.ToString().Trim();
                a.Text = info.a.ToString().Trim();
                b.Text = info.b.ToString().Trim();
                c.Text = info.c.ToString().Trim();
                zj1.Text = info.zj1.ToString().Trim();
                zj2.Text = info.zj2.ToString().Trim();
                zj3.Text = info.zj3.ToString().Trim();
                sjh.Text = info.sjh.ToString().Trim();
                sjx.SelectedValue = info.sjx;
                tzmoney.Text = info.tzmoney;
                date.Text = info.date.ToShortDateString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            Kjh3dInfo info = new Kjh3dInfo();
            info.id = id;
            info.qi = TypeConverter.StrToInt(qi.Text);
            info.a = TypeConverter.StrToInt(a.Text);
            info.b = TypeConverter.StrToInt(b.Text);
            info.c = TypeConverter.StrToInt(c.Text);
            info.zj1 = TypeConverter.StrToInt(zj1.Text);
            info.zj2 = TypeConverter.StrToInt(zj2.Text);
            info.zj3 = TypeConverter.StrToInt(zj3.Text);
            info.sjh = TypeConverter.StrToInt(sjh.Text);
            info.sjx = sjx.SelectedValue;
            info.kjih = TypeConverter.StrToInt(kjih.Text);
            info.tzmoney = tzmoney.Text.Trim();
            info.date = TypeConverter.StrToDateTime(date.Text);

            int i ;
            if (a.Text.Length > 0 && b.Text.Length > 0 && c.Text.Length > 0 && sjh.Text.Length > 0)
                i = Kjh3d.CreateKjh3dAllInfo(info);
            else
                i = Kjh3d.CreateKjh3dInfo(info);
            if (i > 0)
            {
                if (id == 0)
                    AlertMessage("提示：数据添加成功! ", "lottery_sd.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "lottery_sd.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");          
        }

        protected void autoget_Click(object sender, EventArgs e)
        {            
            int qi = Cz.GetNewQi((int)KjhCz.Cz3d);
            int endqi = 359;
            if (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) % 4 == 0)
                endqi = 360;
            //本年度到顶 过年了
            if (TypeConverter.StrToInt(qi.ToString().Substring(4, 3)) == endqi)
            {
                qi = (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) + 1) * 1000 + 1;
            }

           //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/sd/" + qi + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Kjh3dInfo info = new Kjh3dInfo();
                info.qi = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["PeriodicalNO"]);
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[2]);
                info.zj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num1"]);
                info.zj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num2"]);
                info.zj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num3"]);
                info.sjh = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["TryCode"].ToString().Trim().Replace(",", ""));
                info.sjx = ds.Tables[0].Rows[0]["TryInfo"].ToString().Trim();                
                info.tzmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Trim().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = Kjh3d.CreateKjh3dAllInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_sd.aspx");
                    //if (id == 0)
                    //    AlertMessage("提示：数据添加成功! ", "lottery_sd.aspx");
                    //else
                    //    AlertMessage("提示：数据编辑成功! ", "lottery_sd.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }
 
        protected string GetKjh(object obj)
        {
            if (obj != null && obj.ToString().Length> 0)
                return TypeConverter.ObjectToInt(obj).ToString("000");
            else
                return "";
        }

        protected string GetDateStr(object obj)
        {
            return GetDate(obj);
        }

        protected void autoget2_Click(object sender, EventArgs e)
        {
             int qi = Cz.GetMaxQi((int)KjhCz.Cz3d);

           //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/sd/" + qi + ".xml";
            DataSet ds = new DataSet();
            ds.ReadXml(XMLReader.GetXmlDocument(url));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Kjh3dInfo info = Kjh3d.GetKjh3dInfo(0, qi, false);
                //info.qi = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["PeriodicalNO"]);
                info.a = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Result"].ToString().Split(',')[2]);
                info.zj1 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num1"]);
                info.zj2 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num2"]);
                info.zj3 = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["Num3"]);
                //info.sjh = TypeConverter.ObjectToInt(ds.Tables[0].Rows[0]["TryCode"].ToString().Trim().Replace(",", ""));
                //info.sjx = ds.Tables[0].Rows[0]["TryInfo"].ToString().Trim();                
                info.tzmoney = ds.Tables[0].Rows[0]["TotalMoney"].ToString().Trim().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(ds.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = Kjh3d.CreateKjh3dAllInfo(info);
                if (i > 0)
                {
                    JsRedirect("lottery_sd.aspx");
                    //if (id == 0)
                    //    AlertMessage("提示：数据添加成功! ", "lottery_sd.aspx");
                    //else
                    //    AlertMessage("提示：数据编辑成功! ", "lottery_sd.aspx");
                }
                else if (i < 0)
                    AlertMessage("数据已经存在，请勿重复添加....");
                else
                    AlertMessage("保存失败，请重试....");
            }
        }
    }
}