using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_hotel_implementacija.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace E_hotel_implementacija.Controllers
{
    public class RezervacijaController : Controller
    {
        private readonly NasContext _context;
        private readonly UserManager<Korisnik> userManager;
        //private readonly HttpContextAccessor httpContextAccessor;
        private  HttpContext HttpContext => ControllerContext.HttpContext;

        public RezervacijaController(NasContext context, UserManager<Korisnik> userManager/*, HttpContextAccessor httpContextAccessor*/)
        {
            _context = context;
            this.userManager = userManager;
            //this.httpContextAccessor = httpContextAccessor;
        }

        // GET: Rezervacija
        public async Task<IActionResult> Index()
        {
            var nasContext = _context.Rezervacije.Include(r => r.Korisnik).Include(r => r.Soba);
            return View(await nasContext.ToListAsync());
        }

        // GET: Rezervacija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacija = await _context.Rezervacije
                .Include(r => r.Korisnik)
                .Include(r => r.Soba)
                .FirstOrDefaultAsync(m => m.RezervacijaId == id);
            if (rezervacija == null)
            {
                return NotFound();
            }

            return View(rezervacija);
        }

        // GET: Rezervacija/Create
        public IActionResult Create()
        {
            ViewData["KorisnikId"] = new SelectList(userManager.Users, "Id", "Ime");
            ViewData["SobaId"] = new SelectList(_context.Sobe, "SobaId", "Brojsobe");
            return View();
        }

        // POST: Rezervacija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RezervacijaId,KorisnikId,SobaId,DatumPocetka,DatumKraja,Popust,DatumRezervacije,Parking,Validnost")] Rezervacija rezervacija)
        {
            
                var user = HttpContext.User;
                var userfromDb = await userManager.GetUserAsync(user);
                if (userfromDb != null) rezervacija.KorisnikId = userfromDb.Id;
                rezervacija.DatumRezervacije = DateTime.Now;


                _context.Add(rezervacija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Rezervacija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacija = await _context.Rezervacije.FindAsync(id);
            if (rezervacija == null)
            {
                return NotFound();
            }
            ViewData["KorisnikId"] = new SelectList(_context.Korisnici, "Id", "Ime", rezervacija.KorisnikId);
            ViewData["SobaId"] = new SelectList(_context.Sobe, "SobaId", "Brojsobe", rezervacija.SobaId);
            return View(rezervacija);
        }

        // POST: Rezervacija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RezervacijaId,KorisnikId,SobaId,DatumPocetka,DatumKraja,Popust,DatumRezervacije,Parking,Validnost")] Rezervacija rezervacija)
        {
            if (id != rezervacija.RezervacijaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezervacija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervacijaExists(rezervacija.RezervacijaId))
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
            ViewData["KorisnikId"] = new SelectList(_context.Korisnici, "Id", "Ime", rezervacija.KorisnikId);
            ViewData["SobaId"] = new SelectList(_context.Sobe, "SobaId", "Brojsobe", rezervacija.SobaId);
            return View(rezervacija);
        }

        // GET: Rezervacija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacija = await _context.Rezervacije
                .Include(r => r.Korisnik)
                .Include(r => r.Soba)
                .FirstOrDefaultAsync(m => m.RezervacijaId == id);
            if (rezervacija == null)
            {
                return NotFound();
            }

            return View(rezervacija);
        }

        // POST: Rezervacija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezervacija = await _context.Rezervacije.FindAsync(id);
            _context.Rezervacije.Remove(rezervacija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezervacijaExists(int id)
        {
            return _context.Rezervacije.Any(e => e.RezervacijaId == id);
        }
    }
}
