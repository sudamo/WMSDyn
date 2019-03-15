using System;

namespace CBSys.WMSDyn.Model
{
    public class Template_DrawingInfo
    {
        public Template_DrawingInfo() { }
        public Template_DrawingInfo(string pFileName,string pDescription,byte[] pContext)
        {
            _FileName = pFileName;
            _Description = pDescription;
            _Context = pContext;
        }

        private string _FileName;
        private string _Description;
        private byte[] _Context;


        /// <summary>
        /// 
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
        /// 
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
        /// 
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
