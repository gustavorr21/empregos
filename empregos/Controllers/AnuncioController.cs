using empregos.Models;
using empregos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using System.IO;
using AutoMapper;

namespace empregos.Controllers
{
    public class AnuncioController : Controller
    {
        empregotccEntities3 db = new empregotccEntities3();
        // GET: Anuncio
        public ActionResult CreateAnuncio()
        {
            Session["categoria"] = new SelectList(db.categoria, "id", "titulo");
            return View();
        }

        [HttpPost]
        public ActionResult CreateAnuncio(AnuncioViewModel anuncio)
        {
            anuncio anuncioNew = new anuncio();

            string guid = Guid.NewGuid().ToString().ToUpper();
            var toPathUpload = Server.MapPath($"~/images/anuncio/{guid}");
            var newPathUploadFileName = $"{toPathUpload}/{anuncio.foto1}";
            var newPathUploadFileName2 = $"{toPathUpload}/{anuncio.foto2}";

            Directory.CreateDirectory(toPathUpload);
            System.IO.File.Create(newPathUploadFileName);
            System.IO.File.Create(newPathUploadFileName2);

            anuncioNew.idCategoria = anuncio.idcategoria;
            anuncioNew.preco = anuncio.preco;
            anuncioNew.medida = anuncio.medida;
            anuncioNew.descricao = anuncio.descricao;
            anuncioNew.foto1 = anuncio.foto1;
            anuncioNew.foto2 = anuncio.foto2;
            anuncioNew.idUsuario = anuncio.idUsuario;

            db.anuncio.Add(anuncioNew);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public ActionResult EditAnuncio()
        {
            var Idusuario = Convert.ToInt32(Session["LoginID"]);
            var anuncio = db.anuncio.Where(x => x.idUsuario == (Idusuario)).ToList();

            return View(anuncio);

        }

        public ActionResult ExibeAllAnuncios()
        {
            var anuncio = db.anuncio.ToList();
            List<anuncio> anun = new List<anuncio>();
            anun = db.anuncio.ToList();
            var anunciolista = Mapper.Map<List<anuncio>, List<AnuncioViewModel>>(anun);
            return View(anun);
        }
    }
}
