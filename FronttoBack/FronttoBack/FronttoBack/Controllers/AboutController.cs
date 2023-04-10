using FronttoBack.Data;
using FronttoBack.Models;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FronttoBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {

            AboutUs aboutUs = await _context.AboutUses.Where(m=>!m.SoftDelete).FirstOrDefaultAsync();

            Team team = await _context.Teams.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<TeamMember> teamMembers = await _context.TeamMembers.Where(m => !m.SoftDelete).ToListAsync();



            AboutVM model = new()
            {

                AboutUs = aboutUs,
                Team = team,
                TeamMembers = teamMembers

            };




            return View(model);
        }
    }
}
