using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice.Framework.Persistence.Queries.NamedQueries
{
    public interface IStoredProcedureQueryHandler<TDomain> where TDomain : class
    {
        Task<TDomain> Find(IStoredProcedureQuery namedQuery);

        Task<IEnumerable<TDomain>> FindAll(IStoredProcedureQuery namedQuery);
    }
}
