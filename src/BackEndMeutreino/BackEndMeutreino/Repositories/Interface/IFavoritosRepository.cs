using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IFavoritosRepository
    {
        void Add(Favoritos favoritos);

        Task<bool> saveChangesAsync();
    }
}
