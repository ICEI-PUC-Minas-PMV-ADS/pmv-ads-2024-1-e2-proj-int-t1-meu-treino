using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;

namespace BackEndMeutreino.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly Contexto context;

        public UsuarioRepository(Contexto context)
        {
            this.context = context;
        }

        public void adicionarUsuario(Usuario user)
        {
             context.Usuario.Add(user);
            // context.HistoricoPeso.Add(new HistoricoPeso { data = DateTime.Now.ToString(), peso = user.peso, idUsuario =  });

        }

        public List<HistoricoPeso> GetHistoricoPeso(int idUsuario)
        {
            return context.HistoricoPeso.Where(h => h.idUsuario == idUsuario).ToList();
        }

        public Usuario GetUsuario(string email)
        {
            return context.Usuario.FirstOrDefault(u => u.email == email);
        }

        public async Task<bool> saveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void UpdateUsuario(Usuario user)
        {
            Usuario usuario = context.Usuario.FirstOrDefault(u => u.email == user.email);
            usuario.altura = user.altura;
            usuario.peso = user.peso;
            context.HistoricoPeso.Add(new HistoricoPeso { data = DateTime.Now.ToString(), peso = user.peso, idUsuario = usuario.id });

        }
    }
}
