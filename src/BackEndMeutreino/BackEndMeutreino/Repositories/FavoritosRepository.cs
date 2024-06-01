using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndMeutreino.Repositories
{
    public class FavoritosRepository : IFavoritosRepository
    {
        private readonly Contexto context;

        public FavoritosRepository(Contexto context)
        {
            this.context = context;
        }

        public void Add(Favoritos favoritos)
        {
            context.Favoritos.Add(favoritos);
        }

        public List<Favoritos> GetFavoritosByUsuario(int idUsuario)
        {
            return context.Favoritos
                          .Include(f => f.exercicio)
                          .Where(f => f.idUsuario == idUsuario)
                          .ToList();
        }

        public async Task<bool> saveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
