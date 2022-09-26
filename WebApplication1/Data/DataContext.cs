using Cadastro_de_doacao.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_de_doacao.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
            public DbSet<AnimalModel> Animals { get; set; }
    }
}
