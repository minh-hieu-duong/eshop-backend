﻿//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Brands.Requests.Commands;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Application.DTOs.Brand.Validators;
//using StoreProject.Application.Exceptions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Brands.Handlers.Commands
//{
//    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, Unit>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public UpdateBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<Unit> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
//        {
            

//            return Unit.Value;
//        }
//    }
//}