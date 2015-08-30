using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DependencyResolution
{
    public class CustomInterceptor:InstanceInterceptor
    {
        public object Process(object target, IContext context)
        {
            // manipulate the target object and return a wrapped version
            return wrapTarget(target);
        }

        private object wrapTarget(object target)
        {
            throw new NotImplementedException();
        }
    }


    public class ListenerInterceptor
    {
        public bool MatchesType(Type type)
        {
            return true;
        }
        public object Process(object target, IContext context)
        {
            return target;
        }


    }
}
