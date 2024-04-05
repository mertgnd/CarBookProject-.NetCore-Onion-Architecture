using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CarInterFaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarsListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                CarID = x.CarID,
                BrandID = x.BrandID,
                BrandName = x.Brand.Name,
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
