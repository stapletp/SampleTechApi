namespace SampleTechApi.Models
{
    public class ShippingModel
    {
        public Guid Id { get; set; }
        public Location Source { get; set; }
        public Location Destination { get; set; }
    }
}