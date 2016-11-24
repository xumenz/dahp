using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAHP.Domain
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Othernames { get; set; }

        public Gender Gender { get; set; }
        public DateTime  DateofBirth { get; set; }

        public  Guid LgaId { get; set; }
        public virtual LGA Lga { get; set; }

        public ICollection<ContactInfo> ContactInformations { get; set; }
        public ICollection<ContactPhone> ContactPhones { get; set; }

    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
