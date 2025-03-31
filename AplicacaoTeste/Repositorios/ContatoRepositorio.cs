using AplicacaoTeste.Data;
using AplicacaoTeste.Models;

namespace AplicacaoTeste.Repositorios
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext )
        {
            _bancoContext = bancoContext;
        }
        public ContatosModel Adicionar(ContatosModel contato)
        {
            _bancoContext.Contatos.Add( contato );
            _bancoContext.SaveChanges();

            return contato;
        }

        public ContatosModel Atualizar(ContatosModel contato)
        {
            ContatosModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null) { throw new Exception("Não foi possível encontrar o contato "); }

                contatoDB.Nome = contato.Nome;
                contatoDB.Telefone = contato.Telefone;
                contatoDB.Email = contato.Email;

                _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
            
        }

        public bool Apagar(int id)
        {
            ContatosModel contatoDB = ListarPorId(id);
            if (contatoDB == null) { throw new Exception("Não foi possível encontrar o contato "); }

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public List<ContatosModel> GetContatos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatosModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x=>x.Id == id);
        }
    }
}
