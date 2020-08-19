﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSecondLevelCache.DataLayer.Entities
{
    public class TagProduct
    {
        public int TagId { get; set; }
        public int ProductProductId { get; set; }


        public virtual Product Product { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
