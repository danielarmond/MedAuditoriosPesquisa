using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Services
{
    public class StatusPrimarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusPrimarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public List<StatusPrimario> FindAll()
        {
            return _context.StatusPrimario.OrderBy(x => x.Nome).ToList();
        }
    }
}
