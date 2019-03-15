using System;

namespace CBSys.WMSDyn.Model
{
    /// <summary>
    /// 物料Info
    /// </summary>
    public class MaterialInfo
    {
        public MaterialInfo() { }

        private int _PID;
        private int? _FMaterialId;
        private string _FNumber;
        private string _FName;
        private int _FUseOrgId;
        private int _FGroupId;
        private char _FDocumentStatus;
        private char _FForbidStatus;
        private string _F_PAEZ_BRAND;
        private string _F_PAEZ_SERIES;
        private string _F_PAEZ_TRADE;
        private string _F_PAEZ_CARSERIES;
        private string _F_PAEZ_CARTYPE;
        private string _F_PAEZ_COLOR;
        private string _Creator;
        private DateTime _CreationDate;
        private string _Modifier;
        private DateTime _ModificationDate;
        private bool _Flag;
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
        /// 物料ID
        /// </summary>
        public int? FMaterialId
        {
            get
            {
                return _FMaterialId;
            }

            set
            {
                _FMaterialId = value;
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
        /// 物料名称
        /// </summary>
        public string FName
        {
            get
            {
                return _FName;
            }

            set
            {
                _FName = value;
            }
        }
        /// <summary>
        /// 使用组织ID
        /// </summary>
        public int FUseOrgId
        {
            get
            {
                return _FUseOrgId;
            }

            set
            {
                _FUseOrgId = value;
            }
        }
        /// <summary>
        /// 物料分组
        /// </summary>
        public int FGroupId
        {
            get
            {
                return _FGroupId;
            }

            set
            {
                _FGroupId = value;
            }
        }
        /// <summary>
        /// 数据状态
        /// </summary>
        public char FDocumentStatus
        {
            get
            {
                return _FDocumentStatus;
            }

            set
            {
                _FDocumentStatus = value;
            }
        }
        /// <summary>
        /// 禁用状态
        /// </summary>
        public char FForbidStatus
        {
            get
            {
                return _FForbidStatus;
            }

            set
            {
                _FForbidStatus = value;
            }
        }
        /// <summary>
        /// 品牌
        /// </summary>
        public string F_PAEZ_BRAND
        {
            get
            {
                return _F_PAEZ_BRAND;
            }

            set
            {
                _F_PAEZ_BRAND = value;
            }
        }
        /// <summary>
        /// 系列
        /// </summary>
        public string F_PAEZ_SERIES
        {
            get
            {
                return _F_PAEZ_SERIES;
            }

            set
            {
                _F_PAEZ_SERIES = value;
            }
        }
        /// <summary>
        /// 商品名
        /// </summary>
        public string F_PAEZ_TRADE
        {
            get
            {
                return _F_PAEZ_TRADE;
            }

            set
            {
                _F_PAEZ_TRADE = value;
            }
        }
        /// <summary>
        /// 车系
        /// </summary>
        public string F_PAEZ_CARSERIES
        {
            get
            {
                return _F_PAEZ_CARSERIES;
            }

            set
            {
                _F_PAEZ_CARSERIES = value;
            }
        }
        /// <summary>
        /// 车型
        /// </summary>
        public string F_PAEZ_CARTYPE
        {
            get
            {
                return _F_PAEZ_CARTYPE;
            }

            set
            {
                _F_PAEZ_CARTYPE = value;
            }
        }
        /// <summary>
        /// 颜色
        /// </summary>
        public string F_PAEZ_COLOR
        {
            get
            {
                return _F_PAEZ_COLOR;
            }

            set
            {
                _F_PAEZ_COLOR = value;
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
        public bool Flag
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
