using JovemProgramadorMVC10.Data.Repositorio.Interfaces;
using JovemProgramadorMVC10.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC10.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(string email, string senha)
        {
            if(ModelState.IsValid) 
            {
                var usuarioValidado = _usuarioRepositorio.ValidarUsuario(email, senha);
                if (usuarioValidado != null)
                {
                    // Login bem-sucedido, redirecionar para a página principal
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Falha na validação do usuário
                    ModelState.AddModelError("", "Nome de usuário ou senha inválidos");
                    
                }
            }
            return View("Index");
        }
    }
}
