namespace FronttoBack.Models
{
    public class Pricing : BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set;}
        public ICollection<Package> Packages { get; set; }

    }
}
