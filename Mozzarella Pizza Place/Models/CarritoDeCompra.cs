namespace Mozzarella_Pizza_Place.Models
{
    public class CarritoDeCompra
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool EstaPago { get; set; }
    }
}