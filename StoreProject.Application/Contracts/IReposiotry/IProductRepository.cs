﻿using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable<Product> GetProductsWithProductAttribute(string? SearchTerm, int? CategoryId);
    }
}
