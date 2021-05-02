using Microservice.Framework.Common;
using System;

namespace Microservice.Framework.Persistence.Queries.Filtering
{
    public class AggregateFilter : BaseFilter
    {
        #region Constructors

        public AggregateFilter(string propertyName, AggregateType aggregateType)
        {
            PropertyName = propertyName;
            AggregateType = aggregateType;
        }

        #endregion

        #region Properties

        public string PropertyName { get; private set; }

        public AggregateType AggregateType { get; private set; }

        #endregion

        #region Virtual Methods

        public override string ToString()
        {
            return "Framework.Persistence.AggregateFilter(Property {0}, AggregateType {1})".FormatInvariantCulture(PropertyName, AggregateType.ToString());
        }

        #endregion
    }
}
