﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class CategoryBonus : BaseEntity
    {
       
        public string BonusDescription { get; set; }
        public  double BonusAmount { get; set; }
    }
}
