using Microservice.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microservice.Framework.Persistence.Queries.Filtering
{
    public class SortOrder
    {
        #region Constructors

        public SortOrder(string propertyName)
            : this(propertyName, SortOrderType.Ascending)
        {
        }

        public SortOrder(string propertyName, SortOrderType sortOrderType)
        {
            PropertyName = propertyName;
            SortOrderType = sortOrderType;
        }

        #endregion

        #region Properties

        public SortOrderType SortOrderType { get; set; }

        public string PropertyName { get; set; }

        #endregion

        #region Virtual Methods

        public override string ToString()
        {
            return "Framework.Persistence.SortOrder(PropertyName:{0}, SortOrderType:{1})".FormatInvariantCulture(PropertyName, SortOrderType.ToString());
        }

        #endregion
    }
}
