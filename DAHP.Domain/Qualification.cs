using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Qualification : BaseEntity
    {
        public string QualificationName { get; set; }
        public DateTime DateObtained { get; set; }
        public Guid PersonId { get; set; }
    }
}
