using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public RemoveTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value == null)
            {
                throw new Exception($"{request.Id}: Id data not exist in database.");
            }

            await _repository.RemoveAsync(value);
        }
    }
}
