using empregos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace empregos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Home(usuario usuario)
        {
            empregotccEntities3 db = new empregotccEntities3();

            var nomeLogin = "";

            var temAcesso = db.usuario.Where(p => p.email.Equals(usuario.email) && p.senha.Equals(usuario.senha)).FirstOrDefault();

            //var ticket = FormsAuthentication.Encrypt(new FormsAuthenticationTicket(1,temAcesso[0],DateTime.Now,DateTime.Now.AddHours(12),true,"ADM"));

            //var coockie = new HttpCookie(FormsAuthentication.FormsCookieName, ticket);
            //Response.Cookies.Add(coockie);
            if (temAcesso == null)
            {
                return Json(new { Success = false, Response = "Login inexistente" });
            }
            else
            {
                Session["LoginID"] = temAcesso.id;
            }
            return View();
        }

        [HttpPost]
        public ActionResult login(string ReturnUrl, usuario usuario)
        {
            empregotccEntities3 db = new empregotccEntities3();

            var nomeLogin = "";

            var temAcesso = db.usuario.Where(p => p.email.Equals(usuario.email) && p.senha.Equals(usuario.senha)).FirstOrDefault();

            //var ticket = FormsAuthentication.Encrypt(new FormsAuthenticationTicket(1,temAcesso[0],DateTime.Now,DateTime.Now.AddHours(12),true,"ADM"));

            //var coockie = new HttpCookie(FormsAuthentication.FormsCookieName, ticket);
            //Response.Cookies.Add(coockie);
            if (temAcesso == null)
            {
                return Json(new { Success = false, Response = "Login inexistente" });
            }
            else
            {
                ViewData["NomeUsuarioteste"] = temAcesso.nome;
                ViewBag.NomeUsuario = temAcesso.nome;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult CreateUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUsuario(usuario usuario)
        {
            usuario NewUser = new usuario();
            empregotccEntities3 db = new empregotccEntities3();

            var pegaEmail = db.usuario.Where(p => p.email.Equals(usuario.email)).FirstOrDefault();
            var pegaCPF = db.usuario.Where(p => p.email.Equals(usuario.email)).FirstOrDefault();

            try
            {
                if (pegaEmail != null )
                {
                    return Json(new { Success = false, Response = "Email ja cadastrado" });
                }
                else if (pegaCPF != null)
                {
                    return Json(new { Success = false, Response = "CPF ja cadastrado" });
                }
                else
                {
                    NewUser.nome = usuario.nome;
                    NewUser.bairro = usuario.bairro;
                    NewUser.cep = usuario.cep;
                    NewUser.cidade = usuario.cidade;
                    NewUser.cpf = usuario.cpf;
                    NewUser.dataNascimento = usuario.dataNascimento;
                    NewUser.email = usuario.email;
                    NewUser.estado = usuario.estado;
                    NewUser.perfil = "ADM";
                    NewUser.rua = usuario.rua;
                    NewUser.senha = usuario.senha;
                    NewUser.telefone = usuario.telefone;
                    NewUser.telefone2 = usuario.telefone2;

                    db.usuario.Add(NewUser);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
            return Json(new { Success = true });
        }
    }
}