using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class StatusSecundarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusSecundarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<StatusSecundario>> FindAllAsync()
        {
            return await _context.StatusSecundario.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
