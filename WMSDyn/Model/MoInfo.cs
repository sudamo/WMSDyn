using System;

namespace CBSys.WMSDyn.Model
{
    /// <summary>
    /// 任务单Info
    /// </summary>
    public class MoInfo
    {
        public MoInfo() { }

        private int _PID;
        private string _Barcode;
        private int _FID;
        private string _FBillNo;
        private DateTime _FDate;
        private int _FEntryId;
        private string _FNumber;
        private decimal _FQTY;
        private int _FSEQ;
        private int _FDeptId;
        private int _Times;
        private string _Creator;
        private DateTime _CreationDate;
        private string _Modifier;
        private DateTime _ModificationDate;
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
        /// 日期
        /// </summary>
        public DateTime FDate
        {
            get
            {
                return _FDate;
            }

            set
            {
                _FDate = value;
            }
        }
        /// <summary>
        /// 任务单分录ID
        /// </summary>
        public int FEntryId
        {
            get
            {
                return _FEntryId;
            }

            set
            {
                _FEntryId = value;
            }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string FNumber
        {
            get
            {
                return _FNumber;
            }

            set
            {
                _FNumber = value;
            }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal FQTY
        {
            get
            {
                return _FQTY;
            }

            set
            {
                _FQTY = value;
            }
        }
        /// <summary>
        /// 序号
        /// </summary>
        public int FSEQ
        {
            get
            {
                return _FSEQ;
            }

            set
            {
                _FSEQ = value;
            }
        }
        /// <summary>
        /// 班组ID
        /// </summary>
        public int FDeptId
        {
            get
            {
                return _FDeptId;
            }

            set
            {
                _FDeptId = value;
            }
        }
        /// <summary>
        /// 次数
        /// </summary>
        public int Times
        {
            get
            {
                return _Times;
            }

            set
            {
                _Times = value;
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
        /// 修改人
        /// </summary>
        public string Modifier
        {
            get
            {
                return _Modifier;
            }

            set
            {
                _Modifier = value;
            }
        }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModificationDate
        {
            get
            {
                return _ModificationDate;
            }

            set
            {
                _ModificationDate = value;
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
