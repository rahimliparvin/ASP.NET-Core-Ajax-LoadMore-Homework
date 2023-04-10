namespace FronttoBack.Models
{
    public class Offer : BaseEntity
    {
        public string? Feature { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
    }
}
