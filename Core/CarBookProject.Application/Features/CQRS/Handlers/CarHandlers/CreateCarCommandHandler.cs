using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System.Runtime.CompilerServices;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageURL = command.BigImageURL,
                Fuel = command.Fuel,
                Luggage = command.Luggage,
                Mileage = command.Mileage,
                Model = command.Model,
                Seats = command.Seats,
                Transmission = command.Transmission,
                CoverImgURL = command.CoverImgURL,
                BrandID = command.BrandID,
            });
        }
    }
}
