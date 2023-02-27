using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Services
{
    public class ContatoService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public ContatoService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public List<Contato> FindAll()
        {
            return _context.Contato.OrderBy(x => x.Nome).ToList();
        }
    }
}
