using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }

        public ICollection<Unit> Units { get; set; }
    }
}
