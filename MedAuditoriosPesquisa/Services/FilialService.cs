using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class FilialService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public FilialService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<Filial>> FindAllAsync()
        {
            return await _context.Filial.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task<Filial> FindByIdAsync(int id)
        {
            return await _context.Filial.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Filial obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Filial.FindAsync(id);
                _context.Filial.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(Filial obj)
        {
            bool hasAny = await _context.Filial.AnyAsync(x => x.Id == obj.Id);
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
