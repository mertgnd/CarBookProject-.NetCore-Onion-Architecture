using CarBookProject.Application.Features.Mediator.Commands.LocationCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemoveServiceCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value == null)
            {
                throw new Exception($"{request.Id}: Id data not exist in database.");
            }

            await _repository.RemoveAsync(value);
        }
    }
}
