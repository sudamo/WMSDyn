using System;

namespace CBSys.WMSDyn.Model
{
    /// <summary>
    /// 图纸Info
    /// </summary>
    public class DrawingInfo
    {
        public DrawingInfo() { }

        public DrawingInfo(int? pFMaterialId, string pFNumber, string pSourcePath, string pFileName, string pFileSuffix, long pFileSize, string pCreator, DateTime pCreationDate, bool pFlag, bool pIsDelete, string pDescription, byte[] pContext)
        {
            _FMaterialId = pFMaterialId;
            _FNumber = pFNumber;
            _SourcePath = pSourcePath;
            _FileName = pFileName;
            _FileSuffix = pFileSuffix;
            _FileSize = pFileSize;
            _Creator = pCreator;
            _CreationDate = pCreationDate;
            _Flag = pFlag;
            _IsDelete = pIsDelete;
            _Description = pDescription;
            _Context = pContext;
        }

        private int _PID;
        private int? _FMaterialId;
        private string _FNumber;
        private string _SourcePath;
        private string _FileName;
        private string _FileSuffix;
        private long _FileSize;
        private string _Creator;
        private DateTime _CreationDate;
        private bool _Flag;
        private bool _IsDelete;
        private string _Description;
        private byte[] _Context;

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
        /// 文件路径
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
        /// 文件名称
        /// </summary>
        public string FileName
        {
            get
            {
                return _FileName;
            }

            set
            {
                _FileName = value;
            }
        }
        /// <summary>
        /// 后缀
        /// </summary>
        public string FileSuffix
        {
            get
            {
                return _FileSuffix;
            }

            set
            {
                _FileSuffix = value;
            }
        }
        /// <summary>
        /// 文件大小（KB）
        /// </summary>
        public long FileSize
        {
            get
            {
                return _FileSize;
            }

            set
            {
                _FileSize = value;
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
        /// 锁定标识
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
        /// 作废标识
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
        /// <summary>
        /// Context
        /// </summary>
        public byte[] Context
        {
            get
            {
                return _Context;
            }

            set
            {
                _Context = value;
            }
        }
    }
}
