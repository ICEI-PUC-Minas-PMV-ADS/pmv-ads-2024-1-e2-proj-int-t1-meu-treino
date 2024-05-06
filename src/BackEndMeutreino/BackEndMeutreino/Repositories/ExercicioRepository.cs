﻿using BackEndMeutreino.Models;
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

        public Exercicio GetExercicio(int id)
        {
            return context.Exercicio.FirstOrDefault(e => e.id == id);
        }

        public List<Exercicio> GetExercicios()
        {
            return context.Exercicio.ToList();
        }
    }
}
