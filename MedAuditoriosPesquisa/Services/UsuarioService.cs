using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class UsuarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public UsuarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> FindAllAsync()
        {
            return await _context.Usuario.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task<Usuario> FindByIdAsync(int id)
        {
            return await _context.Usuario.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Usuario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Usuario.FindAsync(id);
                _context.Usuario.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(Usuario obj)
        {
            bool hasAny = await _context.Usuario.AnyAsync(x => x.Id == obj.Id);
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
