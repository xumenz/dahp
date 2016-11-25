using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class ContactPhones
    {
        public Guid ContactPhoneId { get; set; }
        public Guid PersonId { get; set; }
        public string Phonenumber { get; set; }
    }
}
