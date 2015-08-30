using StructureMap.Configuration.DSL;
using StructureMap.Configuration.DSL.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Graph;

using StructureMap.Building;
using StructureMap.Building.Interception;
using Caliburn.Micro;
using StructureMap.Configuration;


namespace DemoApp
{
    public class EventAggregatorRegistry : Registry
    {
        public EventAggregatorRegistry()
        {
            For<IEventAggregator>()
                .Use<EventAggregator>();


            
            
           
                
        }
        public override void AddType(Type pluginType, Type concreteType, string name)
        {
            base.AddType(pluginType, concreteType, name);
        }
    }
}
