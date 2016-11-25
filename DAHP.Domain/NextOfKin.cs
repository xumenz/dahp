using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class NextOfKin : BaseEntity
    {
        public Guid PersonId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Relationship { get; set; }
        public string Phonenumber { get; set; }
        public string ContactAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
