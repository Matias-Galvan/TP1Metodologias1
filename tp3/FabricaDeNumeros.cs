namespace tp1.tp3
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public tp1.IComparable crearAleatorio(){
            tp1.IComparable numero = new Numero (generadorDatosAleatorio.numeroAleatorio(100));
            return numero;
        }

        public tp1.IComparable crearPorTeclado(){
            Console.WriteLine("Creando número... ");
            Console.WriteLine("Inserte valor");
            tp1.IComparable numero = new Numero(LectorDeDatos.NumeroPorTeclado());
            return numero;
        }
    }
}