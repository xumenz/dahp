using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmploymentHistory : BaseEntity 
    { 
        public Guid EmploymentInfoId { get; set; }
        public EmployeeType EmploymentType { get; set; }
        public Guid EmplomentCategoryId { get; set; }
        public Guid DesignationId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid GradeLevelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
