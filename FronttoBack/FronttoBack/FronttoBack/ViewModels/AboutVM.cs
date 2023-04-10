using FronttoBack.Models;

namespace FronttoBack.ViewModels
{
    public class AboutVM
    {
        public AboutUs AboutUs { get; set; }
        public Team Team { get; set; }
        public IEnumerable<TeamMember> TeamMembers { get; set; } 



    }
}
