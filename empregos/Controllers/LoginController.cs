using empregos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace empregos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login(string login, string senhalogin)
        {
            empregobdEntities2 db = new empregobdEntities2();

            var nomeLogin = "";

            var temAcesso = (from user in db.usuarios where user.email == login && user.senha == senhalogin select user.nome).ToList();

            if (temAcesso.Count() == 0)
            {
                return Json(new { Success = false, Response = "Login inexistente" });
            }

            return Json(new { Success = true , nomeLogin = temAcesso[0]});
        }
    }
}