namespace FronttoBack.Models
{
    public class DepartmentImage : BaseEntity
    {
        public string? Image { get; set; }
        public bool IsMain { get; set; } = false;
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
