using CarBookProject.Application.Features.Mediator.Queries.LocationQueries;
using CarBookProject.Application.Features.Mediator.Results.LocationResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetServiceByIdQueryHandler(IRepository<Location> repository )
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value == null)
            {
                throw new Exception($"{request.Id}: Id data not exist in database.");
            }

            return new GetLocationByIdQueryResult
            {
                LocationID = value.LocationID,
                LocationName = value.LocationName,
            };
        }
    }
}
