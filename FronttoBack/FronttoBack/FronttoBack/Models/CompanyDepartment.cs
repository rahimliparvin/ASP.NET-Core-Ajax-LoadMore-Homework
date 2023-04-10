namespace FronttoBack.Models
{
    public class CompanyDepartment : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<Department> Department { get; set; }

    }
}
