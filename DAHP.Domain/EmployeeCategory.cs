using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmployeeCategory : BaseEntity
    {
        public string CategoryName { get; set; }

        public ICollection<EmploymentInfo> Employees { get; set; }

    }
}
