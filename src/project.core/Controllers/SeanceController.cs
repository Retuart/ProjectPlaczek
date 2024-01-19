using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.core.Data; 
using project.core.Models;
using System.Threading.Tasks;

namespace project.core.Controllers
{
    public class SeanceController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public SeanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Seance
        public async Task<IActionResult> Index()
        {
            return _context.seances != null ? 
                    View(await _context.seances
                        .Include(s => s.movie)
                        .Include(s => s.room)
                        .ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.seances' is null.");
        }

        // GET: Seance/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.seances == null)
            {
                return NotFound();
            }

            var seance = await _context.seances
                .Include(s => s.movie)
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (seance == null)
            {
                return NotFound();
            }

            return View(seance);
        }

        // GET: Seance/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Seance/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,id_movie,start,end,id_room")] seanceModel seance)
        {
            if (ModelState.IsValid)
            {
                _context.seances.Add(seance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seance);
        }

        // GET: Seance/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.seances == null)
            {
                return NotFound();
            }

            var seance = await _context.seances.FindAsync(id);
            if (seance == null)
            {
                return NotFound();
            }
            return View(seance);
        }

        // POST: Seance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,id_movie,start,end,id_room")] seanceModel seance)
        {
            if (id != seance.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.seances.Update(seance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeanceExists(seance.id))
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
            return View(seance);
        }

        // GET: Seance/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.seances == null)
            {
                return NotFound();
            }

            var seance = await _context.seances
                .Include(s => s.movie)
                .Include(s => s.room)
                .FirstOrDefaultAsync(m => m.id == id);
            if (seance == null)
            {
                return NotFound();
            }

            return View(seance);
        }

        // POST: Seance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seance = await _context.seances.FindAsync(id);
            if (seance != null)
            {
                _context.seances.Remove(seance);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SeanceExists(int id)
        {
            return _context.seances.Any(e => e.id == id);
        }
    }
}
