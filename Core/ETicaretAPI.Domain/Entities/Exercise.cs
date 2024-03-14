﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Exercise:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
