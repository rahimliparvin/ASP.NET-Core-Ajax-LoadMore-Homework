namespace FronttoBack.Models
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int CompanyDepartmentId { get; set; }
        public CompanyDepartment CompanyDepartment { get; set; }
        public ICollection<DepartmentImage> Images { get; set; }


             
    }
}
