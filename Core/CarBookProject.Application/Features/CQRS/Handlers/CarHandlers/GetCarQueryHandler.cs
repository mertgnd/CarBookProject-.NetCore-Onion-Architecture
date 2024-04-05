using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                CarID = x.CarID,
                BrandID = x.BrandID,
                BigImageURL = x.BigImageURL,
                CoverImgURL = x.CoverImgURL,
                Fuel = x.Fuel,
                Luggage = x.Luggage,
                Mileage = x.Mileage,
                Model = x.Model,
                Seats = x.Seats,
                Transmission = x.Transmission,
            }).ToList();
        }
    }
}
