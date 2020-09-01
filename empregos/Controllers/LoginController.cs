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


        public ActionResult login(string login, string senhalogin)
        {
            empregotccEntities1 db = new empregotccEntities1();

            var nomeLogin = "";
            
            var temAcesso = (from user in db.usuario where user.email == login && user.senha == senhalogin select user.nome).ToList();

            var ticket = FormsAuthentication.Encrypt(new FormsAuthenticationTicket(1,temAcesso[0],DateTime.Now,DateTime.Now.AddHours(12),true,"ADM"));

            var coockie = new HttpCookie(FormsAuthentication.FormsCookieName, ticket);
            Response.Cookies.Add(coockie);

            if (temAcesso.Count() == 0)
            {
                return Json(new { Success = false, Response = "Login inexistente" });
            }
            else
            {
                return RedirectToAction("Index","Home");
            }

            return Json(new { Success = true, nomeLogin = temAcesso[0] });
        }
    }
}