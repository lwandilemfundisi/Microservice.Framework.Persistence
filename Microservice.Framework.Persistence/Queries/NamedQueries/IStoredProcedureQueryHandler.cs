using Microservice.Framework.Persistence.Queries.Filtering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.Framework.Persistence.Queries.NamedQueries
{
    public interface IStoredProcedureQueryHandler<TDomain, TNamedCriteria> 
        where TDomain : class
        where TNamedCriteria : NamedCriteria
    {
        Task<TDomain> Find(IStoredProcedureQuery<TNamedCriteria> namedQuery);

        Task<IEnumerable<TDomain>> FindAll(IStoredProcedureQuery<TNamedCriteria> namedQuery);
    }
}
