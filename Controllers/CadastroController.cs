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
    public class CadastroController : Controller
    {

        private readonly ILogger<CadastroController> _logger;

        public CadastroController(ILogger<CadastroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Cadastro()
        {


            return View();

        }

        [HttpPost]
        public IActionResult Cadastro(Cadastro newUser)
        {

            try
            {
                CadastroService Us = new CadastroService();
                Us.Cadastro(newUser);
                return RedirectToAction("CadastroRealizado");
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao conectar ao DB" + e.Message);
                return View("Cadastro");
            }



        }

        public IActionResult CadastroRealizado()
        {


            return View();

        }

        public IActionResult Listagem(string tipofiltro, string filtro)
        {


            FiltroCadastro objFiltro = null;

            if (!string.IsNullOrEmpty(filtro))
            {

                objFiltro = new FiltroCadastro();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipofiltro;

            }

            CadastroService CadastroService = new CadastroService();

            return View(CadastroService.ListarTodos(objFiltro));

        }


        public IActionResult Editar(int id)
        {

            Cadastro C = new CadastroService().Listar(id);

            return View(C);

        }

        [HttpPost]
        public IActionResult Editar(Cadastro cadastroEdit)
        {

            CadastroService Us = new CadastroService();
            Us.Editar(cadastroEdit);

            return RedirectToAction("Perfil");

        }

        public IActionResult logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Excluir(int id)
        {

            Cadastro F = new CadastroService().Listar(id);
            return View(F);

        }

        [HttpPost]
        public IActionResult Excluir(string decisao, int id)
        {

            if (decisao == "EXCLUIR")
            {

                ViewData["Mensagem"] = "Exclusão do Cadastro" + new CadastroService().Listar(id).Nome + "realizado com sucesso.";
                new CadastroService().Excluir(id);
                return View("Home", new CadastroService().Listar());

            }
            else
            {

                ViewData["Mensagem"] = "Exclusão bem sucedida";
                return View("Home", new CadastroService().Listar());

            }

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {



            if (AutenticacaoCadastro.verificaLoginSenha(login, senha, this))
            {
                return RedirectToAction("Perfil");

            }
            else
            {

                ViewData["Erro"] = "Senha inválida";
                return View();

            }
        }

        public IActionResult Perfil()
        {

            return View();

        }

    }
}