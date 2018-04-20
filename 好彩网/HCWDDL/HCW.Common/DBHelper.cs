using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;
using Newtonsoft.Json;
using System.Reflection;

namespace HCW.Common
{
    public class DBHelper
    {
        public static string CONN_Main = ConfigurationManager.ConnectionStrings["ConnectionString_Main"].ConnectionString;
        public static string CONN_KJ = ConfigurationManager.ConnectionStrings["ConnectionString_KJ"].ConnectionString;

        private string strConnection;

        public DBHelper(string eConn)
        {
            strConnection = eConn;
        }

        /// <summary>
        /// 返回首个元素
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public string ExecuteScalar(string strSQL)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result == null ? "" : result.ToString();
                }
            }
        }

        /// <summary>
        /// 执行更新或插入
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string strSQL)
        {
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                conn.Open();
                using (var ts = new TransactionScope())
                {
                    using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        ts.Complete();
                        return result;
                    }
                }
            }
        }

        /// <summary>
        /// 获取结果集
        /// </summary>
        /// <param name="strSQL">sql</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(string strSQL)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                conn.Open();
                using (SqlDataAdapter adp = new SqlDataAdapter(strSQL, conn))
                {
                    adp.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// 获取结果集
        /// </summary>
        /// <param name="strSQL">sql</param>
        /// <returns>List</returns>
        public IList<T> GetList<T>(string strSQL)
        {
            DataTable dt = GetDataTable(strSQL);
            string temp = JsonConvert.SerializeObject(dt);

            var result = JsonConvert.DeserializeObject<List<T>>(temp);

            return result;
        }

        /// <summary>
        /// 获取结果集
        /// </summary>
        /// <param name="strSQL">sql</param>
        /// <returns>单实体</returns>
        public T GetEntity<T>(string strSQL) where T : new()
        {
            var lst = GetList<T>(strSQL);
            if (lst != null && lst.Count > 0)
            {
                return lst[0];
            }
            else
            {
                return new T();
            }
        }
    }
}
