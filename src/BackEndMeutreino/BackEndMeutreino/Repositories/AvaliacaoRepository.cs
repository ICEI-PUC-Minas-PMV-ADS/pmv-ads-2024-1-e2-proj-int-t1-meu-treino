using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;

namespace BackEndMeutreino.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly Contexto _context;

        public AvaliacaoRepository(Contexto context)
        {
            _context = context;
        }
        public void AddAvaliacao(Avaliacao avaliacao)
        {
            _context.Avaliacao.Add(avaliacao);
        }

        public async Task<bool> saveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;

        }
    }
}
