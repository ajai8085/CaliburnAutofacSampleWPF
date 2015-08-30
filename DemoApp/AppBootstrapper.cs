namespace DemoApp {
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using StructureMap;
    using StructureMap.Graph;
    using StructureMap.Configuration.DSL;
    using System.Linq;

    public class AppBootstrapper : BootstrapperBase
    {

        IContainer _container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {

            _container = new Container(c => c.AddRegistry<DefaultRegistry>());

        }

        protected override object GetInstance(Type service, string key)
        {
            object instance = null;

            if (string.IsNullOrWhiteSpace(key))
            {
                instance = _container.TryGetInstance(service);
            }
            else
            {

                instance = _container.TryGetInstance(service,key);
            }

            if (instance != null)
                return instance;

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service).Cast<object>();

        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<IShell>();
        }
    }
}