using CarBookProject.Application.Features.Mediator.Queries.ServiceQueries;
using CarBookProject.Application.Features.Mediator.Results.ServiceResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository )
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value == null)
            {
                throw new Exception($"{request.Id}: Id data not exist in database.");
            }

            return new GetServiceByIdQueryResult
            {
                ServiceID = value.ServiceID,
                Description = value.Description,
                IconURL = value.IconURL,
                Title = value.Title,
            };
        }
    }
}
