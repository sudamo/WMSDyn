using System;

namespace CBSys.WinForm.Model
{
    public class MTLDrawingInfo
    {
        public MTLDrawingInfo() { }
        public MTLDrawingInfo(int pCategoryId, string pSourcePath, string pBarcode, int pFMaterialId, string pFNumber, string pF_PAEZ_TRADE, string pF_PAEZ_CARSERIES, string pF_PAEZ_CARTYPE, bool pFlag)
        {
            _CategoryId = pCategoryId;
            _SourcePath = pSourcePath;
            _Barcode = pBarcode;
            _FMaterialId = pFMaterialId;
            _FNumber = pFNumber;
            _F_PAEZ_TRADE = pF_PAEZ_TRADE;
            _F_PAEZ_CARSERIES = pF_PAEZ_CARSERIES;
            _F_PAEZ_CARTYPE = pF_PAEZ_CARTYPE;
            _Flag = pFlag;
        }

        private int _CategoryId;
        private string _SourcePath;
        private string _Barcode;
        private int _FMaterialId;
        private string _FNumber;
        private string _F_PAEZ_BRAND;
        private string _F_PAEZ_SERIES;
        private string _F_PAEZ_TRADE;
        private string _F_PAEZ_CARSERIES;
        private string _F_PAEZ_CARTYPE;
        private bool _Flag;
        private bool _IsDelete;
        private string _Description;

        /// <summary>
        /// 版型类别：1、一码一图；2、一码两图，同时打开；3、一码两图，选择打开其一。
        /// </summary>
        public int CategoryId
        {
            get
            {
                return _CategoryId;
            }

            set
            {
                _CategoryId = value;
            }
        }
        /// <summary>
        /// 图纸原路径
        /// </summary>
        public string SourcePath
        {
            get
            {
                return _SourcePath;
            }

            set
            {
                _SourcePath = value;
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
        /// 物料ID
        /// </summary>
        public int FMaterialId
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
        /// 通用标识：true、非通用；false、非通用
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
        /// 作废标识：true、作废；false、正常
        /// </summary>
        public bool IsDelete
        {
            get
            {
                return _IsDelete;
            }

            set
            {
                _IsDelete = value;
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
