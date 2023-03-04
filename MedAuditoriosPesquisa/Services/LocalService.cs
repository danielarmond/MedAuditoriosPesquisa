using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using MedAuditoriosPesquisa.Services.Exceptions;

namespace MedAuditoriosPesquisa.Services
{
    public class LocalService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public LocalService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        
        public async Task<List<Local>> FindAllAsync()
        {
            return await _context.Local.Include(obj => obj.StatusPrimario).Include(obj => obj.StatusSecundario).OrderBy(x => x.Nome).ToListAsync();
        }

       
        public async Task<Local> FindByIdAsync(int id)
        {
            return await _context.Local.Include(obj => obj.StatusPrimario).Include(obj => obj.StatusSecundario).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Local obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Local.FindAsync(id);
                _context.Local.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(Local obj)
        {
            bool hasAny = await _context.Local.AnyAsync(x => x.Id == obj.Id);
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
