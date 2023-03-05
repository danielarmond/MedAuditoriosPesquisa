using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
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

        public async Task<StatusPrimario> FindByIdAsync(int id)
        {
            return await _context.StatusPrimario.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(StatusPrimario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.StatusPrimario.FindAsync(id);
                _context.StatusPrimario.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(StatusPrimario obj)
        {
            bool hasAny = await _context.StatusPrimario.AnyAsync(x => x.Id == obj.Id);
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
