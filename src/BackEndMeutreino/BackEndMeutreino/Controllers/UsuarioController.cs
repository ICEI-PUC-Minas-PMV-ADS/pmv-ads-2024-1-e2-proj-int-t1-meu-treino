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


        
}
