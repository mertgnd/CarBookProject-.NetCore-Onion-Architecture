using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class CreateSocialMediaCommand : IRequest
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}
