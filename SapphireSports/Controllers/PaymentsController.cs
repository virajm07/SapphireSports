using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SapphireSports.Areas.Identity.Data;
using SapphireSports.Models;

namespace SapphireSports.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly SapphireSportsContext _context;

        public PaymentsController(SapphireSportsContext context)
        {
            _context = context;
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            var sapphireSportsContext = _context.Payments.Include(p => p.Customer).Include(p => p.Order);
            return View(await sapphireSportsContext.ToListAsync());
        }

        // GET: Payments/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payments = await _context.Payments
                .Include(p => p.Customer)
                .Include(p => p.Order)
                .FirstOrDefaultAsync(m => m.PaymentID == id);
            if (payments == null)
            {
                return NotFound();
            }

            return View(payments);
        }

        // GET: Payments/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address");
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderDate");
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentID,OrderID,CustomerID,PayAmount,PaymentMethod,PaymentDate")] Payments payments)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(payments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", payments.CustomerID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderDate", payments.OrderID);
            return View(payments);
        }

        // GET: Payments/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payments = await _context.Payments.FindAsync(id);
            if (payments == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", payments.CustomerID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderDate", payments.OrderID);
            return View(payments);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentID,OrderID,CustomerID,PayAmount,PaymentMethod,PaymentDate")] Payments payments)
        {
            if (id != payments.PaymentID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(payments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentsExists(payments.PaymentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "Address", payments.CustomerID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderDate", payments.OrderID);
            return View(payments);
        }

        // GET: Payments/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payments = await _context.Payments
                .Include(p => p.Customer)
                .Include(p => p.Order)
                .FirstOrDefaultAsync(m => m.PaymentID == id);
            if (payments == null)
            {
                return NotFound();
            }

            return View(payments);
        }

        // POST: Payments/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payments = await _context.Payments.FindAsync(id);
            if (payments != null)
            {
                _context.Payments.Remove(payments);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentsExists(int id)
        {
            return _context.Payments.Any(e => e.PaymentID == id);
        }
    }
}
