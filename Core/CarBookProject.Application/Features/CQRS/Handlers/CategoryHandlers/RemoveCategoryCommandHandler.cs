using CarBookProject.Application.Features.CQRS.Commands.CategoryCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System.Runtime.CompilerServices;

namespace CarBookProject.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public RemoveCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);

            if ( value == null )
            {
                throw new Exception($"{command.Id}: Id data already not exist in database.");
            }

            await _repository.RemoveAsync(value);
        }
    }
}
