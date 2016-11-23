using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Bonus
    {
        public Guid BonusId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
