﻿using AutoMapper;
using MediatR;
using StoreProject.Application.Categories.Requests.Commands;
using StoreProject.Application.Contracts.IReposiotry;


namespace StoreProject.Application.Categories.Handlers.Commands
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {

            //var category = await _unitOfWork.CategoryRepository.Get(request.Id);



            //await _unitOfWork.CategoryRepository.Delete(category);
            //await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}