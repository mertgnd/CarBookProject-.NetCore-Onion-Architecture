using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public string Name { get; set; }
    }
}
