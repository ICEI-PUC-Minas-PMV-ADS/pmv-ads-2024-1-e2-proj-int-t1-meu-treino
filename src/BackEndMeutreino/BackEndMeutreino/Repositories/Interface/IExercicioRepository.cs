using BackEndMeutreino.Models;

namespace BackEndMeutreino.Repositories.Interface
{
    public interface IExercicioRepository
    {
        Task<IEnumerable<Exercicio>> GetAllExercisesAsync();
        Task<Exercicio> GetExerciseByIdAsync(int id);

        Task AddExerciseAsync(Exercicio exercicio);

        Task<bool> saveChangesAsync();

        Task UpdateExerciseAsync(Exercicio exercicio);
        Task DeleteExerciseAsync(int id);
    }
}
