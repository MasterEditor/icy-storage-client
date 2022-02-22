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

namespace IcyStorageClient
{
    public static class BootStrapper
    {
        private static ILifetimeScope _rootScope;
        private static IChromeViewModel _chromeViewModel;

        public static IViewModel RootVisual
        {
            get
            {
                if (_rootScope is null) Start();

                _chromeViewModel = _rootScope.Resolve<IChromeViewModel>();
                return _chromeViewModel;
            }
        }

        public static void Start()
        {
            if (_rootScope is not null) return;

            var builder = new ContainerBuilder();
            var assemblies = new[] { Assembly.GetExecutingAssembly() };

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IService).IsAssignableFrom(t))
                .SingleInstance()
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IViewModel).IsAssignableFrom(t) && !typeof(ITransientViewModel).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IViewModel).IsAssignableFrom(t))
                .Where(t => typeof(ITransientViewModel).IsAssignableFrom(t))
                .AsImplementedInterfaces()
                .ExternallyOwned();

            _rootScope = builder.Build();
        }

        public static void Stop()
        {
            _rootScope.Dispose();
        }

        public static T Resolve<T>()
        {
            return _rootScope.Resolve<T>(new Parameter[0]);
        }

        public static T Resolve<T>(Parameter[] parameters)
        {
            return _rootScope.Resolve<T>(parameters);
        }
    }
}
