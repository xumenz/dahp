using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class ContactInfo : BaseEntity
    {
        public Guid PersonId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public AddressType AddressType { get; set; }
        public Guid lgaId { get; set; }

        public bool IsCurrent { get; set; }
    }

    public enum AddressType
    {
        Mailing,
        Permanent
    }
}
