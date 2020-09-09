using empregos.Models;
using empregos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace empregos.Controllers
{
    public class AnuncioController : Controller
    {
        // GET: Anuncio
        public ActionResult CreateAnuncio()
        {
            empregotccEntities2 db = new empregotccEntities2();

            Session["categoria"] = new SelectList(db.categoria, "id", "titulo");
            return View();
        }

        [HttpPost]
        public ActionResult CreateAnuncio(AnuncioViewModel anuncio)
        {
            return View();
        }
    }
}