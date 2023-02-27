using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Services;

namespace MedAuditoriosPesquisa.Controllers
{
    public class LocaisController : Controller
    {
        private readonly MedAuditoriosPesquisaContext _context;
        private readonly StatusPrimarioService _statusPrimarioService;
        private readonly StatusSecundarioService _statusSecundarioService;


        public LocaisController(MedAuditoriosPesquisaContext context, StatusSecundarioService statusSecundarioService, StatusPrimarioService statusPrimarioService)
        {
            _context = context;
            _statusSecundarioService = statusSecundarioService;
            _statusPrimarioService = statusPrimarioService;

        }

        // GET: Locais
        public async Task<IActionResult> Index()
        {
              return View(await _context.Local.ToListAsync());
        }

        // GET: Locais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Local == null)
            {
                return NotFound();
            }

            var local = await _context.Local
                .FirstOrDefaultAsync(m => m.Id == id);
            if (local == null)
            {
                return NotFound();
            }

            return View(local);
        }

        // GET: Locais/Create
        public IActionResult Create()
        {
            var statusPrimarios = _statusPrimarioService.FindAll();
            var statusSecundarios = _statusSecundarioService.FindAll();
            var viewModel = new LocalFormViewModel { StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios };
            return View(viewModel);
        }

        // POST: Locais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Filial,Nome,DataInteracao,Capacidade,PeDireito,TipoCadeira,StatusPrimario,StatusSecundario,Observacao,LinkVisita")] Local local)
        {
            if (ModelState.IsValid)
            {
                _context.Add(local);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(local);
        }

        // GET: Locais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Local == null)
            {
                return NotFound();
            }

            var local = await _context.Local.FindAsync(id);
            if (local == null)
            {
                return NotFound();
            }
            return View(local);
        }

        // POST: Locais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Filial,Nome,DataInteracao,Capacidade,PeDireito,TipoCadeira,StatusPrimario,StatusSecundario,Observacao,LinkVisita")] Local local)
        {
            if (id != local.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(local);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalExists(local.Id))
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
            return View(local);
        }

        // GET: Locais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Local == null)
            {
                return NotFound();
            }

            var local = await _context.Local
                .FirstOrDefaultAsync(m => m.Id == id);
            if (local == null)
            {
                return NotFound();
            }

            return View(local);
        }

        // POST: Locais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Local == null)
            {
                return Problem("Entity set 'MedAuditoriosPesquisaContext.Local'  is null.");
            }
            var local = await _context.Local.FindAsync(id);
            if (local != null)
            {
                _context.Local.Remove(local);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalExists(int id)
        {
          return _context.Local.Any(e => e.Id == id);
        }
    }
}
