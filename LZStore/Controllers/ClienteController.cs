using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace LZStore.Controllers
{
    public class ClienteController : Controller
    {
        
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
                _clienteService.Cadastrar(Cliente);
                //TempData["SuccessMessage"] = "CLIENTE " + Cliente.NomeCliente + " CADASTRADO COM SUCESSO";
                return RedirectToAction("CadastrarCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
