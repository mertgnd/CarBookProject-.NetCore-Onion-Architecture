using CarBookProject.Application.Features.CQRS.Commands.BannerCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);

            if ( values == null)
            {
                throw new Exception($"{command.BannerID}: Id data not exist in database.");
            }

            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoURL = command.VideoURL;
            values.VideoDescription = command.VideoDescription;
            await _repository.UpdateAsync(values);
        }
    }
}
