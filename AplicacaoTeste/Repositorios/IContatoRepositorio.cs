using AplicacaoTeste.Models;

namespace AplicacaoTeste.Repositorios
{
    public interface IContatoRepositorio
    {
        ContatosModel ListarPorId(int id);
        List<ContatosModel> GetContatos();
        ContatosModel Adicionar(ContatosModel contato);
        ContatosModel Atualizar(ContatosModel contato);

        bool Apagar(int id);

    }
}
