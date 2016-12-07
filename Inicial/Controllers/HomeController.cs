using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inicial.Controllers
{
    //every controller inherits this clas Controller
    public class HomeController : Controller
    {
        // GET: Home //action atende request web e sempre return ACtionResult
        public ActionResult Index()
        {
            //chama a logica de negocio

            //depois redireciona para a view
            return View();
        }
    }
}