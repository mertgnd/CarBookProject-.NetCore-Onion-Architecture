namespace CarBookProject.Application.Features.CQRS.Results.CarResults
{
    public class GetCarWithBrandQueryResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
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
