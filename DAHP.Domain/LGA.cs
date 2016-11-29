using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Lga : BaseEntity
    {
        public string LocalGovernmentName { get; set; }
        public Guid State { get; set; }

    }
}
