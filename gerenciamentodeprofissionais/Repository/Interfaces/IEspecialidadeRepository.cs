using gerenciamentodeprofissionais.Models;

namespace gerenciamentodeprofissionais.Repository.Interfaces
{
    public interface IEspecialidadeRepository
    {
        Task<List<Especialidade>> GetEspecialidade();
    }
}
