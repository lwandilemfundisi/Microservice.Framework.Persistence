using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Persistence
{
    public interface IBulkOperationConfiguration
    {
        int DeletionBatchSize { get; }
    }
}
