
using Mozzarella_Pizza_Place.Models;

namespace Mozzarella_Pizza_Place.MenuBLL
{
    public class Menu
    {
      
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Agregar(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? ObtenerPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}