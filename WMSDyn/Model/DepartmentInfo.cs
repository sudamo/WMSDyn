using System;

namespace CBSys.WMSDyn.Model
{
    public class DepartmentInfo
    {
        public DepartmentInfo() { }
        public DepartmentInfo(int pDeptId, string pFNumber, string pFName)
        {
            _FDeptId = pDeptId;
            _FNumber = pFNumber;
            _FName = pFName;
        }

        private int? _FDeptId;
        private string _FNumber;
        private string _FName;

        public int? FDeptId
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
    }
}
