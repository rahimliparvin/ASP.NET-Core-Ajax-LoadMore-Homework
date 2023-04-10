using FronttoBack.Data;
using FronttoBack.Models;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FronttoBack.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            Slider slider = await _context.Sliders.Where(m=>!m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<SliderInfo> sliderInfos = await _context.SliderInfos.Where(m => !m.SoftDelete).ToListAsync();

            Service service = await _context.Services.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<CompanyDepartment> companyDepartments = await _context.CompanyDepartments.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Department> departments = await _context.Departments.Include(m=> m.CompanyDepartment).Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            RecentWork recentWork = await _context.RecentWorks.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Work> works = await _context.Works.Where(m => !m.SoftDelete).ToListAsync();




            HomeVM model = new()
            {
                Slider = slider,
                SliderInfo = sliderInfos,
                Service = service,
                CompanyDepartments = companyDepartments,
                Departments = departments,
                RecentWork = recentWork,
                Works = works
     

            };


            return View(model);
        }








    }
}