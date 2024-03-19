namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba el código de la pieza: ");
            String NumeroDePieza = Console.ReadLine();

            Console.Write("Escriba la descripción de la pieza: ");
            String DescripcionDePieza = Console.ReadLine();

            Console.Write("Escriba la cantidad de piezas: ");
            int CantidadDeArticulos = int.Parse(Console.ReadLine());

            Console.Write("Escriba el precio unitario de la pieza: ");
            int PrecioPorArticulo = int.Parse(Console.ReadLine());

            Factura factura = new Factura(NumeroDePieza, DescripcionDePieza, CantidadDeArticulos, PrecioPorArticulo);

            Console.WriteLine("Número de Pieza: " + factura.NumeroDePieza);
            Console.WriteLine("Descripción de Pieza: " + factura.DescripcionDePieza);
            Console.WriteLine("Cantidad de Artículos: " + factura.CantidadDeArticulos);
            Console.WriteLine("Precio por Artículo: " + factura.PrecioPorArticulo);
            Console.WriteLine("Monto de la Factura: " + factura.ObtenerMontoFactura());
        }
    }

    class Factura
    {
        public string NumeroDePieza { get; set; }
        public string DescripcionDePieza { get; set; }
        public int CantidadDeArticulos { get; set; }
        public int PrecioPorArticulo { get; set; }

        public Factura(string numeroDePieza, string descripcionDePieza, int cantidadDeArticulos, int precioPorArticulo)
        {
            EstablecerNumeroPieza(numeroDePieza);
            EstablecerDescripcion(descripcionDePieza);
            EstablecerCantidad(cantidadDeArticulos);
            EstablecerPrecio(precioPorArticulo);
        }

        public void EstablecerNumeroPieza(String numeroDePieza)
        {
            NumeroDePieza = numeroDePieza;
        }

        public void EstablecerDescripcion(String descripcionDePieza)
        {
            DescripcionDePieza = descripcionDePieza;
        }

        public void EstablecerCantidad(int cantidadDeArticulos)
        {
            CantidadDeArticulos = cantidadDeArticulos > 0 ? cantidadDeArticulos : 0;
        }

        public void EstablecerPrecio(int precioPorArticulo)
        {
            PrecioPorArticulo = precioPorArticulo > 0 ? precioPorArticulo : 0;
        }

        public int ObtenerMontoFactura()
        {
            return CantidadDeArticulos * PrecioPorArticulo;
        }
    }
}
