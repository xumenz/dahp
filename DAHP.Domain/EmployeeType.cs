using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmployeeType
    {
        public string Permanent { get; set; }
        public string Contract { get; set; }
        public string Part_Time { get; set; }
        public Guid EmployeeTypeId { get; set; }

    }
}
