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

       
}
