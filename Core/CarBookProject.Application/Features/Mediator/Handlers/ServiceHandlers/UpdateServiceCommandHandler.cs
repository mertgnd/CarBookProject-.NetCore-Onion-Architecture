using CarBookProject.Application.Features.Mediator.Commands.ServiceCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ServiceID);

            if (value == null)
            {
                throw new Exception($"{request.ServiceID}: Id data not exist in database.");
            }

            value.ServiceID = request.ServiceID;
            value.Title = request.Title;
            value.Description = request.Description;
            value.IconURL = request.IconURL;
            await _repository.UpdateAsync(value);
        }
    }
}
