using System;

namespace CBSys.WinForm.Model
{
    public class K3CloudInfo
    {
        public K3CloudInfo() { }
        public K3CloudInfo(string pC_URL, string pC_ZTID, string pC_USERNAME, string pC_PWD, string pK3DB_ConnectionString)
        {
            _C_URL = pC_URL;
            _C_ZTID = pC_ZTID;
            _C_USERNAME = pC_USERNAME;
            _C_PWD = pC_PWD;
            _K3DB_ConnectString = pK3DB_ConnectionString;
        }

        private string _C_URL;
        private string _C_ZTID;
        private string _C_USERNAME;
        private string _C_PWD;
        private string _K3DB_ConnectString;

        /// <summary>
        /// ERP地址
        /// </summary>
        public string C_URL
        {
            get
            {
                return _C_URL;
            }

            set
            {
                _C_URL = value;
            }
        }
        /// <summary>
        /// 帐套ID
        /// </summary>
        public string C_ZTID
        {
            get
            {
                return _C_ZTID;
            }

            set
            {
                _C_ZTID = value;
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string C_USERNAME
        {
            get
            {
                return _C_USERNAME;
            }

            set
            {
                _C_USERNAME = value;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string C_PWD
        {
            get
            {
                return _C_PWD;
            }

            set
            {
                _C_PWD = value;
            }
        }
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string K3DB_ConnectString
        {
            get
            {
                return _K3DB_ConnectString;
            }

            set
            {
                _K3DB_ConnectString = value;
            }
        }
    }
}
