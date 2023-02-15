using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Controllers
{
    public class StatusSecundariosController : Controller
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusSecundariosController(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        // GET: StatusSecundarios
        public async Task<IActionResult> Index()
        {
              return View(await _context.StatusSecundario.ToListAsync());
        }

        // GET: StatusSecundarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StatusSecundario == null)
            {
                return NotFound();
            }

            var statusSecundario = await _context.StatusSecundario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusSecundario == null)
            {
                return NotFound();
            }

            return View(statusSecundario);
        }

        // GET: StatusSecundarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusSecundarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] StatusSecundario statusSecundario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusSecundario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusSecundario);
        }

        // GET: StatusSecundarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StatusSecundario == null)
            {
                return NotFound();
            }

            var statusSecundario = await _context.StatusSecundario.FindAsync(id);
            if (statusSecundario == null)
            {
                return NotFound();
            }
            return View(statusSecundario);
        }

        // POST: StatusSecundarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] StatusSecundario statusSecundario)
        {
            if (id != statusSecundario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusSecundario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusSecundarioExists(statusSecundario.Id))
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
            return View(statusSecundario);
        }

        // GET: StatusSecundarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StatusSecundario == null)
            {
                return NotFound();
            }

            var statusSecundario = await _context.StatusSecundario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusSecundario == null)
            {
                return NotFound();
            }

            return View(statusSecundario);
        }

        // POST: StatusSecundarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StatusSecundario == null)
            {
                return Problem("Entity set 'MedAuditoriosPesquisaContext.StatusSecundario'  is null.");
            }
            var statusSecundario = await _context.StatusSecundario.FindAsync(id);
            if (statusSecundario != null)
            {
                _context.StatusSecundario.Remove(statusSecundario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusSecundarioExists(int id)
        {
          return _context.StatusSecundario.Any(e => e.Id == id);
        }
    }
}
