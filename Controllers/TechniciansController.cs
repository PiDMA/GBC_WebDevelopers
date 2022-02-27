#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GBC_WebDevelopers.Data;
using GBC_WebDevelopers.Models;

namespace GBC_WebDevelopers.Controllers
{
    public class TechniciansController : Controller
    {
        private readonly GBC_WebDevelopersContext _context;

        public TechniciansController(GBC_WebDevelopersContext context)
        {
            _context = context;
        }

        // GET: Technicians
        public async Task<IActionResult> Index()
        {
            return View(await _context.Technicians.ToListAsync());
        }

        // GET: Technicians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicians = await _context.Technicians
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicians == null)
            {
                return NotFound();
            }

            return View(technicians);
        }

        // GET: Technicians/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Technicians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Phone")] Technicians technicians)
        {
            if (ModelState.IsValid)
            {
                _context.Add(technicians);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(technicians);
        }

        // GET: Technicians/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicians = await _context.Technicians.FindAsync(id);
            if (technicians == null)
            {
                return NotFound();
            }
            return View(technicians);
        }

        // POST: Technicians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone")] Technicians technicians)
        {
            if (id != technicians.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technicians);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechniciansExists(technicians.Id))
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
            return View(technicians);
        }

        // GET: Technicians/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicians = await _context.Technicians
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicians == null)
            {
                return NotFound();
            }

            return View(technicians);
        }

        // POST: Technicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technicians = await _context.Technicians.FindAsync(id);
            _context.Technicians.Remove(technicians);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechniciansExists(int id)
        {
            return _context.Technicians.Any(e => e.Id == id);
        }
    }
}
