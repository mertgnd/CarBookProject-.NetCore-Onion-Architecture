using CarBookProject.Application.Features.Mediator.Commands.FeatureCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FeatureID);

            if ( value == null )
            {
                throw new Exception($"{request.FeatureID}: Id data not exist in database.");
            }

            value.FeatureName = request.FeatureName;
            await _repository.UpdateAsync( value );
        }
    }
}
