using gerenciamentodeprofissionais.Models;

namespace gerenciamentodeprofissionais.Repository.Interfaces
{
    public interface IProfissionalRepository
    {
        
        Task<Profissional> GetProfissionalById(int id);
        Task<List<Profissional>> GetProfissionais();
        Task<Profissional> AddProfissional(Profissional profissional);
        Task<Profissional> UpdateProfissional(Profissional profissional, int id);
        Task<bool> DeleteProfissional(int id);
    }
}
