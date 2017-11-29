using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BackupFiles
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var f = new MainForm();
            if (args.Length == 0)
            {
                f.ViewModel = new ViewModel();
            }
            else
            {
                var m = ParseArgs(args);
                if (m == null)
                {
                    Console.WriteLine("调用格式: BackupFiles.exe -run:是否自动启动 -from:需备份的文件夹 -to:目标文件夹 -day:最近修改天数 -ip:忽略的文件夹名称1;名称2 -if:忽略的文件1;文件2");
                    return;
                }
                f.ViewModel = m;
            }

            Application.Run(f);
        }

        static private ViewModel ParseArgs(string[] args)
        {
            ViewModel m = new ViewModel();
            for (int i = 0; i < args.Length; i++)
            {
                var p = args[i].ToLower();
                if (p.StartsWith("-f:"))
                {
                    m.FromPath = p.Substring("-f:".Length);
                }
                else if (p.StartsWith("-from:"))
                {
                    m.FromPath = p.Substring("-from:".Length);
                }
                else if (p.StartsWith("-t:"))
                {
                    m.ToPath = p.Substring("-t:".Length);
                }
                else if (p.StartsWith("-to:"))
                {
                    m.ToPath = p.Substring("-to:".Length);
                }
                else if (p.StartsWith("-d:"))
                {
                    m.Days = int.Parse(p.Substring("-d:".Length));
                }
                else if (p.StartsWith("-day:"))
                {
                    m.Days = int.Parse(p.Substring("-day:".Length));
                }
                else if (p.StartsWith("-ip:"))
                {
                    m.IgnorePathList = p.Substring("-ip:".Length);
                }
                else if (p.StartsWith("-if:"))
                {
                    m.IgnoreFileList = p.Substring("-if:".Length);
                }
                else if (p.StartsWith("-run:"))
                {
                    m.IsAutoStart = bool.Parse(p.Substring("-run:".Length));
                }
            }

            if (string.IsNullOrEmpty(m.FromPath))
                return null;

            if (string.IsNullOrEmpty(m.ToPath))
                return null;

            if (m.Days == 0)
                return null;

            return m;
        }
    }
}
