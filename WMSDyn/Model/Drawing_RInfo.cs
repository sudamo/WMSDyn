using System;

namespace CBSys.WMSDyn.Model
{
    public class Drawing_RInfo
    {
        public Drawing_RInfo() { }

        public Drawing_RInfo(int pPID, string pR_Type, string pM_Users, string pManagers, string pU_Users, string pD_Users, string pU_Users2, string pD_Users3, string pU_Users3, string pD_Users2, string pOperator, DateTime pOTime, string pDescription)
        {
            _PID = pPID;
            _R_Type = pR_Type;
            _M_Users = pM_Users;
            _Managers = pManagers;
            _U_Users = pU_Users;
            _D_Users = pD_Users;
            _U_Users2 = pU_Users2;
            _D_Users2 = pD_Users2;
            _U_Users3 = pU_Users3;
            _D_Users3 = pD_Users3;
            _Operator = pOperator;
            _OTime = pOTime;
            _Description = pDescription;
        }

        private int _PID;
        private string _R_Type;
        private string _M_Users;
        private string _Managers;
        private string _U_Users;
        private string _D_Users;
        private string _U_Users2;
        private string _D_Users2;
        private string _U_Users3;
        private string _D_Users3;
        private string _Operator;
        private DateTime _OTime;
        private string _Description;

        /// <summary>
        /// 主键
        /// </summary>
        public int PID
        {
            get
            {
                return _PID;
            }

            set
            {
                _PID = value;
            }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public string R_Type
        {
            get
            {
                return _R_Type;
            }

            set
            {
                _R_Type = value;
            }
        }
        /// <summary>
        /// 模板管理用户
        /// </summary>
        public string M_Users
        {
            get
            {
                return _M_Users;
            }

            set
            {
                _M_Users = value;
            }
        }
        /// <summary>
        /// 管理员
        /// </summary>
        public string Managers
        {
            get
            {
                return _Managers;
            }

            set
            {
                _Managers = value;
            }
        }
        /// <summary>
        /// U用户
        /// </summary>
        public string U_Users
        {
            get
            {
                return _U_Users;
            }

            set
            {
                _U_Users = value;
            }
        }
        /// <summary>
        /// D用户
        /// </summary>
        public string D_Users
        {
            get
            {
                return _D_Users;
            }

            set
            {
                _D_Users = value;
            }
        }
        /// <summary>
        /// U用户2
        /// </summary>
        public string U_Users2
        {
            get
            {
                return _U_Users2;
            }

            set
            {
                _U_Users2 = value;
            }
        }
        /// <summary>
        /// D用户2
        /// </summary>
        public string D_Users2
        {
            get
            {
                return _D_Users2;
            }

            set
            {
                _D_Users2 = value;
            }
        }
        /// <summary>
        /// U用户3
        /// </summary>
        public string U_Users3
        {
            get
            {
                return _U_Users3;
            }

            set
            {
                _U_Users3 = value;
            }
        }
        /// <summary>
        /// D用户3
        /// </summary>
        public string D_Users3
        {
            get
            {
                return _D_Users3;
            }

            set
            {
                _D_Users3 = value;
            }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string Operator
        {
            get
            {
                return _Operator;
            }

            set
            {
                _Operator = value;
            }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OTime
        {
            get
            {
                return _OTime;
            }

            set
            {
                _OTime = value;
            }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }
    }
}
