using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;

namespace BackEndMeutreino.Repositories
{
    public class ExercicioRepository : IExercicioRepository
    {
        public readonly Contexto context;

        public ExercicioRepository(Contexto context)
        {
            this.context = context;
        }

        public void AddExercicio(Exercicio exercicio)
        {
            context.Exercicio.Add(exercicio);
        }

        public Exercicio GetExercicio(int id)
        {
            return context.Exercicio.FirstOrDefault(e => e.id == id);
        }

        public List<Exercicio> GetExercicios()
        {
            return context.Exercicio.ToList();
        }

        public async Task<bool> saveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
