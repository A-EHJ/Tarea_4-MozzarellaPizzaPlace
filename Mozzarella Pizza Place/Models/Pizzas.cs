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
            Precio = price;
            this.nivelPicante = nivelPicante;
        }

        public int PizzaId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public NivelPicante nivelPicante { get; set; }
    }
}
