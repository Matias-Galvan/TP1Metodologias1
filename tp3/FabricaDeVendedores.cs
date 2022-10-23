namespace tp1.tp3
{
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public IComparable crearAleatorio()
        {
            IComparable numero = new Vendedor(generadorDatosAleatorio.stringAleatorio(10), generadorDatosAleatorio.numeroAleatorio(999999999), generadorDatosAleatorio.numeroAleatorio(100000));
            return numero;
        }

        public IComparable crearPorTeclado()
        {
            System.Console.WriteLine("Creando vendedor");
            System.Console.WriteLine("Ingrese nombre");
            string nombre = LectorDeDatos.StringPorTeclado();
            System.Console.WriteLine("Ingrese documento");
            int dni = LectorDeDatos.NumeroPorTeclado();
            System.Console.WriteLine("Ingrese sueldo");
            int sueldo = LectorDeDatos.NumeroPorTeclado();

            IComparable vendedor = new Vendedor(nombre, dni, sueldo);
            return vendedor;
        }
    }
}