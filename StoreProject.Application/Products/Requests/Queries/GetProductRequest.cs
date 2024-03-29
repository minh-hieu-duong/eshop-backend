﻿using MediatR;
using StoreProject.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Products.Requests.Queries
{
    public class GetProductRequest : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
