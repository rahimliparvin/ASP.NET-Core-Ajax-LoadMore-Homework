namespace FronttoBack.Models
{
    public class Team : BaseEntity
    {
        public string? Header { get; set; }
        public string? Descripition { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
        

    }
}
