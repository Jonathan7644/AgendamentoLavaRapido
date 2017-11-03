using AgendamentoLavaRapido.Models;
using System.Web.Mvc;

namespace AgendamentoLavaRapido.Controllers
{
    public class CadastroDeClienteController : Controller
    {
        // GET: CadastroDeCliente
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Cliente cliente)
        {
            cliente.Gravar(cliente);
            return RedirectToAction("Agendamento");
        }
    }
}