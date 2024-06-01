using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;

namespace BackEndMeutreino.Repositories
{
    public class FavoritosRepository : IFavoritosRepository
    {
        private readonly Contexto _context;

        public FavoritosRepository(Contexto context)
        {
            _context = context;
        }

        public void Add(Favoritos favoritos)
        {
            _context.Favoritos.Add(favoritos);
        }

        public async Task<bool> saveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}