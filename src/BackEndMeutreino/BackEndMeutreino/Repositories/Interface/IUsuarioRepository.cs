using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        void adicionarUsuario(Usuario user);
        void UpdateUsuario(Usuario user);

        Usuario GetUsuario(string email);

        List<HistoricoPeso> GetHistoricoPeso(int idUsuario);

        Task<bool> saveChangesAsync();
    }
}
