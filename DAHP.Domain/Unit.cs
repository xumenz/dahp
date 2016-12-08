using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Unit : BaseEntity
    {
        public string UnitName  { get; set; }
        public ICollection<EmploymentInfo> Employees { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
