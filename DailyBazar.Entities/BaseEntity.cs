﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyBazar.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}
