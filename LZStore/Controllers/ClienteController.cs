using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;
using LZStore.Models.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LZStore.Controllers
{
    public class ClienteController : Controller
    {

        private Response response; 
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarCliente([Bind("NomeCliente, SenhaCliente, EmailCliente, TelCliente, Cargo")] ClienteDto Cliente)
        {
            try
            {
                response = _clienteService.Cadastrar(Cliente);

                //if (!response.Success)
                //{
                //    return BadRequest(response);
                //}

                TempData["SuccessMessage"] = response.Notifications.FirstOrDefault();
                
                return RedirectToAction("CadastrarCliente");
                //return View;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

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
                ClienteDto usuario = new ClienteDto { EmailCliente = email, SenhaCliente = senha };
                bool resultado = _clienteService.EfetuarLogin(usuario);
                if (resultado == true)
                {
                    return RedirectToAction("CadastrarCliente");
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
