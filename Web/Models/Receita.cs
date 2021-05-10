using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    //[Table("Receita")]
    public class Receita
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Igredientes { get; set; }
        public string Preparo { get; set; }
        public string Categoria { get; set; } 

        //BOLOS, CARNES, SOPAS, MASSAS, LANCHES ... 
    }
}
