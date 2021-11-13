using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace papelariacanetas2.Models
{
    public class PapelariaCanetasContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=PapelariaCanetas;Uid=root;");
        }

        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}