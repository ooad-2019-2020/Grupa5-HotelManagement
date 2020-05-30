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
    [Authorize(Roles = "Administrator")]
    public class PosaoController : Controller
    {
        private readonly NasContext _context;

        public PosaoController(NasContext context)
        {
            _context = context;
        }

        // GET: PosaoId
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poslovi.ToListAsync());
        }

        // GET: PosaoId/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posao = await _context.Poslovi
                .FirstOrDefaultAsync(m => m.PosaoId == id);
            if (posao == null)
            {
                return NotFound();
            }

            return View(posao);
        }

        // GET: PosaoId/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PosaoId/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PosaoId,Naziv,Plata")] Posao posao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(posao);
        }

        // GET: PosaoId/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posao = await _context.Poslovi.FindAsync(id);
            if (posao == null)
            {
                return NotFound();
            }
            return View(posao);
        }

        // POST: PosaoId/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PosaoId,Naziv,Plata")] Posao posao)
        {
            if (id != posao.PosaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosaoExists(posao.PosaoId))
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
            return View(posao);
        }

        // GET: PosaoId/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posao = await _context.Poslovi
                .FirstOrDefaultAsync(m => m.PosaoId == id);
            if (posao == null)
            {
                return NotFound();
            }

            return View(posao);
        }

        // POST: PosaoId/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posao = await _context.Poslovi.FindAsync(id);
            _context.Poslovi.Remove(posao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosaoExists(int id)
        {
            return _context.Poslovi.Any(e => e.PosaoId == id);
        }
    }
}
