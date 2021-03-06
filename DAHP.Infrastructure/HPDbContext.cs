﻿using DAHP.Domain;
using DAHP.Infrastructure.Mappings;
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
            Database.SetInitializer(new DatabaseInitializer());
              
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
       public DbSet<EmployeeSalaryInfo> EmployeeSalaryInfos { get; set; }
       public DbSet<EmploymentHistory> EmploymentHistorys { get; set; }
       public DbSet<GradeLevel> GradeLevels { get; set; }
       public DbSet<WorkExperience> JobHistorys { get; set; }
       public DbSet<LevelDetail> LevelDetails { get; set; }
       public DbSet<Lga> Lgas { get; set; }
       public DbSet<NextOfKin>  NextOfKins { get; set; }
       public DbSet<PaymentSchedule> PaymentSchedules { get; set; }
       public DbSet<PayrollCategory> PayrollCategories { get; set; }
       public DbSet<ProfessionalQualification> ProfessionalQualifications { get; set; }
       public DbSet<Qualification> Qualification { get; set; }
       public DbSet<Query> Queries { get; set; }
       public DbSet<QueryGenerator> QueryGenerators { get; set; }
       public DbSet<ScheduleDeduction> ScheduleDeductions { get; set; }
       public DbSet<State> States { get; set; }
       public DbSet<Tax> Taxes { get; set; }
       public DbSet<Unit> Units { get; set; }


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           //base.OnModelCreating(modelBuilder);
           modelBuilder.Configurations.Add(new StateEntityConfig());
           modelBuilder.Configurations.Add(new LgaEntityConfig());

            modelBuilder.Configurations.Add(new DepartmentEntityConfig());
            modelBuilder.Configurations.Add(new UnitEntityConfig());

            modelBuilder.Configurations.Add(new EmployeeCategoryEntityConfig());
            modelBuilder.Configurations.Add(new PersonEntityConfig());
            modelBuilder.Configurations.Add(new EmploymentInfoEntityConfig());
            modelBuilder.Configurations.Add(new NextOfKinEntityConfig());
       /*     modelBuilder.Configurations.Add(new LgaEntityConfig())*/;

        }
    }


    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<HPDbContext>
    {
        protected override void Seed(HPDbContext context)
        {
            base.Seed(context);
            //context.Database.ExecuteSqlCommand("CREATE UNIQUE NONCLUSTERED INDEX IX_StockEntry_DateReceived ON dbo.StockReceiveEntry(DateReceived);");

        }
    }
}
