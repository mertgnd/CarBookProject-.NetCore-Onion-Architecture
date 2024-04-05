namespace CarBookProject.Application.Features.CQRS.Commands.CarCommands
{
    public class CreateCarCommand
    {
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string CoverImgURL { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public byte Seats { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageURL { get; set; }
    }
}
