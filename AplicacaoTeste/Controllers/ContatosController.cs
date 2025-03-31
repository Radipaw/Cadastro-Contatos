using AplicacaoTeste.Models;
using AplicacaoTeste.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoTeste.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatosController(IContatoRepositorio contato)
        {
            _contatoRepositorio = contato;
        }
        public IActionResult Index()
        {
            List<ContatosModel> contatos = _contatoRepositorio.GetContatos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult DeletarConfirmacao(int id)
        {
            ContatosModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            ContatosModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Criar(ContatosModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Atualizar(ContatosModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
