﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NI_Motion_test
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
            Application.Run(new NMC_Test());
        }
    }
}
