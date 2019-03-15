using System;

namespace CBSys.WMSDyn.Model
{
    public class UserSetting
    {
        public UserSetting(UserInfo pUserInf, DepartmentInfo pDeptInf, string pDBConnectionString, K3CloudInfo pK3CloudInf)
        {
            _UserInf = pUserInf;
            _DeptInf = pDeptInf;
            _DB_ConnectionString = pDBConnectionString;
            _K3CloudInf = pK3CloudInf;
        }

        private static string _DB_ConnectionString;
        private static UserInfo _UserInf;
        private static DepartmentInfo _DeptInf;
        private static K3CloudInfo _K3CloudInf;

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string DB_ConnectionString
        {
            get
            {
                return _DB_ConnectionString;
            }

            set
            {
                _DB_ConnectionString = value;
            }
        }
        /// <summary>
        /// 当前用户信息
        /// </summary>
        public static UserInfo UserInf
        {
            get
            {
                return _UserInf;
            }

            set
            {
                _UserInf = value;
            }
        }
        /// <summary>
        /// 当前用户部门信息
        /// </summary>
        public static DepartmentInfo DeptInf
        {
            get
            {
                return _DeptInf;
            }

            set
            {
                _DeptInf = value;
            }
        }
        /// <summary>
        /// 金蝶配置信息
        /// </summary>
        public static K3CloudInfo K3CloudInf
        {
            get
            {
                return _K3CloudInf;
            }

            set
            {
                _K3CloudInf = value;
            }
        }
    }
}
