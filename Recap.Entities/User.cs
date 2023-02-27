﻿using Recap.Core.Entity;
using Recap.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Entities
{
    public class User: CoreEntity
    {
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string? Country { get; set; }
    }
}
