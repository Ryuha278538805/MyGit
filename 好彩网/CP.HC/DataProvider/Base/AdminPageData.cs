using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace DataProvider
{
    /// <summary>
    /// 后台数据
    /// </summary>
    public class AdminPageData : DataConnection
    {

        #region 用户

        /// <summary>
        /// 获取后台用户组
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public static DataTable GetAdUserGroup(int gid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_st_master_group",gid);
        }

        /// <summary>
        /// 获取后台用户 
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="ausername"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DataRow GetAdUser(int uid, string ausername, string password, string ip)
        {
            return SqlHelper.ExecuteDatarow(connstr, "sp_st_master", uid, ausername, password, ip);
        }

        /// <summary>
        /// 删除用户及关联信息
        /// </summary>
        /// <param name="uid"></param>
        public static void DeleteUser(int uid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_del_user");
        }
        #endregion

        #region 打折信息 
        /// <summary>
        /// 获取商品 
        /// </summary>
        /// <param name="gid">商品ID</param>
        /// <param name="cid">分类</param>
        /// <param name="did">打折类型</param>
        /// <param name="sid">来源</param>
        /// <param name="aid">编辑</param>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public static DataSet GetGoods(int gid,int cid,int did,int sid,int aid,int page,int pagesize)
        {
            string where;
            where = (gid > 0) ? "" : ("gid=" + gid);
            //多条数据,构造查询条件
            if (where.Length == 0)
            {
                where = (cid > 0) ? "" : ("cid=" + cid);
                if (where.Length == 0) where += ((did > 0) ? "" : (" did=" + did));  
                else where += ((did > 0) ? "" : (" and did=" + did));
                if (where.Length == 0) where += ((sid > 0) ? "" : (" sid=" + sid));
                else where += ((sid > 0) ? "" : (" and sid=" + sid));
                if (where.Length == 0) where += ((aid > 0) ? "" : ("aid=" + aid));
                else where += ((aid > 0) ? "" : (" and aid=" + aid));
            }
            return GetPageList(pagesize, page, "tbl_goods", "", where);
        }

        /// <summary>
        /// 插入、更新商品信息
        /// </summary>
        public static int UpdateGoods(int gid, int cid, int did, string gname, string shortname, decimal mprice, decimal zprice, int isexpress, int ishot, int sid, string uri, string taokeuri,string sphoto, DateTime overtime, string context, string ausername, int aid,string indemity, string tag)
        {
            return Common.TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_up_goods", gid, cid, did, gname, shortname, mprice, zprice, isexpress, ishot, sid, uri, taokeuri, sphoto, overtime, context, ausername, aid, indemity, tag));
        }

        /// <summary>
        /// 设置信息是否显示
        /// </summary>
        /// <param name="gid"></param>
        /// <param name="isok">是否显示</param>
        /// <param name="autoset">是否根据现有值设置</param>
        public static void UpdateGoodsIsOK(int gid, int isok , int autoset)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_goods_isok", gid, isok, autoset);
        }

        public static void DeleteGoods(int gid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_del_goods", gid);
        }
        #endregion

        #region 打折信息Photo
        /// <summary>
        /// 添加产品图片
        /// </summary>
        /// <param name="gid">产品ID</param>
        /// <param name="picurl">图片地址</param>
        public static void UpdateGoodsPhoto(int gid, string picurl)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_goods_photo", gid, picurl);
        }
        #endregion

        #region TAG
        /// <summary>
        /// 编辑 添加TAG
        /// </summary>
        /// <param name="tid"></param>
        /// <param name="tags">格式：(tag1,tag2)</param>
        /// <returns>返回刚刚添加的TAG</returns>
        public static DataTable UpTags(int tid, string tags,int cid)
        {
            return SqlHelper.ExecuteDatatable(connstr, "sp_up_tags", tid, tags, cid);
        }

        /// <summary>
        /// 合并TAG ，以第一个TAG为主TAG合并
        /// </summary>
        /// <param name="tags"></param>
        public static void MergeTag(string tags)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_tags_merge", tags);
        }
        #endregion

        #region Indemnity
        /// <summary>
        /// 添加，编辑保障
        /// </summary>
        /// <param name="iid"></param>
        /// <param name="iname"></param>
        /// <returns></returns>
        public static void UpdateIndemnity(int iid,string iname)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_indemnity", iid, iname);
        }
        #endregion 

        #region Source
        /// <summary>
        /// 添加，编辑打折来源
        /// </summary>
        /// <param name="iid"></param>
        /// <param name="iname"></param>
        /// <returns></returns>
        public static int UpdateSource(int sid, string sname, string logo, string url, int isunion, string unionstring, string context)
        {
           return  Common.TypeConverter.ObjectToInt(SqlHelper.ExecuteScalar(connstr, "sp_up_source", sid, sname, logo, url, isunion, unionstring, context));
        }
        #endregion

        #region SourceClass
        /// <summary>
        /// 添加，编辑来源类型
        /// </summary>
        /// <param name="scid"></param>
        /// <param name="cname"></param>
        /// <returns></returns>
        public static void UpdateSourceClass(int scid, string cname)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_source_class", scid, cname);
        }

        /// <summary>
        /// 添加来源和来源类型关系
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="scid"></param>
        /// <param name="orderint"></param>
        public static void UpdateSource_Scid(int sid, int scid, int orderint)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_source_scid", sid, scid, orderint);
        }
        #endregion

        #region DiscountClass
        /// <summary>
        /// 添加，编辑保障
        /// </summary>
        /// <param name="iid"></param>
        /// <param name="iname"></param>
        /// <returns></returns>
        public static void UpdateDiscountClass(int did, string dname)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_discount_class", did, dname);
        }
        #endregion

        #region Feed
        /// <summary>
        /// 添加，编辑订阅来源
        /// </summary>
        /// <param name="iid"></param>
        /// <param name="iname"></param>
        /// <returns></returns>
        public static void UpdateFeed(int fid, string name, string dourl)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_feed", fid, name, dourl);
        }
        #endregion

        #region MasterGroup
        /// <summary>
        /// 添加，编辑后台用户组
        /// </summary>
        /// <param name="groupid"></param>
        /// <param name="name"></param>
        /// <param name="allowpub">发布权</param>
        /// <param name="allowuser">用户管理权</param>
        /// <param name="allowsys">系统设置权</param>
        public static void UpdateMasterGroup(int groupid, string name, int allowpub,int allowuser,int allowsys)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_mastergroup", groupid, name, allowpub,allowuser,allowsys);
        }
        #endregion
         
        #region Master
        /// <summary>
        /// 添加，编辑后台用户
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="ausername"></param>
        /// <param name="password"></param>
        /// <param name="groupid"></param>
        public static void UpdateMaster(int aid, string ausername, string password, int groupid)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_up_master",  aid, ausername, password, groupid);
        }
        #endregion 

        #region User
        /// <summary>
        /// 更新用户信息
        /// 返回BOOL 成功和失败
        /// </summary>
        public static bool UpdateUser(int uid, string email, string nickname, string password, string truename, int sex, string age, string comefrom, string postcode, string address, string mobile, string qq, string msn, string gtalk, string sinaweibo, string qqweibo)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(connstr, "sp_up_user", uid, email, nickname, password, truename, sex, age, comefrom, postcode, address, mobile, qq, msn, gtalk, sinaweibo, qqweibo);
                return true;
            }
            catch { return false; }
        }
        #endregion

        /// <summary>
        /// 删除单条无关联数据
        /// </summary>
        public static void DelFromTable(string table, string idname, int id)
        {
            SqlHelper.ExecuteNonQuery(connstr, "sp_del_data", table, idname, id);
        }
    }
}