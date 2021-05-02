using Microservice.Framework.Persistence.Queries.Filtering;

namespace Microservice.Framework.Persistence.Queries.CriteriaQueries
{
    public interface ICriteriaDomainQuery<TDomainCriteria> : IDomainQuery
        where TDomainCriteria : DomainCriteria
    {
        TDomainCriteria BuildDomainCriteria();
    }
}
