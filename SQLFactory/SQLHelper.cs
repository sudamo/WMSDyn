using System;
using System.Data;
using System.Data.SqlClient;
using CBSys.WMSDyn.Model;

namespace CBSys.SQLFactory
{
    /// <summary>
    /// 自定义SQLHelper
    /// </summary>
    public static class SQLHelper
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        static SQLHelper() { }

        //NonQuery
        public static void ExecuteNonQuery(string pSQL)
        {
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pSQL;
                cmd.ExecuteNonQuery();
            }
            catch { return; }
            finally
            {
                conn.Close();
            }
        }

        public static void ExecuteNonQuery(string pSQL, SqlParameter[] pParms)
        {
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pSQL;
                foreach (SqlParameter parm in pParms)
                {
                    cmd.Parameters.Add(parm);
                }
                cmd.ExecuteNonQuery();
            }
            catch { return; }
            finally
            {
                conn.Close();
            }
        }

        //Scalar
        public static object ExecuteScalar(string pSQL)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pSQL;
                o = cmd.ExecuteScalar();
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return o;
        }

        public static object ExecuteScalar(string pSQL, SqlParameter[] pParms)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pSQL;
                foreach (SqlParameter parm in pParms)
                {
                    cmd.Parameters.Add(parm);
                }
                o = cmd.ExecuteScalar();
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return o;
        }

        //Scalar
        public static object ExecuteScalar(string pConnectionString, string pSQL)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(pConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pSQL;
                o = cmd.ExecuteScalar();
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return o;
        }

        //Table
        public static DataTable ExecuteTable(string pSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(pSQL, conn);
                adp.Fill(dt);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable ExecuteTable(string pSQL, SqlParameter[] pParms)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(pSQL, conn);
                foreach (SqlParameter parm in pParms)
                {
                    adp.SelectCommand.Parameters.Add(parm);
                }
                adp.Fill(dt);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
