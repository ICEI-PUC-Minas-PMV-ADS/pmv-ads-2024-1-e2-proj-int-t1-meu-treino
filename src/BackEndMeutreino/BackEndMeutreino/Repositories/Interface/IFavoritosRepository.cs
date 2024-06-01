using BackEndMeutreino.Models;
using System.Collections.Generic;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IFavoritosRepository
    {
        void Add(Favoritos favoritos);
        List<Favoritos> GetFavoritosByUsuario(int idUsuario);
        Task<bool> saveChangesAsync();
    }
}
