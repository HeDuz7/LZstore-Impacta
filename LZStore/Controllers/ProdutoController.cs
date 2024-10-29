using LZStore.Models.Dtos;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;
using LZStore.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using LZStore.Models.Services;

namespace LZStore.Controllers
{
    public class ProdutoController : Controller
    {

        private Response response;
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarProduto([Bind("NomeProduto, PrecoProduto, DescProduto, IMGProduto, EstoqueProd, ModeloProd, TamanhoProd")] ProdutoDto Produto)
        {
            try
            {
                response = _produtoService.Cadastrar(Produto);

                TempData["SuccessMessage"] = response.Notifications.FirstOrDefault();

                //return RedirectToAction("CadastrarCliente", "Cliente");
                return RedirectToAction("ListarProdutos");
                //return View;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public IActionResult ListarProdutos()
        {
            try
            {
                var produto = _produtoService.Listar();
                return View(produto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetalhesProduto(string? id)
        {
            try
            {

                if (string.IsNullOrEmpty(id))
                {
                    return NotFound();
                }

                TempData["SuccessMessage"] = response.Notifications.FirstOrDefault();

                return RedirectToAction("ListarProdutos");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
