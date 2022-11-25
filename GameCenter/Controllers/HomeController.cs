using GameCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCenter.Controllers
{
    public class HomeController : Controller
    {
        private GameCenterEntities1 db = new GameCenterEntities1();
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
            List<usuario> lista = db.usuario.ToList();
            return View(lista);
        }
        
        public ActionResult editarPerfil()
        {
            List<usuario> lista = db.usuario.ToList();
            return View(lista);
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