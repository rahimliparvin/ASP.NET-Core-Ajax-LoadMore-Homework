using FronttoBack.Models;

namespace FronttoBack.ViewModels
{
    public class PricingVM
    {
        public Pricing Pricing { get; set; }

        public IEnumerable<Package> Packages { get; set; }

        public IEnumerable<Offer> Offers { get; set; }


    }
}
