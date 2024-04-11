using CarBookProject.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
