﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zkrt.bean;

namespace Zkrt
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
            login Log = new login();
            Log.ShowDialog();
            
            if (Log.DialogResult == DialogResult.OK)
            {
                Application.Run(new zkrt_map());
            }
        }
    }
}
