using BackEndMeutreino.Models;
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

        public ExercicioController(IExercicioRepository repository, IUsuarioRepository usuarioRepository)
        {
            this.repository = repository;
            this.usuarioRepository = usuarioRepository;
        }

        [Authorize]
        public IActionResult ExerciseDetails(int id)
        {
            var exercicio = repository.GetExercicio(id);
            return View(exercicio);
        }
    }
}
