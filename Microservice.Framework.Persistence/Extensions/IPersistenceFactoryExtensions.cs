using Microservice.Framework.Common;
using Microservice.Framework.Persistence.Queries.Filtering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microservice.Framework.Persistence.Extensions
{
    public static class IPersistenceFactoryExtensions
    {
        public static async Task SaveAsync<TDomainCriteria>(this IPersistenceFactory persistanceFactory, object entity)
            where TDomainCriteria : DomainCriteria
        {
            Invariant.IsNotNull(persistanceFactory, () => $"IPersistenceFactory null in '{typeof(IPersistenceFactoryExtensions).PrettyPrint()}'");
            await persistanceFactory.GetPersistence(entity.GetType()).Save(entity, CancellationToken.None);
        }

        public static async Task SaveAsync<TDomain, TDomainCriteria>(this IPersistenceFactory persistanceFactory, TDomain entity)
            where TDomain : class
            where TDomainCriteria : DomainCriteria
        {
            Invariant.IsNotNull(persistanceFactory, () => $"IPersistenceFactory null in '{typeof(IPersistenceFactoryExtensions).PrettyPrint()}'");
            await persistanceFactory.GetPersistence<TDomain>().Save(entity, CancellationToken.None);
        }
    }
}
