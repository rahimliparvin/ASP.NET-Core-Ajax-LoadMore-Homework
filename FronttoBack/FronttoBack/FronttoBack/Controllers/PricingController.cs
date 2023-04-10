using FronttoBack.Data;
using FronttoBack.Models;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FronttoBack.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            Pricing pricing = await _context.Pricings.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Package> packages = await _context.Packages.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Offer> offers = await _context.Offers.Where(m => !m.SoftDelete).ToListAsync();


            PricingVM model = new()
            {
                Pricing = pricing,
                Packages = packages,
                Offers = offers

            };


            return View(model);
        }
    }
}
