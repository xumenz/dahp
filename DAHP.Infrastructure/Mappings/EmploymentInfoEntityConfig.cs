using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure.Mappings
{


    public class EmployeeCategoryEntityConfig : EntityTypeConfiguration<EmployeeCategory>
    {
        public EmployeeCategoryEntityConfig()
        {
            HasKey(ec => ec.Id);

            HasMany(ec => ec.Employees)
                .WithRequired()
                .HasForeignKey(em => em.EmployeeCategoryId)
                .WillCascadeOnDelete(false);
        }

    }
    public class EmploymentInfoEntityConfig : EntityTypeConfiguration<EmploymentInfo>
    {
        public EmploymentInfoEntityConfig()
        {
            HasKey(em => em.Id);

            HasRequired(em => em.Person)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);

            HasRequired(em => em.Unit)
                .WithMany()
                .HasForeignKey(em => em.UnitId)
                .WillCascadeOnDelete(false);


            HasRequired(em => em.EmployeeCategory)
                   .WithMany()
                .HasForeignKey(em => em.EmployeeCategoryId)
                .WillCascadeOnDelete(false);


            HasMany(em => em.EmploymentHistory)
                .WithRequired()
                .HasForeignKey(wk => wk.EmploymentInfoId)
                .WillCascadeOnDelete(false);

            HasMany(em => em.Queries)
             .WithRequired()
             .HasForeignKey(wk => wk.EmployementInfoId)
             .WillCascadeOnDelete(false);

        }
    }
}
