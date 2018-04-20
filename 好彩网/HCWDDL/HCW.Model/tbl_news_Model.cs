using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCW.Model
{
    public class tbl_news_Model
    {
        public bool IsnidPassed = false;
        public bool IspidPassed = false;
        public bool IscidPassed = false;
        public bool IszidPassed = false;
        public bool IsczidPassed = false;
        public bool IsqiPassed = false;
        public bool IstitlePassed = false;
        public bool IsanthorPassed = false;
        public bool IsistopPassed = false;
        public bool IsisbestPassed = false;
        public bool IsishotPassed = false;
        public bool IscolorPassed = false;
        public bool IsaddtimePassed = false;
        public bool IsupdatetimePassed = false;

        private int mnid;
        private int? mpid;
        private int mcid;
        private int mzid;
        private int? mczid;
        private int? mqi;
        private string mtitle = "";
        private string manthor = "";
        private byte? mistop;
        private byte? misbest;
        private byte? mishot;
        private string mcolor = "";
        private DateTime? maddtime;
        private DateTime? mupdatetime;


        public tbl_news_Model() { }

        public tbl_news_Model(int mnid,
            int? mpid,
            int mcid,
            int mzid,
            int? mczid,
            int? mqi,
            string mtitle,
            string manthor,
            byte? mistop,
            byte? misbest,
            byte? mishot,
            string mcolor,
            DateTime? maddtime,
            DateTime? mupdatetime)
        {
            this.mnid = mnid;
            this.mpid = mpid;
            this.mcid = mcid;
            this.mzid = mzid;
            this.mczid = mczid;
            this.mqi = mqi;
            this.mtitle = mtitle;
            this.manthor = manthor;
            this.mistop = mistop;
            this.misbest = misbest;
            this.mishot = mishot;
            this.mcolor = mcolor;
            this.maddtime = maddtime;
            this.mupdatetime = mupdatetime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>不允许Null</remark>
        public int nid
        {
            get { return mnid; }
            set
            {
                mnid = value;
                IsnidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? pid
        {
            get { return mpid; }
            set
            {
                mpid = value;
                IspidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>不允许Null</remark>
        public int cid
        {
            get { return mcid; }
            set
            {
                mcid = value;
                IscidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>不允许Null</remark>
        public int zid
        {
            get { return mzid; }
            set
            {
                mzid = value;
                IszidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? czid
        {
            get { return mczid; }
            set
            {
                mczid = value;
                IsczidPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>int</returns>
        /// <remark>允许Null</remark>
        public int? qi
        {
            get { return mqi; }
            set
            {
                mqi = value;
                IsqiPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nvarchar</returns>
        /// <remark>不允许Null</remark>
        public string title
        {
            get { return mtitle; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new System.Data.NoNullAllowedException();
                }
                mtitle = value;
                IstitlePassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>nchar</returns>
        /// <remark>允许Null</remark>
        public string anthor
        {
            get { return manthor; }
            set
            {
                manthor = value;
                IsanthorPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>tinyint</returns>
        /// <remark>允许Null</remark>
        public byte? istop
        {
            get { return mistop; }
            set
            {
                mistop = value;
                IsistopPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>tinyint</returns>
        /// <remark>允许Null</remark>
        public byte? isbest
        {
            get { return misbest; }
            set
            {
                misbest = value;
                IsisbestPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>tinyint</returns>
        /// <remark>允许Null</remark>
        public byte? ishot
        {
            get { return mishot; }
            set
            {
                mishot = value;
                IsishotPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>char</returns>
        /// <remark>允许Null</remark>
        public string color
        {
            get { return mcolor; }
            set
            {
                mcolor = value;
                IscolorPassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>smalldatetime</returns>
        /// <remark>允许Null</remark>
        public DateTime? addtime
        {
            get { return maddtime; }
            set
            {
                maddtime = value;
                IsaddtimePassed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>smalldatetime</returns>
        /// <remark>允许Null</remark>
        public DateTime? updatetime
        {
            get { return mupdatetime; }
            set
            {
                mupdatetime = value;
                IsupdatetimePassed = true;
            }
        }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string context { get; set; }

        /// <summary>
        /// 新闻分类名称
        /// </summary>
        public string PName { get; set; }

        public tbl_news_Model Clonetbl_news()
        {
            return (tbl_news_Model)this.MemberwiseClone();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
