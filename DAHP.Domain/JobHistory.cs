using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class JobHistory : BaseEntity
    {
        public string JobExperience { get; set; }
        public string Designation { get; set; }
        public string JobDescription { get; set; }
        public Guid PersonId { get; set; }
    }
}
