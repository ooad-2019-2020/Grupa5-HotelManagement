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
    [Authorize(Roles = "Korisnik")]
    public class OcjenaController : Controller
    {
        private readonly NasContext _context;

        public OcjenaController(NasContext context)
        {
            _context = context;
        }

        // GET: Ocjena
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ocjene.ToListAsync());
        }

        // GET: Ocjena/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjena = await _context.Ocjene
                .FirstOrDefaultAsync(m => m.OcjenaId == id);
            if (ocjena == null)
            {
                return NotFound();
            }

            return View(ocjena);
        }

        // GET: Ocjena/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ocjena/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OcjenaId,Vrijednost,Opis")] Ocjena ocjena)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocjena);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocjena);
        }

        // GET: Ocjena/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjena = await _context.Ocjene.FindAsync(id);
            if (ocjena == null)
            {
                return NotFound();
            }
            return View(ocjena);
        }

        // POST: Ocjena/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OcjenaId,Vrijednost,Opis")] Ocjena ocjena)
        {
            if (id != ocjena.OcjenaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocjena);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcjenaExists(ocjena.OcjenaId))
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
            return View(ocjena);
        }

        // GET: Ocjena/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjena = await _context.Ocjene
                .FirstOrDefaultAsync(m => m.OcjenaId == id);
            if (ocjena == null)
            {
                return NotFound();
            }

            return View(ocjena);
        }

        // POST: Ocjena/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocjena = await _context.Ocjene.FindAsync(id);
            _context.Ocjene.Remove(ocjena);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcjenaExists(int id)
        {
            return _context.Ocjene.Any(e => e.OcjenaId == id);
        }
    }
}
