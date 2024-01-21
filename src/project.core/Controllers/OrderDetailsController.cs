using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project.core.Data;
using project.core.Models;

namespace project.core
{
    public class OrderDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        // public async Task<IActionResult> Index()
        // {
        //     var applicationDbContext = _context.TicketOrders.Include(o => o.Order).Include(o => o.Ticket);
        //     return View(await applicationDbContext.ToListAsync());
        // }

        // GET: OrderDetails/Details/5

        // GET: OrderDetails/Create
        public IActionResult Create(int OrderId)
        {
            // ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Id");
            ViewData["TicketId"] = _context.Tickets
                .ToList()
                .Select(t => new SelectListItem{
                    Text = t.Name,
                    Value = t.Id.ToString()
                });

            var orderDetails = new OrderDetails { OrderId = OrderId };
            return View(orderDetails);
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketId,OrderId,Count")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDetails);
                await _context.SaveChangesAsync();
                return  RedirectToAction("Details", "Order", new { id = orderDetails.OrderId });
            }
            ViewData["TicketId"] = new SelectList(_context.Tickets, "Id", "Name", orderDetails.TicketId);
            return View(orderDetails);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(od => od.Ticket)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetails = await _context.OrderDetails.FindAsync(id);
            if (orderDetails != null)
            {
                _context.OrderDetails.Remove(orderDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Order", new { id = orderDetails.OrderId });
        }

        private bool OrderDetailsExists(int id)
        {
            return _context.OrderDetails.Any(e => e.Id == id);
        }
    }
}
