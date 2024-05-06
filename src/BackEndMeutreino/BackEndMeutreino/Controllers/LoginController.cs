using BackEndMeutreino.Infra;
using BackEndMeutreino.Models;
using BackEndMeutreino.Repositories.Interface;
using BackEndMeutreino.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace BackEndMeutreino.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioRepository repository;

        private readonly Authentication _hashService = new Authentication(SHA512.Create());


        public LoginController(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Usuario user)
        {
            var usuario = repository.GetUsuario(user.email);
            if (usuario == null)
            {
                return RedirectToAction("Index", new { errorLogin = true });
            }
            if (!_hashService.VerificarSenha(user.senha, usuario.senha))
            {
                return RedirectToAction("Index", new { errorLogin = true });
            }

            await new AuthService().Login(HttpContext, usuario);

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public IActionResult Index(bool errorLogin)
        {
            if (errorLogin)
            {
                ViewBag.Error = "Usuário ou senha inválidos";
            }
            return View();
        }


        [Authorize]
        public async Task<IActionResult> Logoff()
        {
            await new AuthService().Logoff(HttpContext);
            return RedirectToAction("Index");
        }
    }
}
