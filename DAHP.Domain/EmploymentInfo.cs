using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmploymentInfo : BaseEntity 
    { 
        public Person Person { get; set; }
        public EmployeeType EmploymentType { get; set; }
        public Guid EmployeeCategoryId { get; set; }
        public virtual EmployeeCategory EmployeeCategory { get; set; }
        public Guid DesignationId { get; set; }

        public virtual Designation  Designation { get; set; }
        public Guid UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public Guid GradeLevelId { get; set; }
        public virtual GradeLevel GradeLevel { get; set; }
        public ICollection<EmploymentHistory> EmploymentHistory { get; set; }
        public DateTime EmploymentDate { get; set; }

        public ICollection<Query> Queries { get; set; }

    }
}
