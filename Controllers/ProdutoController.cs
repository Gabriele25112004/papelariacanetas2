using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using papelariacanetas2.Models;
using Microsoft.AspNetCore.Http;

namespace papelariacanetas2.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Cadastro()
        {


            return View();

        }

        [HttpPost]
        public IActionResult Cadastro(Produto P)
        {


            try
            {
                ProdutoService produtoservice = new ProdutoService();
                produtoservice.Cadastro(P);
                return RedirectToAction("Listagem");
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao conectar ao DB" + e.Message);
                return View("Cadastro");
            }
        }

        public IActionResult Listagem(string tipofiltro, string filtro)
        {



            FiltroProduto objFiltro = null;

            if (!string.IsNullOrEmpty(filtro))
            {

                objFiltro = new FiltroProduto();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipofiltro;

            }

            ProdutoService produtoservice = new ProdutoService();

            return View(produtoservice.ListarTodos(objFiltro));

        }

        public IActionResult Editar(int id)
        {



            ProdutoService Ps = new ProdutoService();
            Produto P = Ps.ObterPorId(id);
            return View(P);

        }
        [HttpPost]
        public IActionResult Editar(Produto ProdEdit)
        {

            ProdutoService Us = new ProdutoService();
            Us.Editar(ProdEdit);

            return RedirectToAction("Listagem");

        }

        public IActionResult Excluir(int id)
        {

            Produto P = new ProdutoService().Listar(id);
            return View(P);

        }

        [HttpPost]
        public IActionResult Excluir(string decisao, int id)
        {

            if (decisao == "EXCLUIR")
            {

                ViewData["Mensagem"] = "Exclusão do Produto" + new ProdutoService().Listar(id).NomeProduto + "realizado com sucesso.";
                new ProdutoService().Excluir(id);
                return View("Listagem", new ProdutoService().Listar());

            }
            else
            {

                ViewData["Mensagem"] = "Exclusão bem sucedida";
                return View("Listagem", new ProdutoService().Listar());

            }

        }

        public IActionResult ElixirdAmourParfumsdElmar()
        {
            return View();
        }

    }

}