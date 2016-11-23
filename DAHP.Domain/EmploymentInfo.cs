using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmploymentInfo
    {
        public Guid EmploymentInfoId { get; set; }
        public Guid PersonId { get; set; }
        public Guid EmploymentTypeId { get; set; }
        public Guid EmplomentCategoryId { get; set; }
        public Guid DesignationId { get; set; }
        public DateTime EmploymentDate { get; set; }

    }
}
