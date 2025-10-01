using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactContext _context;

        public ContactController(ContactContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            // Step 1: Query database 
            var contact = _context.Contacts
            .Include(c => c.Category) // 
            .FirstOrDefault(c => c.ContactId == id);

            // Step 2: Handle not found 
            if (contact == null)
            {
                return NotFound();
            }

            // Step 3: return view with data 
            return View(contact);

        }
        
        
        
    }
}