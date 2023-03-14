using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGK.Models;

namespace SGK.Controllers
{
    public class BelovskayaGresController : Controller
    {
        private readonly ModelContext _context;

        public BelovskayaGresController(ModelContext context)
        {
            _context = context;
        }

        // GET: BelovskayaGres
        public async Task<IActionResult> Index()
        {
              return View(await _context.Belovskayagres.ToListAsync());
        }

        // GET: BelovskayaGres/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Belovskayagres == null)
            {
                return NotFound();
            }

            var belovskayagre = await _context.Belovskayagres
                .FirstOrDefaultAsync(m => m.Time1970 == id);
            if (belovskayagre == null)
            {
                return NotFound();
            }

            return View(belovskayagre);
        }

        // GET: BelovskayaGres/Create
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Graph()
        {
            return View(await _context.Belovskayagres.ToListAsync());
        }

        // POST: BelovskayaGres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Time1970,Val,State")] Belovskayagre belovskayagre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(belovskayagre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(belovskayagre);
        }

        // GET: BelovskayaGres/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Belovskayagres == null)
            {
                return NotFound();
            }

            var belovskayagre = await _context.Belovskayagres.FindAsync(id);
            if (belovskayagre == null)
            {
                return NotFound();
            }
            return View(belovskayagre);
        }

        // POST: BelovskayaGres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Time1970,Val,State")] Belovskayagre belovskayagre)
        {
            if (id != belovskayagre.Time1970)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(belovskayagre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BelovskayagreExists(belovskayagre.Time1970))
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
            return View(belovskayagre);
        }

        // GET: BelovskayaGres/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Belovskayagres == null)
            {
                return NotFound();
            }

            var belovskayagre = await _context.Belovskayagres
                .FirstOrDefaultAsync(m => m.Time1970 == id);
            if (belovskayagre == null)
            {
                return NotFound();
            }

            return View(belovskayagre);
        }

        // POST: BelovskayaGres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Belovskayagres == null)
            {
                return Problem("Entity set 'ModelContext.Belovskayagres'  is null.");
            }
            var belovskayagre = await _context.Belovskayagres.FindAsync(id);
            if (belovskayagre != null)
            {
                _context.Belovskayagres.Remove(belovskayagre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BelovskayagreExists(string id)
        {
          return _context.Belovskayagres.Any(e => e.Time1970 == id);
        }
    }
}
