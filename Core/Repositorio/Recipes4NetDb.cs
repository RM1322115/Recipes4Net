using Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Core.Repositorio
{
    public class Recipes4NetDb : DbContext
    {

        public Recipes4NetDb(DbContextOptions<Recipes4NetDb> options) : base(options)
        {
            //Database.EnsureCreated();
        }


        public DbSet<Receita> Receita_db { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string StrConn = @"server=localhost;database=Recipes4Net;integrated security=true";
        //    optionsBuilder.UseSqlServer(StrConn);
        //}

    }
}
