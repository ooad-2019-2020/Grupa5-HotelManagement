using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_hotel_implementacija.Models;
using Microsoft.AspNetCore.Authorization;

namespace E_hotel_implementacija.Controllers
{
    
    public class SistemskaGreskaController : Controller
    {
        private readonly NasContext _context;

        public SistemskaGreskaController(NasContext context)
        {
            _context = context;
        }

        // GET: SistemskaGreska
        public async Task<IActionResult> Index()
        {
            return View(await _context.SistemskeGreske.ToListAsync());
        }

        // GET: SistemskaGreska/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemskaGreska = await _context.SistemskeGreske
                .FirstOrDefaultAsync(m => m.SistemskaGreskaId == id);
            if (sistemskaGreska == null)
            {
                return NotFound();
            }

            return View(sistemskaGreska);
        }

        // GET: SistemskaGreska/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SistemskaGreska/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SistemskaGreskaId,UcestalostGreske,OpisGreske,Datum")] SistemskaGreska sistemskaGreska)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sistemskaGreska);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sistemskaGreska);
        }

        // GET: SistemskaGreska/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemskaGreska = await _context.SistemskeGreske.FindAsync(id);
            if (sistemskaGreska == null)
            {
                return NotFound();
            }
            return View(sistemskaGreska);
        }

        // POST: SistemskaGreska/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SistemskaGreskaId,UcestalostGreske,OpisGreske,Datum")] SistemskaGreska sistemskaGreska)
        {
            if (id != sistemskaGreska.SistemskaGreskaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sistemskaGreska);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SistemskaGreskaExists(sistemskaGreska.SistemskaGreskaId))
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
            return View(sistemskaGreska);
        }

        // GET: SistemskaGreska/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemskaGreska = await _context.SistemskeGreske
                .FirstOrDefaultAsync(m => m.SistemskaGreskaId == id);
            if (sistemskaGreska == null)
            {
                return NotFound();
            }

            return View(sistemskaGreska);
        }

        // POST: SistemskaGreska/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sistemskaGreska = await _context.SistemskeGreske.FindAsync(id);
            _context.SistemskeGreske.Remove(sistemskaGreska);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SistemskaGreskaExists(int id)
        {
            return _context.SistemskeGreske.Any(e => e.SistemskaGreskaId == id);
        }
    }
}
