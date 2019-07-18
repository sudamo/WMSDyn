using System;

namespace CBSys.WinForm.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserSetting
    {
        public UserSetting() { }
        public UserSetting(string pDBConnectionString, K3CloudInfo pK3CloudInf, UserInfo pUserInf, DepartmentInfo pDeptInf, Drawing_RInfo pDrawing_RInf)
        {
            _DB_ConnectionString = pDBConnectionString;
            _K3CloudInf = pK3CloudInf;
            _UserInf = pUserInf;
            _DeptInf = pDeptInf;
            _Drawing_RInf = pDrawing_RInf;
        }

        private static bool _IsFenChang;
        private static string _DB_ConnectionString;
        private static K3CloudInfo _K3CloudInf;
        private static UserInfo _UserInf;
        private static DepartmentInfo _DeptInf;
        private static Drawing_RInfo _Drawing_RInf;

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
        /// <summary>
        /// 图纸权限
        /// </summary>
        public static Drawing_RInfo Drawing_RInf
        {
            get
            {
                return _Drawing_RInf;
            }

            set
            {
                _Drawing_RInf = value;
            }
        }

        /// <summary>
        /// 是否分厂登陆
        /// </summary>
        public static bool IsFenChang
        {
            get
            {
                return _IsFenChang;
            }

            set
            {
                _IsFenChang = value;
            }
        }
    }
}
