using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using empregos.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace empregos
{
    [HubName("notificationHub")]
    public class NotificationHub : Hub
    {
        empregotccEntities3 db = new empregotccEntities3();
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}

        public JsonResult MostrarDescricao(anuncio anuncio)
        {
            var list = db.anuncio.Select(x => x.descricao != "");
            Clients.All.Atualizar(anuncio);
            return new JsonResult { Data = list, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}