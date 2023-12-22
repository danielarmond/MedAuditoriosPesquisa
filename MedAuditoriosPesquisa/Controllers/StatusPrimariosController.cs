using Microsoft.AspNetCore.Mvc;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Services.Exceptions;
using MedAuditoriosPesquisa.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace MedAuditoriosPesquisa.Controllers
{
    [Authorize]
    public class StatusPrimariosController : Controller
    {
        private readonly StatusPrimarioService _statusPrimarioService;
        public StatusPrimariosController(StatusPrimarioService statusPrimarioService)
        {
            _statusPrimarioService = statusPrimarioService;
        }

        
        public async Task<IActionResult> Index()
        {
            var list = await _statusPrimarioService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StatusPrimario statusPrimario)
        {
            if (!ModelState.IsValid)
            {
               return View();
            }
            await _statusPrimarioService.InsertAsync(statusPrimario);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não foi fornecido" });
            }

            var obj = await _statusPrimarioService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _statusPrimarioService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não foi fornecido" });
            }

            var obj = await _statusPrimarioService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não foi fornecido" });
            }

            var obj = await _statusPrimarioService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            StatusPrimarioFormViewModel viewModel = new StatusPrimarioFormViewModel { StatusPrimario = obj };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StatusPrimario statusPrimario)
        {
            if (!ModelState.IsValid)
            {                
                return View();
            }
            if (id != statusPrimario.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id diferente" });
            }
            try
            {
                await _statusPrimarioService.UpdateAsync(statusPrimario);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
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
