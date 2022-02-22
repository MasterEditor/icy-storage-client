using Autofac;
using Autofac.Core;
using HandyControl.Tools;
using IcyStorageClient.Services;
using IcyStorageClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Extensions.DependencyInjection;

namespace IcyStorageClient
{
    public static class BootStrapper
    {
        public static IServiceProvider Services { get; set; }

        public static void Start()
        {
            if (Services != null) return;

            var services = new ServiceCollection();

            services.AddTransient<ChromeViewModel>();
            services.AddTransient<MainViewModel>();

            Services = services.BuildServiceProvider();
        }
    }
}
