using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class CategoryDeduction : BaseEntity
    {
        
        public DateTime DeductionDate { get; set; }
        public double DeductionAmount { get; set; }
    }
}
