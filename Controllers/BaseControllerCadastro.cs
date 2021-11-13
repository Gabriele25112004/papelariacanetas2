using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;


namespace papelariacanetas2.Controllers
{
    public class BaseControllerCadastro : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("cadastro")))
            {
                filterContext.HttpContext.Response.Redirect("/Login");
            }
        }
    }
}