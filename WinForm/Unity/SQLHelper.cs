using System;
using System.Data;
using System.Data.SqlClient;

namespace CBSys.WinForm.Unity
{
    /// <summary>
    /// 
    /// </summary>
    internal static class SQLHelper
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        static SQLHelper() { }

        //NonQuery
        public static void ExecuteNonQuery(string pCommandText)
        {
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pCommandText;
                cmd.ExecuteNonQuery();
            }
            catch { return; }
            finally
            {
                conn.Close();
            }
        }
        public static void ExecuteNonQuery(string pCommandText, SqlParameter[] pParms)
        {
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pCommandText;
                foreach (SqlParameter parm in pParms)
                {
                    cmd.Parameters.Add(parm);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        //Scalar
        public static object ExecuteScalar(string pCommandText)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pCommandText;
                o = cmd.ExecuteScalar();
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return o;
        }
        public static object ExecuteScalar(string pCommandText, SqlParameter[] pParms)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pCommandText;
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
        public static object ExecuteScalar(string pConnectionString, string pCommandText)
        {
            object o = new object();
            SqlConnection conn = new SqlConnection(pConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = pCommandText;
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
        public static DataTable ExecuteTable(string pCommandText)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(pCommandText, conn);
                adp.Fill(dt);
            }
            catch { return null; }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public static DataTable ExecuteTable(string pCommandText, SqlParameter[] pParms)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(pCommandText, conn);
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
        public static DataTable ExecuteTable(string pCommandText, CommandType pCommandType, SqlParameter[] pParms)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Model.UserSetting.DB_ConnectionString);
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();

            try
            {
                conn.Open();
                adp.SelectCommand = cmd;
                adp.SelectCommand.CommandText = pCommandText;
                adp.SelectCommand.CommandType = pCommandType;

                if (pCommandType == CommandType.StoredProcedure)
                    adp.SelectCommand.CommandTimeout = 10000;
                else
                    adp.SelectCommand.CommandTimeout = 500;

                if (pParms != null)
                {
                    foreach (SqlParameter parm in pParms)
                        adp.SelectCommand.Parameters.Add(parm);
                }
                adp.Fill(dt);
                adp.SelectCommand.Parameters.Clear();
            }
            catch { return null; }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return dt;
        }

        //Private Custom Methods
        private static void CommandSetting(SqlConnection pConnection, SqlCommand pCommand, SqlTransaction pTransation, CommandType pCommandType, string pCommandText, SqlParameter[] pParameters)
        {
            if (pConnection.State != ConnectionState.Open)
                pConnection.Open();

            pCommand.Connection = pConnection;
            pCommand.CommandType = pCommandType;
            pCommand.CommandText = pCommandText;

            if (pCommandType == CommandType.StoredProcedure)
                pCommand.CommandTimeout = 10000;
            else
                pCommand.CommandTimeout = 500;

            if (pTransation != null)
                pCommand.Transaction = pTransation;

            if (pParameters != null)
            {
                foreach (SqlParameter parm in pParameters)
                    pCommand.Parameters.Add(parm);
            }
        }
    }
}
