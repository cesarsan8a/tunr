using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using tunr.Data;
using tunr.Models;


namespace tunr.Controllers
{
    public class Mixtapes : Controller
    {
        private readonly tunrContext _context;

        public Mixtapes(tunrContext context)
        {
            _context = context;
        }

        // GET: Mixtapes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mixtapes.ToListAsync());
        }

        // GET: Mixtapes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mixtape = await _context.Mixtapes.FirstOrDefaultAsync(m => m.ID == id);
            if (mixtape == null)
            {
                return NotFound();
            }

            return View(mixtape);
        }

        //GET: Mixtapes/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View(await _context.Mixtapes.ToListAsync());
        }

        // POST: Mixtapes/ShowSearchResults
        //public async Task<IActionResult> ShowSearchResults( string stringSearch)
        //{
        //    var searchResult = new Mixtape
        //    {
        //        //Tags = await _context.Mixtapes.Where(j => j.Tags.Contains(stringSearch)).ToListAsync()
        //        //Title = await mixtapeTitles.ToListAsync()
        //    };

        //    return View("Index", searchResult);
        //}

        //GET: Mixtapes/New
        public IActionResult New()
        {
            return View();
        }

        // POST: Mixtapes/New
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> New([Bind("ID, Title, Tags")] Mixtape mixtape)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mixtape);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mixtape);
        }

        // GET: Mixtapes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mixtape = await _context.Mixtapes.FindAsync(id);
            if (mixtape == null)
            {
                return NotFound();
            }
            return View(mixtape);
        }

        // POST: Mixtapes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind("ID, Title, Tags")] Mixtape mixtape)
        {
            if (id != mixtape.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mixtape);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MixtapeExists(mixtape.ID))
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
            return View(mixtape);
        }

        // GET: Mixtapes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mixtape = await _context.Mixtapes.FirstOrDefaultAsync(m => m.ID == id);
            if (mixtape == null)
            {
                return NotFound();
            }

            return View(mixtape);
        }

        // POST: Mixtapes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mixtape = await _context.Mixtapes.FindAsync(id);
            _context.Mixtapes.Remove(mixtape);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MixtapeExists(int id)
        {
            return _context.Mixtapes.Any(e => e.ID == id);
        }
    }
}
