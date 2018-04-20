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
    public partial class lottery_p3 : Pages
    {
        protected int id;
        protected int CzMode = (int)KjhCz.Czp3;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!allow.AllowPage)
                AllowMessage("对不起，当前用户无此权限！");

            menus1.clicked = 7;   //左边menu样式选中
            id = BBRequest.GetQueryInt("id", 0);
            if (!Page.IsPostBack)
            {
                BinderList();
                if (id > 0)
                    BinderKjhP3Info();
            }
        }

        private void BinderList()
        {
            string where = string.Empty;
            DataSet ds = KjhP3Data.GetPageListKjh(AspNetPager1.PageSize, AspNetPager1.CurrentPageIndex, "tbl_p3", "qi desc", where);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.list.DataSource = ds.Tables[0];
                list.DataBind();
                this.AspNetPager1.RecordCount = TypeConverter.ObjectToInt(ds.Tables[1].Rows[0][0]);
            }
        }

        private void BinderKjhP3Info()
        {
            KjhP3Info info = KjhP3.GetKjhP3Info(id, 0, false);
            if (info != null && info.id > 0)
            {
                qi.Text = info.qi.ToString().Trim();
                a.Text = info.a.ToString().Trim();
                b.Text = info.b.ToString().Trim();
                c.Text = info.c.ToString().Trim();
                d.Text = info.d.ToString().Trim();
                e.Text = info.e.ToString().Trim();
                zj1.Text = info.zj1.ToString().Trim();
                zj2.Text = info.zj2.ToString().Trim();
                zj3.Text = info.zj3.ToString().Trim();
                zjp5.Text = info.zjp5.ToString().Trim();
                tzmoney.Text = info.tzmoney;
                tzmoneyp5.Text = info.tzmoneyp5;
                date.Text = info.date.ToShortDateString();
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BinderList();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            KjhP3Info info = new KjhP3Info();
            info.id = id;
            info.qi = TypeConverter.StrToInt(qi.Text);
            info.a = TypeConverter.StrToInt(a.Text);
            info.b = TypeConverter.StrToInt(b.Text);
            info.c = TypeConverter.StrToInt(c.Text);
            info.d = TypeConverter.StrToInt(d.Text);
            info.e = TypeConverter.StrToInt(this.e.Text);
            info.zj1 = TypeConverter.StrToInt(zj1.Text.Trim().Replace(",", ""));
            info.zj2 = TypeConverter.StrToInt(zj2.Text.Trim().Replace(",", ""));
            info.zj3 = TypeConverter.StrToInt(zj3.Text.Trim().Replace(",", ""));
            info.zjp5 = TypeConverter.StrToInt(zjp5.Text.Trim().Replace(",", ""));
            info.tzmoney = tzmoney.Text.Trim().Replace(",", "");
            info.tzmoneyp5 = tzmoneyp5.Text.Trim().Replace(",", "");
            info.date = TypeConverter.StrToDateTime(date.Text);

            int i = KjhP3.CreateKjhP3Info(info);
            if (i > 0)
            {
                if (id == 0)
                    AlertMessage("提示：数据添加成功! ", "lottery_P3.aspx");
                else
                    AlertMessage("提示：数据编辑成功! ", "lottery_P3.aspx");
            }
            else if (i < 0)
                AlertMessage("数据已经存在，请勿重复添加....");
            else
                AlertMessage("保存失败，请重试....");
        }

        protected void autoget_Click(object sender, EventArgs e)
        {
            int qi = Cz.GetNewQi((int)KjhCz.Czp3);
            int getqi;
            int endqi = 359;
            if (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) % 4 == 0)
                endqi = 360;
            //本年度到顶 过年了
            if (TypeConverter.StrToInt(qi.ToString().Substring(4, 3)) == endqi)
            {
                qi = (TypeConverter.StrToInt(qi.ToString().Substring(0, 4)) + 1) * 1000 + 1;
            }
            getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/pls/" + getqi.ToString("00000") + ".xml";
            string urlp5 = "http://www.500.com/static/info/kaijiang/xml/plw/" + getqi.ToString("00000") + ".xml";
            DataSet dsp3 = new DataSet(), dsp5 = new DataSet();
            dsp3.ReadXml(XMLReader.GetXmlDocument(url));
            dsp5.ReadXml(XMLReader.GetXmlDocument(urlp5));
            if (dsp3 != null && dsp3.Tables.Count > 0 && dsp3.Tables[0].Rows.Count > 0 && dsp5 != null && dsp5.Tables.Count > 0 && dsp5.Tables[0].Rows.Count > 0)
            {
                KjhP3Info info = new KjhP3Info();
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Result"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Result"].ToString().Split(',')[4]);
                info.zj1 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num1"].ToString().Replace(",", ""));
                info.zj2 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num2"].ToString().Replace(",", ""));
                info.zj3 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num3"].ToString().Replace(",", ""));
                info.zjp5 = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Num1"].ToString().Replace(",", ""));
                info.tzmoney = dsp3.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.tzmoneyp5 = dsp5.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(dsp3.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhP3.CreateKjhP3Info(info);
                if (i > 0)
                {
                    JsRedirect("lottery_p3.aspx");
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
            if (obj != null && obj.ToString().Length > 0)
                return TypeConverter.ObjectToInt(obj).ToString("0");
            else
                return "";
        }

        protected string GetDateStr(object obj)
        {
            return GetDate(obj);
        }

        protected void autoget2_Click(object sender, EventArgs e)
        {
            int qi = Cz.GetMaxQi((int)KjhCz.Czp3);
            int getqi = TypeConverter.StrToInt(qi.ToString().Substring(2, 5));
            //写获取XML自动
            string url = "http://www.500.com/static/info/kaijiang/xml/pls/" + getqi.ToString("00000") + ".xml";
            string urlp5 = "http://www.500.com/static/info/kaijiang/xml/plw/" + getqi.ToString("00000") + ".xml";
            DataSet dsp3 = new DataSet(), dsp5 = new DataSet();
            dsp3.ReadXml(XMLReader.GetXmlDocument(url));
            dsp5.ReadXml(XMLReader.GetXmlDocument(urlp5));
            if (dsp3 != null && dsp3.Tables.Count > 0 && dsp3.Tables[0].Rows.Count > 0 && dsp5 != null && dsp5.Tables.Count > 0 && dsp5.Tables[0].Rows.Count > 0)
            {
                KjhP3Info info = KjhP3.GetKjhP3Info(0, qi, false);
                info.qi = qi;
                info.a = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[0]);
                info.b = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[1]);
                info.c = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Result"].ToString().Split(',')[2]);
                info.d = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Result"].ToString().Split(',')[3]);
                info.e = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Result"].ToString().Split(',')[4]);
                info.zj1 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num1"].ToString().Replace(",", ""));
                info.zj2 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num2"].ToString().Replace(",", ""));
                info.zj3 = TypeConverter.ObjectToInt(dsp3.Tables[0].Rows[0]["Num3"].ToString().Replace(",", ""));
                info.zjp5 = TypeConverter.ObjectToInt(dsp5.Tables[0].Rows[0]["Num1"].ToString().Replace(",", ""));
                info.tzmoney = dsp3.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.tzmoneyp5 = dsp5.Tables[0].Rows[0]["TotalMoney"].ToString().Replace(",", "");
                info.date = TypeConverter.ObjectToDateTime(dsp3.Tables[0].Rows[0]["ResultTime"]);

                int i;
                i = KjhP3.CreateKjhP3Info(info);
                if (i > 0)
                {
                    JsRedirect("lottery_p3.aspx");
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