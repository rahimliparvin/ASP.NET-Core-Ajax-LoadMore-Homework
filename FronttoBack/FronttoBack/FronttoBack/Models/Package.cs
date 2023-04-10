namespace FronttoBack.Models
{
    public class Package : BaseEntity
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public ICollection<Offer> Offers { get; set; }


    }
}
