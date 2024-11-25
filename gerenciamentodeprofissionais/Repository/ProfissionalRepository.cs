using gerenciamentodeprofissionais.Data;
using gerenciamentodeprofissionais.Models;
using gerenciamentodeprofissionais.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentodeprofissionais.Repository
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly ProfiDbContext _context;

        public ProfissionalRepository(ProfiDbContext context)
        {
            _context = context;
        }
        public async Task<Profissional> GetProfissionalById(int id)
        {
            return await _context.Profissionais
                .Include(p => p.Especialidade) 
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<Profissional>> GetProfissionais()
        {
            return await _context.Profissionais
                .Include(p => p.Especialidade) 
                .ToListAsync();
        }
        public async Task<Profissional> AddProfissional(Profissional profissional)
        {
            var especialidade = await _context.Especialidades
        .FirstOrDefaultAsync(e => e.Id == profissional.EspecialidadeId);
            if (especialidade == null)
            {
                throw new Exception("A especialidade fornecida não existe.");
            }
            profissional.Especialidade = especialidade;
            await _context.Profissionais.AddAsync(profissional);
            await _context.SaveChangesAsync();
            return profissional;
        }
        public async Task<Profissional> UpdateProfissional(Profissional profissional, int id)
        {
            Profissional profissionalExistente = await GetProfissionalById(id);

            var especialidade = await _context.Especialidades
            .FirstOrDefaultAsync(e => e.Id == profissional.EspecialidadeId);

            if (profissionalExistente == null)
            {
                throw new Exception($"O Profissional com o ID:{id} enviado não foi encontrado.");
            }

            if(especialidade == null)
            {
                throw new Exception($"Especialidade não foi encontrado.");
            }

            profissionalExistente.Especialidade = especialidade;
            profissionalExistente.Nome = profissional.Nome;
            profissionalExistente.EspecialidadeId = profissional.EspecialidadeId;
            profissionalExistente.NumeroDocumento = profissional.NumeroDocumento;

            _context.Profissionais.Update(profissionalExistente);
            await _context.SaveChangesAsync();

            return profissionalExistente;
        }
        public async Task<bool> DeleteProfissional(int id)
        {
            Profissional profissionalExistente = await GetProfissionalById(id);

            if (profissionalExistente == null)
            {
                throw new Exception($"O Profissional com o ID:{id} enviado não foi encontrado.");
            }

            _context.Profissionais.Remove(profissionalExistente);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
