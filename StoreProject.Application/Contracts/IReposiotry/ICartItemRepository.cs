﻿using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
        Task<CartItem> GetCartItem(int cartId, int productId);
        Task<CartItem> GetCartItemDetail(int cartItemId);
        Task<bool> IsItemOwnedByUser(int cartItemId, string userId);
        Task<CartItem> DeleteById(int cartItemId);
    }
}
