﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZhaoXi.View;

namespace ZhaoXi
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (new LogInView().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();
            }

            new MainWindow().ShowDialog();
            Application.Current.Shutdown();
        }
    }
}
