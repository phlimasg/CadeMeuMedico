using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teste3.Controllers
{
    public class TesteLayoutController : Controller
    {
        // GET: TesteLayout
        public ActionResult Index()
        {
            ViewBag.AppTitle = "Nome do Controller";
            return View();
        }
    }
}