using System;
using System.Threading;
using System.Windows.Forms;

namespace CBSys.WinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isOpen = false;
            using (Mutex mx = new Mutex(true, Application.ProductName, out isOpen))
            {
                if (isOpen)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmLogin());
                }
                else
                {
                    MessageBox.Show("应用程序已经运行！");
                }
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
        }
    }
}
