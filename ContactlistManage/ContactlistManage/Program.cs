using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Infrastructure;

namespace ContactlistManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLiteOperate.CreateDB();
            Application.Run(new Login());
        }
    }
}
