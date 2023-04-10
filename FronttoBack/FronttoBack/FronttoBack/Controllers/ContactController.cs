using FronttoBack.Data;
using FronttoBack.Models;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

namespace FronttoBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            Contact contact = await _context.Contacts.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            ContactVM model = new()
            {
                Contact = contact
            };


            return View(model);
        }
    }
}
