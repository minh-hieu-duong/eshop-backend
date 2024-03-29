﻿using StoreProject.Application.DTOs.CartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Cart
{
    public class CartDto : BaseDto
    {
        public string UserId { get; set; }
        public ICollection<CartItemDto> CartItems { get; set; }

    }
}
