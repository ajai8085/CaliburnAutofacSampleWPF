namespace DemoApp {
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using Autofac;
    using System.Linq;
    using Caliburn.Micro.Autofac;
    using System.Windows;
    using DependencyResolution;

    public class AppBootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<DefaultModule>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        
    }
}