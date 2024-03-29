﻿using Microservice.Framework.Persistence.Queries.Filtering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microservice.Framework.Persistence
{
    public interface IPersistence
        
    {
        Task Dispose(CancellationToken cancellationToken);

        Task<IEnumerable<TModel>> ExecuteStoredProcedure<TModel>(
            NamedCriteria namedCriteria, 
            CancellationToken cancellationToken);

        Task<IList<TDomain>> GetAll<TDomain, TDomainCriteria>(
            TDomainCriteria domainCriteria, 
            CancellationToken cancellationToken)
            where TDomain : class
            where TDomainCriteria : DomainCriteria;

        Task<TDomain> Get<TDomain, TDomainCriteria>(
            TDomainCriteria domainCriteria, 
            CancellationToken cancellationToken)
            where TDomain : class
            where TDomainCriteria : DomainCriteria;

        Task Save<TDomain>(
            TDomain domain, 
            CancellationToken cancellationToken)
            where TDomain : class;

        Task Update<TDomain>(
            TDomain domain,
            CancellationToken cancellationToken)
            where TDomain : class;

        Task Delete<TDomain>(
            TDomain domain, 
            CancellationToken cancellationToken)
            where TDomain : class;
    }
}
