using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Graph;
using Caliburn.Micro;
using StructureMap.Building;
using StructureMap.Building.Interception;

namespace DemoApp
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {

            Scan(
               scan =>
               {
                   scan.TheCallingAssembly();
                   scan.WithDefaultConventions();
                   scan.AssembliesFromApplicationBaseDirectory();
                   scan.LookForRegistries();


               });

            For<IShell>().Use<ShellViewModel>().AlwaysUnique();



        }
    }
}
