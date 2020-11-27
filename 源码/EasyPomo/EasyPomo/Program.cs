using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EasyPomo
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
            bool isRuned;
            var mutex = new Mutex(true, "EasyPomo", out isRuned);
            if (isRuned)
            {

                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(@"EasyPomo已启动！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
