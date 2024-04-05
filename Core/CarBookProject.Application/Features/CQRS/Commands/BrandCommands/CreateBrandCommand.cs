using CarBookProject.Domain.Entities;

namespace CarBookProject.Application.Features.CQRS.Commands.BrandCommands
{
    public class CreateBrandCommand
    {
        public string Name { get; set; }
    }
}
