using empregos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace empregos.Controllers
{
    public class HomeController : Controller
    {
        empregotccEntities3 db = new empregotccEntities3();
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "ADMin")]
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

        public JsonResult GetAllAnuncio()
        {
            var list = db.anuncio.Where(x => x.descricao != "").ToList();
            List<anuncio> anun = new List<anuncio>();
            anun.AddRange(list);
            
            return new JsonResult { Data = anun.Union(anun).Select(x=>x.descricao), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
