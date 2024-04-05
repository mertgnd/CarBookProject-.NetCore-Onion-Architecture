using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
    }
}
