using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class ContatoService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public ContatoService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<Contato>> FindAllAsync()
        {
            return await _context.Contato.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task<Contato> FindByIdAsync(int id)
        {
            return await _context.Contato.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Contato obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Contato.FindAsync(id);
                _context.Contato.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(Contato obj)
        {
            bool hasAny = await _context.StatusSecundario.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }
    }
}
