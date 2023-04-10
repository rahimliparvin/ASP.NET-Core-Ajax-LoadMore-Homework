namespace FronttoBack.Models
{
    public class TeamMember : BaseEntity
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
