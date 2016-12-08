using DAHP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Infrastructure.Mappings
{
    public class DepartmentEntityConfig : EntityTypeConfiguration<Department>
    {
        public DepartmentEntityConfig()
        {
            HasKey(dp => dp.Id);
            HasMany(dp => dp.Units).WithRequired()
                .HasForeignKey(emp => emp.DepartmentId).WillCascadeOnDelete(false);
        }
    }


    public class UnitEntityConfig : EntityTypeConfiguration<Unit>
    {
        public UnitEntityConfig()
        {
            HasKey(dp => dp.Id);
            HasMany(dp => dp.Employees).WithRequired()
                .HasForeignKey(emp => emp.UnitId).WillCascadeOnDelete(false);
        }
    }
}
