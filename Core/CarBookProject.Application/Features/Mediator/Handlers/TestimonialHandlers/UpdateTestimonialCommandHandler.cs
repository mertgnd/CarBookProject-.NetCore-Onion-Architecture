using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TestiomonialID);

            if (value == null)
            {
                throw new Exception($"{request.TestiomonialID}: Id data not exist in database.");
            }

            value.TestiomonialID = request.TestiomonialID;
            value.ImageURL = request.ImageURL;
            value.Title = request.Title;
            value.Comment = request.Comment;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
