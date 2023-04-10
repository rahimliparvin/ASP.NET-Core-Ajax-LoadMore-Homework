using FronttoBack.Models;

namespace FronttoBack.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }

        public IEnumerable<SliderInfo> SliderInfo { get; set; }
        public Service Service { get; set; }

        public IEnumerable<CompanyDepartment> CompanyDepartments { get; set; }

        public IEnumerable<Department> Departments { get; set; }

        public RecentWork RecentWork { get; set; }

        public IEnumerable<Work> Works { get; set; }

    }
}
