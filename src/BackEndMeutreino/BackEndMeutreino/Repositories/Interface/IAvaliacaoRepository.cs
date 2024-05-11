using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IAvaliacaoRepository
    {
        void AddAvaliacao(Avaliacao avaliacao);
        Task<bool> saveChangesAsync();
    }
}