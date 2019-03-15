using System;
using System.Data;
using System.Data.SqlClient;
using CBSys.WMSDyn.SQL;

namespace CBSys.SQLFactory
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommonFunc
    {
        #region STATIC
        private static string strSQL;
        private static object obj;

        /// <summary>
        /// 构造函数
        /// </summary>
        static CommonFunc()
        {
            strSQL = string.Empty;
            obj = new object();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public static void UpdateLogin()
        {
            SqlParameter[] parms = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.VarChar)
            };
            parms[0].Value = WMSDyn.Model.UserSetting.UserInf.UserName;

            strSQL = "UPDATE BD_Users SET LogStatus = 1,LastLoginDate = GETDATE() WHERE UserName = @UserName";

            SQLHelper.ExecuteTable(strSQL, parms);
        }
    }
}
