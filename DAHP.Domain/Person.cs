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
        public string NextofKin { get; set; }
        
        public  Guid LgaId { get; set; }
        public virtual Lga Lga { get; set; }
        public Guid StateId { get; set; }
        public virtual State  States { get; set; }


        public ICollection<ContactInfo> ContactInformations { get; set; }
        public ICollection<ContactPhone> ContactPhones { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Qualification> Qualifications { get; set; }

        public ICollection<NextOfKin> NextOfKins { get; set; }

       

    }

}
