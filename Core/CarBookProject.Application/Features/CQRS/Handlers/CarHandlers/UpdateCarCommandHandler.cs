using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            
            if (values == null)
            {
                throw new Exception($"{command.CarID}: Id data not exist in database.");
            }

            values.Fuel = command.Fuel;
            values.Transmission = command.Transmission;
            values.BigImageURL = command.BigImageURL;
            values.CoverImgURL = command.CoverImgURL;
            values.BrandID = command.BrandID;
            values.Seats = command.Seats;
            values.Model = command.Model;
            values.Mileage = command.Mileage;
            values.Luggage = command.Luggage;
            await _repository.UpdateAsync(values);
        }
    }
}
