using Microservice.Framework.Persistence.Queries.Filtering;
using System;

namespace Microservice.Framework.Persistence
{
    public interface IPersistenceFactory
    {
        IPersistence GetPersistence<TDomain>() where TDomain : class;
        IPersistence GetPersistence(Type type);
    }
}
