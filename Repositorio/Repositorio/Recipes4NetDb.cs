using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes4Net.Web.Models;

namespace Recipes4Net.Web.Repositorio
{
    public class Recipes4NetDb : DbContext
    {
        public Recipes4NetDb(DbContextOptions<Recipes4NetDb> options) : base(options)
        { }

        public DbSet<Receita> ReceitaDb { get; set; }
    }
}
