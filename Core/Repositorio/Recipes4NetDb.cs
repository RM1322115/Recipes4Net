using Core.Models;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Core.Repositorio
{
    public class Recipes4NetDb : DbContext
    {
        
        public Recipes4NetDb(DbContextOptions<Recipes4NetDb> options) : base(options)
        {
            Database.EnsureCreated();

        }

        public DbSet<Receita> ReceitaDb { get; set; }
    }
}
