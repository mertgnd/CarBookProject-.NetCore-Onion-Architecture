using MediatR;

namespace CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand : IRequest
    {
        public int TestiomonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
    }
}
