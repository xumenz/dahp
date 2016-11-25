﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmploymentInfo : BaseEntity 
    { 
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public EmployeeType EmploymentType { get; set; }
        public Guid EmplomentCategoryId { get; set; }
        public virtual EmployeeCategory EmployeeCategory { get; set; }
        public Guid DesignationId { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Guid EmployeeSalaryInfo { get; set; }
        public virtual EmployeeSalaryInfo EmployeeSalaryInfo { get; set; }
        public Guid GradeLevelId { get; set; }
        public virtual GradeLevel GradeLevel { get; set; }
        public Guid JobHistory { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public Guid LevelDetail { get; set; }
        public virtual LevelDetail LevelDetail { get; set; }
        public DateTime EmploymentDate { get; set; }

        public ICollection<Query> Queries { get; set; }

    }
}