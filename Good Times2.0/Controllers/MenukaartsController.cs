using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Good_Times2._0.Data;
using Good_Times2._0.Models;

namespace Good_Times2._0.Controllers
{
    public class MenukaartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenukaartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Menukaarts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Menukaart.ToListAsync());
        }

        // GET: Menukaarts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menukaart = await _context.Menukaart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menukaart == null)
            {
                return NotFound();
            }

            return View(menukaart);
        }

        // GET: Menukaarts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Menukaarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam")] Menukaart menukaart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menukaart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menukaart);
        }

        // GET: Menukaarts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menukaart = await _context.Menukaart.FindAsync(id);
            if (menukaart == null)
            {
                return NotFound();
            }
            return View(menukaart);
        }

        // POST: Menukaarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam")] Menukaart menukaart)
        {
            if (id != menukaart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menukaart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenukaartExists(menukaart.Id))
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
            return View(menukaart);
        }

        // GET: Menukaarts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menukaart = await _context.Menukaart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menukaart == null)
            {
                return NotFound();
            }

            return View(menukaart);
        }

        // POST: Menukaarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menukaart = await _context.Menukaart.FindAsync(id);
            _context.Menukaart.Remove(menukaart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenukaartExists(int id)
        {
            return _context.Menukaart.Any(e => e.Id == id);
        }
    }
}
