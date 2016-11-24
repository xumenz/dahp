using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class Education
    {
        public Guid QualificationId { get; set; }
        public string SchoolObtained{ get; set; }
        public DateTime CrtificateIssueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
