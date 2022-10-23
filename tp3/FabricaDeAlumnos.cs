namespace tp1.tp3
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public tp1.IComparable crearAleatorio()
        {
            tp1.Numero legajo = new Numero(generadorDatosAleatorio.numeroAleatorio(9999));
            tp1.Numero promedio = new Numero(generadorDatosAleatorio.numeroAleatorio(10));
            tp1.IComparable alumno = new Alumno(tp3.generadorDatosAleatorio.stringAleatorio(10), tp3.generadorDatosAleatorio.numeroAleatorio(99999999), legajo, promedio);
            return alumno;
        }

        public tp1.IComparable crearPorTeclado()
        {
            System.Console.WriteLine("Creando alumno...");
            System.Console.WriteLine("Ingrese nombre");
            string nombre = LectorDeDatos.StringPorTeclado();
            System.Console.WriteLine("Ingrese dni");
            int dni = LectorDeDatos.NumeroPorTeclado();
            System.Console.WriteLine("Ingrese legajo");
            tp1.Numero legajo = new Numero(LectorDeDatos.NumeroPorTeclado());
            System.Console.WriteLine("Ingrese promedio");
            tp1.Numero promedio = new Numero(LectorDeDatos.NumeroPorTeclado());
            tp1.IComparable alumno = new Alumno(nombre, dni, legajo, promedio);
            return alumno;
        }
    }
}