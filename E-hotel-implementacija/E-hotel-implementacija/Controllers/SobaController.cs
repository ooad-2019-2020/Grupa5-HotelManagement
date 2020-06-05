using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_hotel_implementacija.Models;

namespace E_hotel_implementacija.Controllers
{
    public class SobaController : Controller
    {
        private readonly NasContext _context;

        public SobaController(NasContext context)
        {
            _context = context;
        }

        // GET: Soba
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sobe.ToListAsync());
        }

        // GET: Soba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soba = await _context.Sobe
                .FirstOrDefaultAsync(m => m.SobaId == id);
            if (soba == null)
            {
                return NotFound();
            }

            return View(soba);
        }

        // GET: Soba/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Soba/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SobaId,Brojsobe,CijenaSobe,OcjenaSobe,OpisSobe,SlikaSobe")] Soba soba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(soba);
        }

        // GET: Soba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soba = await _context.Sobe.FindAsync(id);
            if (soba == null)
            {
                return NotFound();
            }
            return View(soba);
        }

        // POST: Soba/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SobaId,Brojsobe,CijenaSobe,OcjenaSobe,OpisSobe,SlikaSobe")] Soba soba)
        {
            if (id != soba.SobaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SobaExists(soba.SobaId))
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
            return View(soba);
        }

        // GET: Soba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soba = await _context.Sobe
                .FirstOrDefaultAsync(m => m.SobaId == id);
            if (soba == null)
            {
                return NotFound();
            }

            return View(soba);
        }

        // POST: Soba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var soba = await _context.Sobe.FindAsync(id);
            _context.Sobe.Remove(soba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SobaExists(int id)
        {
            return _context.Sobe.Any(e => e.SobaId == id);
        }
    }
}
