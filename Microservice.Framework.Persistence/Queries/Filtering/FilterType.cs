using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microservice.Framework.Persistence.Queries.Filtering
{
    public enum FilterType
    {
        Equal,
        NotEqual,
        GreaterThanOrEqualTo,
        GreaterThan,
        In,
        NotIn,
        LessThanOrEqualTo,
        LessThan,
        Like,
        NotNull,
        NotEmpty,
        Null,
        StartsWith
    }
}
