using CarBookProject.Application.Features.CQRS.Commands.AboutCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AboutID);

            if ( values == null )
            {
                throw new Exception($"{command.AboutID}: Id data not exist in database.");
            }

            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageURL = command.ImageURL;
            await _repository.UpdateAsync(values);
        }
    }
}
