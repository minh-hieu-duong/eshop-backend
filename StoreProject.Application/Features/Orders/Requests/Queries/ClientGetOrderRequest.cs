﻿using MediatR;
using StoreProject.Application.DTOs.Order;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Orders.Requests.Queries
{
    public class ClientGetOrderRequest : IRequest<OrderClientDto>
    {
        public int Id { get; set; }
    }
}
