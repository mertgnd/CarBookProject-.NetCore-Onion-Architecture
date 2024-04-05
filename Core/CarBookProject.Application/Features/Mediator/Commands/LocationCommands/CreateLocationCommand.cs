using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.LocationCommands
{
    public class CreateLocationCommand : IRequest
    {
        public string LocationName { get; set; }
    }
}
