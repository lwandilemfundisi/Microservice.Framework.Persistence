using Microservice.Framework.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Persistence
{
    public interface IPersistenceConfiguration
    {
        void ConfigurePersistence(IServiceProvider serviceProvider);
    }
}
