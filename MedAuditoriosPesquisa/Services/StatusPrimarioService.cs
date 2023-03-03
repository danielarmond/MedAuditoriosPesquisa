using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class StatusPrimarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusPrimarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<StatusPrimario>> FindAllAsync()
        {
            return await _context.StatusPrimario.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
