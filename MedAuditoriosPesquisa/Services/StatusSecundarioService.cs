using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Services
{
    public class StatusSecundarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusSecundarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public List<StatusSecundario> FindAll()
        {
            return _context.StatusSecundario.OrderBy(x => x.Nome).ToList();
        }
    }
}
