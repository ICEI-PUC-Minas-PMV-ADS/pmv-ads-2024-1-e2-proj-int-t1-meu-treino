using BackEndMeutreino.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace BackEndMeutreino.Services
{
    public class AuthService
    {

        public async Task Login(HttpContext context, Usuario user)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, user.nome),
                new(ClaimTypes.Role, user.role),
                new(ClaimTypes.Email, user.email),
                new("role", user.role),
            };
            
            var claimsIdentity = new ClaimsPrincipal(new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme));

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                IssuedUtc = DateTimeOffset.UtcNow,

            };

            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity, authProperties);


        }

        public async Task Logoff(HttpContext context)
        {
            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
