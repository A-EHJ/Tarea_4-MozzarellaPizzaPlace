using Mozzarella_Pizza_Place.MenuBLL;

namespace Mozzarella_Pizza_Place.Models
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public CarritoDeCompra CarritoDeCompra { get; } = new CarritoDeCompra();
        public UI UI { get; set; } = new UI();
        public decimal PrecioTotal => CarritoDeCompra.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
