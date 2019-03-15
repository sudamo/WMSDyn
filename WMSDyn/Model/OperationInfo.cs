using System;

namespace CBSys.WMSDyn.Model
{
    /// <summary>
    /// 日志Info
    /// </summary>
    public class OperationInfo
    {
        public OperationInfo() { }

        private int _PID;
        private string _Barcode;
        private int _FID;
        private string _FBillNo;
        private int _OperatorId;
        private string _Operator;
        private string _Client;
        private string _IP;
        private string _MAC;
        private string _Creator;
        private DateTime _CreationDate;
        private byte _Flag;
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
        /// 条码
        /// </summary>
        public string Barcode
        {
            get
            {
                return _Barcode;
            }

            set
            {
                _Barcode = value;
            }
        }
        /// <summary>
        /// 任务单ID
        /// </summary>
        public int FID
        {
            get
            {
                return _FID;
            }

            set
            {
                _FID = value;
            }
        }
        /// <summary>
        /// 任务单号
        /// </summary>
        public string FBillNo
        {
            get
            {
                return _FBillNo;
            }

            set
            {
                _FBillNo = value;
            }
        }
        /// <summary>
        /// 操作员ID
        /// </summary>
        public int OperatorId
        {
            get
            {
                return _OperatorId;
            }

            set
            {
                _OperatorId = value;
            }
        }
        /// <summary>
        /// 操作员
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
        /// 客户端名称
        /// </summary>
        public string Client
        {
            get
            {
                return _Client;
            }

            set
            {
                _Client = value;
            }
        }
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP
        {
            get
            {
                return _IP;
            }

            set
            {
                _IP = value;
            }
        }
        /// <summary>
        /// MAC
        /// </summary>
        public string MAC
        {
            get
            {
                return _MAC;
            }

            set
            {
                _MAC = value;
            }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator
        {
            get
            {
                return _Creator;
            }

            set
            {
                _Creator = value;
            }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }

            set
            {
                _CreationDate = value;
            }
        }
        /// <summary>
        /// 标识
        /// </summary>
        public byte Flag
        {
            get
            {
                return _Flag;
            }

            set
            {
                _Flag = value;
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
