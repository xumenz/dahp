using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Education : BaseEntity
    {
        public Guid QualificationId { get; set; }
        public string SchoolObtained{ get; set; }
        public DateTime CertificateIssueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public EducationalQualification EducationalQualification { get; set; }
    }

    public enum EducationalQualification
    {
        OLevel = 1,
        ALevel = 2,
        AdvancedDiploma = 3,
        AssociateDegree = 4,
        BachelorsDegree = 5,
        MastersDegree = 6,
        DoctorateDegree = 7,
    }
}
