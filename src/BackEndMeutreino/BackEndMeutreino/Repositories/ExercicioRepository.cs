using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BackEndMeutreino.Repositories
{
    public class ExercicioRepository : IExercicioRepository
    {
        public readonly Contexto context;

        public ExercicioRepository(Contexto context)
        {
            this.context = context;
        }

        public async Task AddExerciseAsync(Exercicio exercicio)
        {
            context.Exercicio.Add(exercicio);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Exercicio>> GetAllExercisesAsync()
        {
            return await context.Exercicio.ToListAsync();
        }

        public async Task<Exercicio> GetExerciseByIdAsync(int id)
        {
            return await context.Exercicio.FindAsync(id);
        }

        public async Task<bool> saveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public async Task UpdateExerciseAsync(Exercicio exercicio)
        {
            context.Entry(exercicio).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteExerciseAsync(int id)
        {
            var exercicio = await context.Exercicio.FindAsync(id);
            if (exercicio != null)
            {
                context.Exercicio.Remove(exercicio);
                await context.SaveChangesAsync();
            }
        }
    }
}
