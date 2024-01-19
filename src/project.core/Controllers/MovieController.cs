using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.core.Data;
using project.core.Models;

namespace project.core.Controllers;

[Authorize]
public class MovieController : Controller
{
    private readonly ApplicationDbContext _context;

    public MovieController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var movies = _context.movies.ToListAsync();
        return View(await movies);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.movies == null)
        {
            return NotFound();
        }

        var movie = _context.movies.FirstOrDefaultAsync();
        if (movie == null)
        {
            return NotFound();
        }
        return View(await movie);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("id,title,description,duration,image")] movieModel movie)
    {
        if (ModelState.IsValid)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(movie);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.movies == null)
        {
            return NotFound();
        }

        var movie = await _context.movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("id,title,description,duration,image")] movieModel movie)
    {
        if (id != movie.id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(movie.id))
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
        return View(movie);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.movies == null)
        {
            return NotFound();
        }

        var movie = await _context.movies.FirstOrDefaultAsync(m => m.id == id);
        if (movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (_context.movies == null)
        {
            return Problem("Entity set 'ApplicationDbContext.movies'  is null.");
        }
        var movie = await _context.movies.FindAsync(id);
        if (movie != null)
        {
            _context.movies.Remove(movie);
        }
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MovieExists(int id)
    {
        return (_context.movies?.Any(e => e.id == id)).GetValueOrDefault();
    }
}