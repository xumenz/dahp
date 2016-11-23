using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmploymentHistory
    {
        public Guid DesignationId { get; set; }
        public Guid EmploymentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EmploymentCategory { get; set; }
        public int Renumeration { get; set; }
    }
}
