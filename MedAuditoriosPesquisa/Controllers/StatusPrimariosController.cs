using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Controllers
{
    public class StatusPrimariosController : Controller
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusPrimariosController(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        // GET: StatusPrimarios
        public async Task<IActionResult> Index()
        {
              return View(await _context.StatusPrimario.ToListAsync());
        }

        // GET: StatusPrimarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StatusPrimario == null)
            {
                return NotFound();
            }

            var statusPrimario = await _context.StatusPrimario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusPrimario == null)
            {
                return NotFound();
            }

            return View(statusPrimario);
        }

        // GET: StatusPrimarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusPrimarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] StatusPrimario statusPrimario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusPrimario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusPrimario);
        }

        // GET: StatusPrimarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StatusPrimario == null)
            {
                return NotFound();
            }

            var statusPrimario = await _context.StatusPrimario.FindAsync(id);
            if (statusPrimario == null)
            {
                return NotFound();
            }
            return View(statusPrimario);
        }

        // POST: StatusPrimarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] StatusPrimario statusPrimario)
        {
            if (id != statusPrimario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusPrimario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusPrimarioExists(statusPrimario.Id))
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
            return View(statusPrimario);
        }

        // GET: StatusPrimarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StatusPrimario == null)
            {
                return NotFound();
            }

            var statusPrimario = await _context.StatusPrimario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusPrimario == null)
            {
                return NotFound();
            }

            return View(statusPrimario);
        }

        // POST: StatusPrimarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StatusPrimario == null)
            {
                return Problem("Entity set 'MedAuditoriosPesquisaContext.StatusPrimario'  is null.");
            }
            var statusPrimario = await _context.StatusPrimario.FindAsync(id);
            if (statusPrimario != null)
            {
                _context.StatusPrimario.Remove(statusPrimario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusPrimarioExists(int id)
        {
          return _context.StatusPrimario.Any(e => e.Id == id);
        }
    }
}
