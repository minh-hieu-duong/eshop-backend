﻿using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Task<Cart> GetCartByUserId(string userId);
        Task<decimal> GetTotalMoney(string userId);
        Task<Cart> CreateCart(string userId);
    }
}
