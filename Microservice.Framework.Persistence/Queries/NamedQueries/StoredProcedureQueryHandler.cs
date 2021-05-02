using Microservice.Framework.Persistence.Queries;
using Microservice.Framework.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Microservice.Framework.Persistence.Queries.NamedQueries
{
    public class StoredProcedureQueryHandler<TModel> : IStoredProcedureQueryHandler<TModel> where TModel : class
    {
        private readonly IPersistenceFactory _persistenceFactory;

        public StoredProcedureQueryHandler(IPersistenceFactory persistenceFactory)
        {
            _persistenceFactory = persistenceFactory;
        }

        public async Task<TModel> Find(IStoredProcedureQuery namedQuery)
        {
            var results = await FindAll(namedQuery);
            Invariant.IsFalse(results.Count() > 1, () => "More than one result found for query: {0}".FormatInvariantCulture(this));
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<TModel>> FindAll(IStoredProcedureQuery namedQuery)
        {
            var results = await ExecuteQueryResults(namedQuery);
            results = OnFindAll(results);
            return results;
        }

        public virtual IEnumerable<TModel> OnFindAll(IEnumerable<TModel> results)
        {
            return results;
        }

        protected virtual IEnumerable<TModel> OnAfterQueryExecuted(IEnumerable<TModel> results)
        {
            return results;
        }

        #region Private Methods

        private async Task<IEnumerable<TModel>> ExecuteQueryResults(IStoredProcedureQuery storedProcedureQuery)
        {
            var repository = _persistenceFactory.GetPersistence(storedProcedureQuery.GetType());
            Invariant.IsNotNull(repository, () => $"IPersistence is null for '{storedProcedureQuery.GetType().PrettyPrint()}'");
            var queryResults = await repository.ExecuteStoredProcedure<TModel>(storedProcedureQuery.BuildNamedCriteria(), CancellationToken.None);
            OnAfterQueryExecuted(queryResults);
            return queryResults;
        }

        #endregion
    }
}
