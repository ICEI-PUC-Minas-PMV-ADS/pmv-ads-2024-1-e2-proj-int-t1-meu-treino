using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories;
using BackEndMeutreino.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BackEndMeutreino.Controllers
{
    public class ExercicioController : Controller
    {
        private readonly IExercicioRepository repository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IAvaliacaoRepository avaliacaoRepository;
        private readonly IFavoritosRepository favoritosRepository;

        public ExercicioController(IExercicioRepository repository)
        {
            this.repository = repository;

        }

        [Authorize]
        public IActionResult ExerciseDetails(int id)
        {
            var exercicio = repository.GetExercicio(id);
            return View(exercicio);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> AddExercise(Exercicio exercicio)
        {
            repository.AddExercicio(exercicio);
            await repository.saveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RateExercise(int exerciseId, int rating)
        {
            var claims = ((ClaimsIdentity)User.Identity).Claims;

            // Encontra a claim de email do usuário
            var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

            // Encontra o usuário no banco de dados
            var usuario = usuarioRepository.GetUsuario(email.Value);
            var avaliacao = new Avaliacao
            {
                idUsuario = usuario.id,
                idExercicio = exerciseId,
                avaliacao = rating
            };
            avaliacaoRepository.AddAvaliacao(avaliacao);
            await avaliacaoRepository.saveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddToFavorites(int exerciseId)
        {
            var claims = ((ClaimsIdentity)User.Identity).Claims;

            // Encontra a claim de email do usuário
            var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

            // Encontra o usuário no banco de dados
            var usuario = usuarioRepository.GetUsuario(email.Value);
            var favoritos = new Favoritos
            {
                idUsuario = usuario.id,
                idExercicio = exerciseId
            };
            favoritosRepository.Add(favoritos);
            await usuarioRepository.saveChangesAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
