using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendamentoLavaRapido.Controllers
{
    public class AgendamentoController : Controller
    {
        // GET: Agendamento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agendamento()
        {
            return View();
        }
    }
}