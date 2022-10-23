namespace tp1.tp3
{
    //Ejercicio 3
    public class LectorDeDatos
    {
        static public int NumeroPorTeclado(){
            Int32 lectura = Int32.Parse(Console.ReadLine());
            return lectura;
        }
        static public string StringPorTeclado(){
            string lectura = Console.ReadLine();
            return lectura;
        }
    }
}