using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.core.Data;
using project.core.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

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
            return _context.Seances != null ? 
                    View(await _context.Seances
                        .Include(s => s.Movie)
                        .Include(s => s.Room)
                        .ToListAsync()) :
                    Problem("Entity set 'ApplicationDbContext.Seances' is null.");
        }

        // GET: Seance/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Seances == null)
            {
                return NotFound();
            }

            var seance = await _context.Seances
                .Include(s => s.Movie)
                .Include(s => s.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seance == null)
            {
                return NotFound();
            }

            return View(seance);
        }

        // GET: Seance/Create
        public IActionResult Create()
        {
            ViewData["Id_movie"] = new SelectList(_context.Movies, "Id", "Title");
            ViewData["Id_room"] = new SelectList(_context.Rooms, "Id", "Name");
            return View();
        }

        // POST: Seance/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_movie,Start,Id_room")] Seance seance)
        {
            if (ModelState.IsValid)
            {
                // Manually load related entities if needed
                seance.Movie = await _context.Movies.FindAsync(seance.Id_movie);
                seance.Room = await _context.Rooms.FindAsync(seance.Id_room);

                // Validate if the loaded entities are not null (optional, based on your requirements)
                if (seance.Movie == null || seance.Room == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid movie or room");
                    ViewData["Id_movie"] = new SelectList(_context.Movies, "Id", "Title", seance.Id_movie);
                    ViewData["Id_room"] = new SelectList(_context.Rooms, "Id", "Name", seance.Id_room);
                    return View(seance);
                }
                else
                {
                    seance.Start = DateTime.UtcNow;
                    _context.Seances.Add(seance);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["Id_movie"] = new SelectList(_context.Movies, "Id", "Title", seance.Id_movie);
            ViewData["Id_room"] = new SelectList(_context.Rooms, "Id", "Name", seance.Id_room);
            return View(seance);
        }

        // GET: Seance/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Seances == null)
            {
                return NotFound();
            }

            var seance = await _context.Seances.FindAsync(id);
            if (seance == null)
            {
                return NotFound();
            }

            ViewData["Id_movie"] = new SelectList(_context.Movies, "Id", "Title", seance.Id_movie);
            ViewData["Id_room"] = new SelectList(_context.Rooms, "Id", "Name", seance.Id_room);
            return View(seance);
        }

        // POST: Seance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_movie,Start,Id_room")] Seance seance)
        {
            if (id != seance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    seance.Start = DateTime.UtcNow;
                    _context.Seances.Update(seance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeanceExists(seance.Id))
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
            ViewData["Id_movie"] = new SelectList(_context.Movies, "Id", "Title", seance.Id_movie);
            ViewData["Id_room"] = new SelectList(_context.Rooms, "Id", "Name", seance.Id_room);
            return View(seance);
        }

        // GET: Seance/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Seances == null)
            {
                return NotFound();
            }

            var seance = await _context.Seances
                .Include(s => s.Movie)
                .Include(s => s.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var seance = await _context.Seances.FindAsync(id);
            if (seance != null)
            {
                _context.Seances.Remove(seance);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SeanceExists(int id)
        {
            return _context.Seances.Any(e => e.Id == id);
        }
    }
}
