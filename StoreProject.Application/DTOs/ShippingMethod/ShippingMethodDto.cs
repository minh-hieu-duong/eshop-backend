﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ShippingMethod
{
    public class ShippingMethodDto : BaseDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
