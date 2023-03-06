using Microsoft.AspNetCore.Mvc;
using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Services;
using System.Diagnostics;
using MedAuditoriosPesquisa.Services.Exceptions;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Controllers
{
    public class LocaisController : Controller
    {
        private readonly StatusPrimarioService _statusPrimarioService;
        private readonly StatusSecundarioService _statusSecundarioService;
        private readonly LocalService _localService;


        public LocaisController(StatusSecundarioService statusSecundarioService, StatusPrimarioService statusPrimarioService, LocalService localService)
        {
            _statusSecundarioService = statusSecundarioService;
            _statusPrimarioService = statusPrimarioService;
            _localService= localService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _localService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var statusPrimarios = await _statusPrimarioService.FindAllAsync();
            var statusSecundarios = await _statusSecundarioService.FindAllAsync();
            var viewModel = new LocalFormViewModel { StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Local local)
        {
            if (!ModelState.IsValid)
            {
                var statusPrimarios = await _statusPrimarioService.FindAllAsync();
                var statusSecundarios = await _statusSecundarioService.FindAllAsync();

                var viewModel = new LocalFormViewModel { Local = local, StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios };
                return View(viewModel);
            }
            await _localService.InsertAsync(local);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não foi fornecido" });
            }

            var obj = await _localService.FindByIdAsync(id.Value);
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
                await _localService.RemoveAsync(id);
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

            var obj = await _localService.FindByIdAsync(id.Value);
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

            var obj = await _localService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }

            List<StatusPrimario> statusPrimarios = await _statusPrimarioService.FindAllAsync();
            List<StatusSecundario> statusSecundarios = await _statusSecundarioService.FindAllAsync();

            LocalFormViewModel viewModel = new LocalFormViewModel { Local = obj, StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Local local)
        {
            if (!ModelState.IsValid)
            {
                var statusPrimarios = await _statusPrimarioService.FindAllAsync();
                var statusSecundarios = await _statusSecundarioService.FindAllAsync();
                var viewModel = new LocalFormViewModel { Local = local, StatusPrimarios = statusPrimarios, StatusSecundarios = statusSecundarios };
                return View(viewModel);
            }
            if (id != local.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id diferente" });
            }
            try
            {
                await _localService.UpdateAsync(local);
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
