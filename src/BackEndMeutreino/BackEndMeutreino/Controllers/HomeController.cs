using BackEndMeutreino.Infra;
using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;
using BackEndMeutreino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;

namespace BackEndMeutreino.Controllers
{
    public class HomeController : Controller
    {

        private readonly IExercicioRepository repository;


        public HomeController(IExercicioRepository repository)
        {
            this.repository = repository;
        }

        [Authorize]
        public IActionResult Index()
        {
            List<Exercicio> exercicios = repository.GetExercicios();
            return View(exercicios);
        }
 

    }
}
