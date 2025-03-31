using Microsoft.AspNetCore.Mvc;

namespace AplicacaoTeste.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }
    }
}
