using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Maruko.Core.Modules;

namespace Dynamic.Config
{
    public class DynamicConfigModule : KernelModule
    {
        protected override void RegisterModule(ContainerBuilder builder)
        {
            base.RegisterModule(builder);
        }
    }
}
