using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Interfaces.CarInterFaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrand();
    }
}
