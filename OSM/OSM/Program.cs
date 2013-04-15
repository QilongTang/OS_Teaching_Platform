using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OSM.Forms;

namespace OSM
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
            F_Login entry = new F_Login();
            Application.Run(entry);
        }
    }
}
