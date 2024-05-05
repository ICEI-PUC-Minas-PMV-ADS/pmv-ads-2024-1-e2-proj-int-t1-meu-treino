using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IExercicioRepository
    {
        public List<Exercicio> GetExercicios();
        public Exercicio GetExercicio(int id);

        public void AddExercicio(Exercicio exercicio);

         Task<bool> saveChangesAsync();
    }
}
