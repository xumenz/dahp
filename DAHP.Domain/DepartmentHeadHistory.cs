using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class DepartmentHeadHistory : BaseEntity
    {
        public Guid EmploymentInfoId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string  Remarks { get; set; }

    }
}
