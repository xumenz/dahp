using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
   public class LevelDetail : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid GradeLevelId { get; set; }
        public int Steps { get; set; }
        public double Amount { get; set; }
    }
}
