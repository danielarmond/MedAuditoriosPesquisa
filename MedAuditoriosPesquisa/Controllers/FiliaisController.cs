using MedAuditoriosPesquisa.Models.ViewModels;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
using MedAuditoriosPesquisa.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedAuditoriosPesquisa.Controllers
{
    public class FiliaisController : Controller
    {
        private readonly FilialService _filialService;
        public FiliaisController(FilialService filialService)
        {
            _filialService = filialService;
        }


        public async Task<IActionResult> Index()
        {
            var list = await _filialService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Filial filial)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _filialService.InsertAsync(filial);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não foi fornecido" });
            }

            var obj = await _filialService.FindByIdAsync(id.Value);
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
                await _filialService.RemoveAsync(id);
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

            var obj = await _filialService.FindByIdAsync(id.Value);
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

            var obj = await _filialService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não localizado" });
            }
            FilialFormViewModel viewModel = new FilialFormViewModel { Filial = obj };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Filial filial)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id != filial.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id diferente" });
            }
            try
            {
                await _filialService.UpdateAsync(filial);
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
