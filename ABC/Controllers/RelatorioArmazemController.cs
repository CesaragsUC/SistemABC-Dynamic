using ABC.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class RelatorioArmazemController : Controller
    {

        private Db db = new Db();
        // GET: RelatorioArmazem
        public ActionResult Index()
        {
            var totalpedido = db.Pedido.ToList();
            ViewBag.TotalP = totalpedido.Count;

            return View(db.Armazem.ToList());
        }


    }
}