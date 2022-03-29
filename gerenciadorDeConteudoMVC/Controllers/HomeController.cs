using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gerenciadorDeConteudoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Adicionando dado que eu quero mostrar nessa view através de uma View Bag
            /*ViewBag.Paginas = new Pagina().Lista();*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Exemplo de URL para edição de cliente
        /*
        public ActionResult About(int id)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }*/

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}