using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAHP.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
