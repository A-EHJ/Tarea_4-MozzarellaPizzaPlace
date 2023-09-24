namespace Mozzarella_Pizza_Place.Models
{
    public class Pizzas
    {
        public enum NivelPicante
        {
            Ninguno,
            Picante,
            MuyPicante
        }

        public Pizzas(int id, string nombre, decimal price, NivelPicante nivelPicante)
        {
            PizzaId = id;
            Nombre = nombre;
            Price = price;
            this.nivelPicante = nivelPicante;
        }

        public int PizzaId { get; set; }
        public string Nombre { get; set; }
        public decimal Price { get; set; }
        public NivelPicante nivelPicante { get; set; }
    }
}
