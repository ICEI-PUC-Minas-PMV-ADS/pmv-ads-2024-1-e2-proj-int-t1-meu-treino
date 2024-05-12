using BackEndMeutreino.Infra;
using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Security.Claims;
using System.Security.Cryptography;

namespace BackEndMeutreino.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Authentication _hashService = new Authentication(SHA512.Create());

        private readonly IUsuarioRepository repository;


        public UsuarioController(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([Bind("nome","email","senha","altura","peso")]Usuario user)
        {
           
            //if (ModelState.IsValid)
            //{
                user.senha = _hashService.CriptografarSenha(user.senha);
                repository.adicionarUsuario(user);
                await repository.saveChangesAsync();
                return RedirectToAction("Index", "Login");
            //}
            //return View(user);

            
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Historico()
        {
            var claims = ((ClaimsIdentity)User.Identity).Claims;

            // Encontra a claim de email do usuário
            var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

            // Encontra o usuário no banco de dados
            var usuario = repository.GetUsuario(email.Value);
            var historico = repository.GetHistoricoPeso(usuario.id);
            var data = new
            {
                labels = historico.Select(entry => entry.data), // Supondo que "Date" é a propriedade que armazena a data no histórico de peso
                weights = historico.Select(entry => entry.peso) // Supondo que "Weight" é a propriedade que armazena o peso no histórico de peso
            };

            // Envie os dados como JSON
            return Json(data);
        }

        [Authorize]
        public IActionResult HistoricoPeso()
        {
            return View();
        }
    }
}
