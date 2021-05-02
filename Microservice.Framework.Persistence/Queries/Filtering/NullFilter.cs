using Microservice.Framework.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Persistence.Queries.Filtering
{
    public class NullFilter : BaseFilter
    {
        #region Constructors

        public NullFilter(string property)
        {
            Property = property;
        }

        #endregion

        #region Properties

        public string Property { get; private set; }

        #endregion

        #region Virtual Methods

        public override string ToString()
        {
            return "({0} IS NULL)".FormatInvariantCulture(Property);
        }

        #endregion
    }
}