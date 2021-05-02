using Microservice.Framework.Persistence.Queries.Filtering;
using System.Collections.Generic;

namespace Microservice.Framework.Persistence.Queries.NamedQueries
{
    public interface IStoredProcedureQuery : IDomainQuery
    {
        string Name { get; }

        NamedCriteria BuildNamedCriteria();
    }
}
