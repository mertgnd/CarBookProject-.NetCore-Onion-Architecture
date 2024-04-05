using CarBookProject.Application.Features.Mediator.Commands.LocationCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdatePricingCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.LocationID);

            if (value == null)
            {
                throw new Exception($"{request.LocationID}: Id data not exist in database.");
            }

            value.LocationName = request.LocationName;
            await _repository.UpdateAsync(value);
        }
    }
}
