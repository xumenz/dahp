using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class GradeLevel : BaseEntity
    {
        public Guid Id { get; set; }
        public string LevelInfo { get; set; }
    }
}
