using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmployeeSalaryInfo : BaseEntity 
    {
        public Guid LevelDetailId { get; set; }
        public int Level { get; set; }
        public double Amount { get; set; }
    }
}
