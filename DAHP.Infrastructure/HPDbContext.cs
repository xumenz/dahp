using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure
{
    public class HPDbContext : DbContext
    {
        public HPDbContext():base("name=HPDbContext")
        {

        }


       public DbSet<Person> Persons { get; set; }

       public DbSet<EmploymentInfo> EmploymentInfos { get; set; }

       public DbSet<Bonus> Bonuses { get; set; }

       public DbSet<CategoryBonus> CategoryBonuses { get; set; }
       public DbSet<CategoryDeduction> CategoryDeductions { get; set; }
       public DbSet <ContactInfo> ContactInfos { get; set; }
       public DbSet<ContactPhone> ContactPhones { get; set; }
       public DbSet<Department> Departments { get; set; }
       public DbSet<DepartmentHeadHistory> DepartmentHeadHistorys { get; set; }
       public DbSet<Designation> Designations { get; set; }
       public DbSet<Education>  Educations { get; set; }
       public DbSet<EmployeeCategory>  EmployeeCategorys { get; set; }
       public DbSet<EmployeeType> EmployeeTypes { get; set; }
       public DbSet<EmploymentHistory> EmploymentHistorys { get; set; }
       public DbSet<GradeLevel> GradeLevels { get; set; }
       public DbSet<JobHistory> JobHistorys { get; set; }
       public DbSet<LevelDetail> LevelDetails { get; set; }
       public DbSet<LGA> lga { get; set; }
       public DbSet<NextOfKin>  NextOfKins { get; set; }
       public DbSet<PaymentSchedule> PaymentSchedules { get; set; }
       public DbSet<PayrollCategory> PayrollCategories { get; set; }
       public DbSet <Qualification> Qualifications { get; set; }
       public DbSet<Query> Queries { get; set; }
       public DbSet<QueryGenerator> QueryGenerators { get; set; }
       public DbSet<ScheduleDeduction> ScheduleDeductions { get; set; }
       public DbSet<State> States { get; set; }
       public DbSet<StateOfOrigin> StateOfOrigins { get; set; }
       public DbSet<Tax> Taxes { get; set; }
       public DbSet<Unit> Units { get; set; }

       
    }
}
