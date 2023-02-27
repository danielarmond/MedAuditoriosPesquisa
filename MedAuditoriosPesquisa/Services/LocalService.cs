using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class LocalService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public LocalService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public List<Local> FindAll()
        {
            return _context.Local.Include(obj => obj.StatusPrimario).Include(obj => obj.StatusSecundario).OrderBy(x => x.Nome).ToList();
        }

        public Local FindById(int id) 
        {
        return _context.Local.Include(obj => obj.StatusPrimario).Include(obj => obj.StatusSecundario).FirstOrDefault(obj =>obj.Id == id);
        }
    }
}
