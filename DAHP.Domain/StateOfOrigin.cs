﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class StateOfOrigin : BaseEntity
    {
        public Guid StateId { get; set; }
        public string StateOfOrigin { get; set; }

    }
}