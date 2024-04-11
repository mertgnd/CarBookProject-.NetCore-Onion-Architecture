using CarBookProject.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Testimonial
            {
                Comment = request.Comment,
                ImageURL = request.ImageURL,
                Name = request.Name,
                Title = request.Title,
            });
        }
    }
}
