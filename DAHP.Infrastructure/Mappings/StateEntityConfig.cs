using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure.Mappings
{
    public class StateEntityConfig : EntityTypeConfiguration<State>
    {
        public StateEntityConfig()
        {
            HasKey(st => st.Id);
            HasMany(st => st.Lgas)
                .WithRequired()
                .HasForeignKey(lg => lg.StateId)
                .WillCascadeOnDelete(false);
        }
    }


    public class LgaEntityConfig : EntityTypeConfiguration<Lga>
    {
        public LgaEntityConfig()
        {
            HasKey(st => st.Id);
            HasRequired(st => st.State)
                .WithMany()
                .HasForeignKey(st => st.StateId)
                .WillCascadeOnDelete(false);
        }
    }
}
