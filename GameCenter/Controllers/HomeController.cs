using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult perfil()
        {
            return View();
        }
        
        public ActionResult editarPerfil()
        {
            return View();
        }

        public ActionResult editarContraseña()
        {
            return View();
        }
        public ActionResult videojuegos()
        {
            return View();
        }
        public ActionResult videojuego()
        {
            return View();
        }
    }
}