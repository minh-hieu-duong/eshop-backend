﻿using MediatR;


namespace StoreProject.Application.Categories.Commands.Create
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
