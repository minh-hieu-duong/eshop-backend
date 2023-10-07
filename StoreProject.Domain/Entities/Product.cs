﻿using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Product : BaseDomainEntity
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string ImageUrl { get; set; }

    }
}
