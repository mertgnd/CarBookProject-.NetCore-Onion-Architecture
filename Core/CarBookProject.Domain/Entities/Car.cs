namespace CarBookProject.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string CoverImgURL { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public byte Seats { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageURL { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
