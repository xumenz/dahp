using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
   public class ProfessionalQualification : BaseEntity
    {
        //public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public DateTime DateObtained { get; set; }
        public string CertificateName { get; set; }
    }
}
