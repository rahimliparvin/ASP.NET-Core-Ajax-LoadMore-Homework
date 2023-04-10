namespace FronttoBack.Models
{
    public class RecentWork : BaseEntity
    {
        public string? Header { get; set; }
        public ICollection<Work> Works { get; set;}

    }
}
