﻿using SAEA.Common;
using SAEA.WebAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEA.Redis.WebManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Title = "WebRedisManagerService";

            SAEAMvcApplication mvcApplication = new SAEAMvcApplication(false, false, 10240, 1);

            mvcApplication.Start();

            ConsoleHelper.WriteLine("WebRedisManager服务已启动");

            ConsoleHelper.WriteLine("服务地址：http://localhost:39654/html/index.html");

            Process.Start("http://localhost:39654/html/index.html");

            ConsoleHelper.WriteLine("回车退出服务...");

            ConsoleHelper.ReadLine();
        }
    }
}
