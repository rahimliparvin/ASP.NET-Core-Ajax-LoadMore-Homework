using FronttoBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FronttoBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }    
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CompanyDepartment> CompanyDepartments{ get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentImage> DepartmentImages { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Offer> Offers { get; set; }




    }
}
