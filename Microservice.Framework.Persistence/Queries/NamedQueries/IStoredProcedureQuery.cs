using Microservice.Framework.Persistence.Queries.Filtering;
using System.Collections.Generic;

namespace Microservice.Framework.Persistence.Queries.NamedQueries
{
    public interface IStoredProcedureQuery<TNamedCriteria> : IDomainQuery
        where TNamedCriteria : NamedCriteria
    {
        string Name { get; }

        TNamedCriteria BuildNamedCriteria();
    }
}
