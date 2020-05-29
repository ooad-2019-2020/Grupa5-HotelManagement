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
    public class PosaoController : Controller
    {
        private readonly NasContext _context;

        public PosaoController(NasContext context)
        {
            _context = context;
        }

        // GET: Posao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poslovi.ToListAsync());
        }

        // GET: Posao/Details/5
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

        // GET: Posao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Posao/Create
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

        // GET: Posao/Edit/5
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

        // POST: Posao/Edit/5
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

        // GET: Posao/Delete/5
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

        // POST: Posao/Delete/5
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
