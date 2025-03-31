using AplicacaoTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoTeste.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options) { 
            

        }
        public DbSet<ContatosModel> Contatos { get; set;}
    }
}
