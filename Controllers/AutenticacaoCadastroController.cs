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
    public class AutenticacaoCadastro : Controller
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/Login");
            }
        }

        public void incluirCadastro(Cadastro newCadastro)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {

                Ap.Cadastro.Add(newCadastro);
                Ap.SaveChanges();

            }

        }

        public static bool verificaLoginSenha(string login, string senha, Controller controller)
        {

            using (PapelariaCanetasContext Ap = new PapelariaCanetasContext())
            {


                IQueryable<Cadastro> CadastroEncontrado = Ap.Cadastro.Where(U => U.Login == login && U.Senha == senha);
                List<Cadastro> ListaCadastroEncontrado = CadastroEncontrado.ToList();

                if (ListaCadastroEncontrado.Count == 0)
                {

                    return false;

                }
                else
                {

                    controller.HttpContext.Session.SetString("login", ListaCadastroEncontrado[0].Login);
                    controller.HttpContext.Session.SetString("Nome", ListaCadastroEncontrado[0].Nome);
                    controller.HttpContext.Session.SetString("Email", ListaCadastroEncontrado[0].Email);
                    controller.HttpContext.Session.SetString("Senha", ListaCadastroEncontrado[0].Senha);
                    controller.HttpContext.Session.SetInt32("Id", ListaCadastroEncontrado[0].Id);

                    return true;

                }

            }

        }
    }
}