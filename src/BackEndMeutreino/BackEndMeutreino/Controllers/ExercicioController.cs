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

        public ExercicioController(IExercicioRepository repository, IUsuarioRepository usuarioRepository, IAvaliacaoRepository avaliacaoRepository, IFavoritosRepository favoritosRepository)
        {
            this.repository = repository;
            this.usuarioRepository = usuarioRepository;
            this.avaliacaoRepository = avaliacaoRepository;
            this.favoritosRepository = favoritosRepository;

        }

        [Authorize]
        public async Task<IActionResult> ExerciseDetails(int id)
        {
            var exercicio = await repository.GetExerciseByIdAsync(id);
            return View(exercicio);
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

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult AddExercise()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> AddExercise(Exercicio model)
        {
            if (ModelState.IsValid)
            {
                await repository.AddExerciseAsync(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
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
        [Authorize]
        public IActionResult Favorites()
        {
            var claims = ((ClaimsIdentity)User.Identity).Claims;
            var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized();
            }

            var usuario = usuarioRepository.GetUsuario(email);
            if (usuario == null)
            {
                return NotFound();
            }

            var favoritos = favoritosRepository.GetFavoritosByUsuario(usuario.id);
            return View(favoritos);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> EditExercise(int id)
        {
            var exercicio = await repository.GetExerciseByIdAsync(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            return View(exercicio);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> EditExercise(Exercicio model)
        {
            if (ModelState.IsValid)
            {
                await repository.UpdateExerciseAsync(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            var exercicio = await repository.GetExerciseByIdAsync(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            return View(exercicio);
        }

        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("DeleteExercise")]
        public async Task<IActionResult> DeleteExerciseConfirmed(int id)
        {
            await repository.DeleteExerciseAsync(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
