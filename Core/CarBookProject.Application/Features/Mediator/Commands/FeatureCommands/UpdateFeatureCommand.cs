using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
    }
}
