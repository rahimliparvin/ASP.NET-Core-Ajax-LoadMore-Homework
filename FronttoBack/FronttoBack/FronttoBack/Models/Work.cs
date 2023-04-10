namespace FronttoBack.Models
{
    public class Work : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int RecentWorkId { get; set; }
        public RecentWork RecentWork { get; set; }

    }
}
