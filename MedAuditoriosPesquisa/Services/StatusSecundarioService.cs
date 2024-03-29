﻿using MedAuditoriosPesquisa.Data;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace MedAuditoriosPesquisa.Services
{
    public class StatusSecundarioService
    {
        private readonly MedAuditoriosPesquisaContext _context;

        public StatusSecundarioService(MedAuditoriosPesquisaContext context)
        {
            _context = context;
        }

        public async Task<List<StatusSecundario>> FindAllAsync()
        {
            return await _context.StatusSecundario.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task<StatusSecundario> FindByIdAsync(int id)
        {
            return await _context.StatusSecundario.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(StatusSecundario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.StatusSecundario.FindAsync(id);
                _context.StatusSecundario.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new IntegrityException("Não é possível excluir");
            }
        }

        public async Task UpdateAsync(StatusSecundario obj)
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
