﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class State : BaseEntity
    {
        public string StateName { get; set; }

        public ICollection<Lga> Lgas { get; set; }
    }
}
