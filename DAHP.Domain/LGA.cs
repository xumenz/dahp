﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class LGA
    {
        public Guid lgaId { get; set; }
        public string LocalGovernmentName { get; set; }
        public Guid State { get; set; }

    }
}
