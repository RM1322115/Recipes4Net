namespace Core.Models
{
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
