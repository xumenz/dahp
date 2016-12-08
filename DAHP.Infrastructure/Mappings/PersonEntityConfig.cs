using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure.Mappings
{
    public class PersonEntityConfig : EntityTypeConfiguration<Person>
    {
        public PersonEntityConfig()
        {
            HasKey(ps => ps.Id);

            HasMany(ps => ps.ContactInformation).WithRequired()
                .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

            HasMany(ps => ps.ContactPhones).WithRequired()
             .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

            HasMany(ps => ps.WorkExperience).WithRequired()
             .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

            HasMany(ps => ps.Qualifications).WithRequired()
             .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

            HasMany(ps => ps.ProfessionalQualifications).WithRequired()
          .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

            HasMany(ps => ps.Education).WithRequired()
             .HasForeignKey(ci => ci.PersonId).WillCascadeOnDelete(false);

          
        }
    }


    public class NextOfKinEntityConfig : EntityTypeConfiguration<NextOfKin>
    {
        public NextOfKinEntityConfig()
        {
            HasKey(nk => nk.Id);

            HasRequired(nk => nk.Person).WithRequiredDependent().WillCascadeOnDelete(true);
        }
    }

}
