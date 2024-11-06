using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;
using LZStore.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace LZStore.Controllers
{
    public class UsuarioController : Controller
    {
        private Response response;
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

                    return RedirectToAction("ListarProdutos", "Produto");
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

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarUsuario([Bind("NomeCliente, SenhaCliente, EmailCliente, TelCliente, TipoUsuario")] UsuarioDto Usuario)
        {
            try
            {
                response = _usuarioService.Cadastrar(Usuario);

                //if (!response.Success)
                //{
                //    return BadRequest(response);
                //}

                TempData["SuccessMessage"] = response.Notifications.FirstOrDefault();

                return RedirectToAction("Login");
                //return View;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
