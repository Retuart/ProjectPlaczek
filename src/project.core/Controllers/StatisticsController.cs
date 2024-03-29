using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.core.Data;
using project.core.Models.DTO;


namespace project.core.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StatisticsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int seanceId)
        {
            var seance = await _context.Seances
                .Include(s => s.Movie) 
                .Include(s => s.Orders)
                    .ThenInclude(o => o.OrderDetails)
                        .ThenInclude(od => od.Ticket)
                .FirstOrDefaultAsync(s => s.Id == seanceId);


            if (seance == null)
                return NotFound();

            var stats = new SeanceStatisticsViewModel
            {
                SeanceId = seanceId,
                MovieName = seance.MovieName(),
                TotalTicketsSold = seance.Orders.Sum(o => o.TicketCount()),
                TotalRevenue = seance.Orders.Sum(o => o.PriceSum()),
                TicketsSoldDetails = seance.Orders
                                      .SelectMany(o => o.OrderDetails)
                                      .GroupBy(od => od.Ticket.Name)
                                      .Select(g => new TicketSaleDetails
                                      {
                                          TicketName = g.Key,
                                          QuantitySold = g.Sum(od => od.Count),
                                          Revenue = g.Sum(od => od.PriceSum())
                                      }).ToList()
            };

            return View(stats);
        }
    }
}
