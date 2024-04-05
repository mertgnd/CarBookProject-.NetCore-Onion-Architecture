namespace CarBookProject.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }

        public List<CarFeature> CarFeatures { get; set; }
    }
}
