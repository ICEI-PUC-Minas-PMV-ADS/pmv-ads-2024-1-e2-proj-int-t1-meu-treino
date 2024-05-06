using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IExercicioRepository
    {
        public List<Exercicio> GetExercicios();
        public Exercicio GetExercicio(int id);

    }
}
