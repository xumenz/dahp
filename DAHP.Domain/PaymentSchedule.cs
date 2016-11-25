using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class PaymentSchedule
    {
        public Guid PayrollCategoryId { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public virtual ICollection<Bonus> Bonuses { get; set; }
        
    }
}
