using Microsoft.AspNetCore.Mvc;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Services.Exceptions;
using MedAuditoriosPesquisa.Services;
using System.Diagnostics;

namespace MedAuditoriosPesquisa.Controllers
{
    public class StatusSecundariosController : Controller
    {
        private readonly StatusSecundarioService _statusSecundarioService;

        public StatusSecundariosController(StatusSecundarioService statusSecundarioService)
        {
            _statusSecundarioService = statusSecundarioService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _statusSecundarioService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StatusSecundario statusSecundario)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _statusSecundarioService.InsertAsync(statusSecundario);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _statusSecundarioService.FindByIdAsync(id.Value);
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
                await _statusSecundarioService.RemoveAsync(id);
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
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _statusSecundarioService.FindByIdAsync(id.Value);
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
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _statusSecundarioService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            StatusSecundarioFormViewModel viewModel = new StatusSecundarioFormViewModel { StatusSecundario = obj };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StatusSecundario statusSecundario)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id != statusSecundario.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id diferente" });
            }
            try
            {
                await _statusSecundarioService.UpdateAsync(statusSecundario);
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
