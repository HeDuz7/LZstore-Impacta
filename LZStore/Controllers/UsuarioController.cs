using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace LZStore.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            try
            {
                UsuarioDto usuario = new UsuarioDto { EmailCliente = email, SenhaCliente = senha };
                bool resultado = _usuarioService.EfetuarLogin(usuario);
                if (resultado == true)
                {
                    return Redirect("/CadastrarCliente");
                }
                else
                {
                    return RedirectToAction();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
