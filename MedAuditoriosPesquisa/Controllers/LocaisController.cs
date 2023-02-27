using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Services;
using System.Diagnostics;

namespace MedAuditoriosPesquisa.Controllers
{
    public class LocaisController : Controller
    {
        private readonly MedAuditoriosPesquisaContext _context;
        private readonly StatusPrimarioService _statusPrimarioService;
        private readonly StatusSecundarioService _statusSecundarioService;
        private readonly LocalService _localService;


        public LocaisController(MedAuditoriosPesquisaContext context, StatusSecundarioService statusSecundarioService, StatusPrimarioService statusPrimarioService, LocalService localService)
        {
            _context = context;
            _statusSecundarioService = statusSecundarioService;
            _statusPrimarioService = statusPrimarioService;
            _localService= localService;
        }

        // GET: Locais
        public async Task<IActionResult> Index()
        {
            return View(_localService.FindAll().ToList());
        }

        // GET: Locais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Local == null)
            {
                return NotFound();
            }

            var obj = _localService.FindById(id.Value);
                
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
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
        public async Task<IActionResult> Create(Local local)
        {
                _context.Add(local);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Locais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _localService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<StatusPrimario> statusPrimarios = _statusPrimarioService.FindAll();
            List<StatusSecundario> statusSecundarios = _statusSecundarioService.FindAll();

            LocalFormViewModel viewModel = new LocalFormViewModel { Local = obj, StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios };
            return View(viewModel);
        }

        // POST: Locais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Local local)
        {
            if (id != local.Id)
            {
                return NotFound();
            }
                        
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

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
