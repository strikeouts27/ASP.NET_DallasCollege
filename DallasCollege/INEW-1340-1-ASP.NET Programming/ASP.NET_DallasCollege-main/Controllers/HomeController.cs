using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PriceQuotationApp.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        // -----------------------------
        // GET: Index
        // -----------------------------
        // PSEUDOCODE:
        // 1. Set ViewBag.Discount = 0
        // 2. Set ViewBag.Total = 0
        // 3. Return the view (optional: pass a new Quotation object)
        // Learn: Passing data with ViewBag
        //   https://learn.microsoft.com/aspnet/core/mvc/views/overview
        // Murach: Ch.2 – “How a controller and its action methods work”
        [HttpGet]
        public IActionResult Index()
        {
            // TODO: Replace pseudocode with real C#

            ViewBag.Discount = 0; 
            ViewBag.Tax = 0;
            ViewBag.Total = 0;  
            
            var quote = new Quotation();
            return View(quote);
        }

        // -----------------------------
        // POST: Index
        // -----------------------------
        // PSEUDOCODE:
        // 1. If ModelState is valid
        //      - Calculate discount using quote.CalculateDiscount()
        //      - Calculate total using quote.CalculateTotal()
        //      - Store both in ViewBag
        // 2. Else
        //      - Reset ViewBag.Discount = 0
        //      - Reset ViewBag.Total = 0
        // 3. Return the view and pass the quote back
        // Learn: ModelState validation
        //   https://learn.microsoft.com/aspnet/core/mvc/models/validation
        // Murach: Ch.2 – “An action method that checks for invalid data”
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Quotation quote)
        {
            // TODO: Replace pseudocode with real C#
            if (ModelState.IsValid)
            {
                ViewBag.Discount = quote.CalculateDiscount(quote.Subtotal, quote.DiscountPercent);
                
                // Calculate tax on the subtotal after discount
                decimal tax = 0m;
                if (quote.Subtotal.HasValue && quote.TaxRate.HasValue)
                {
                    decimal subtotalAfterDiscount = quote.Subtotal.Value - quote.CalculateDiscount(quote.Subtotal, quote.DiscountPercent);
                    tax = subtotalAfterDiscount * (quote.TaxRate.Value / 100);
                    tax = Math.Round(tax, 2);
                }
                ViewBag.Tax = tax;
                
                ViewBag.Total = quote.CalculateTotal();
            }
            else
            {
                ViewBag.Discount = 0;
                ViewBag.Tax = 0;
                ViewBag.Total = 0;
            }
            return View(quote);
        }

        // -----------------------------
        // GET: Clear
        // -----------------------------
        // PSEUDOCODE:
        // 1. Clear the ModelState
        // 2. Redirect to Index (GET)
        // Learn: RedirectToAction


        //   https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction
        // Murach: Ch.1 – “How request URLs map to controllers and actions by default”
        [HttpGet]
        public IActionResult Clear()
        {
            // Clear ModelState
            ModelState.Clear();
            // Redirect to Index (GET)
            return RedirectToAction(nameof(Index));
        }
    }
}
