using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Persistence
{
    public interface IUniqueConstraintDetectionStrategy
    {
        bool IsUniqueConstraintViolation(Exception exception);
    }
}
