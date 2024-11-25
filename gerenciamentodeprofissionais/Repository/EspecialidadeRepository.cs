using gerenciamentodeprofissionais.Data;
using gerenciamentodeprofissionais.Models;
using gerenciamentodeprofissionais.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentodeprofissionais.Repository
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly ProfiDbContext _context;

        public EspecialidadeRepository(ProfiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Especialidade>> GetEspecialidade()
        {
            return await _context.Especialidades.ToListAsync();
        }
    }
}
