using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTemplateIntegration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CadastroUsuarios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CadastroDeCurriculos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AberturaDeChamado()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Vagas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CadastroVagas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListaUsuarios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}