namespace tp1.tp4
{
    public class FabricaAlumnosEstudiosos : tp3.FabricaDeComparables
    {
        public tp1.IComparable crearAleatorio()
        {
            tp1.Numero legajo = new Numero(tp3.generadorDatosAleatorio.numeroAleatorio(9999));
            tp1.Numero promedio = new Numero(tp3.generadorDatosAleatorio.numeroAleatorio(10));
            tp1.IComparable alumno = new AlumnoMuyEstudioso(tp3.generadorDatosAleatorio.stringAleatorio(10), tp3.generadorDatosAleatorio.numeroAleatorio(99999999), legajo, promedio, tp3.generadorDatosAleatorio.numeroAleatorio(7, 10));
            return alumno;
        }

        public tp1.IComparable crearPorTeclado()
        {
            System.Console.WriteLine("Creando alumno...");
            System.Console.WriteLine("Ingrese nombre");
            string nombre = tp3.LectorDeDatos.StringPorTeclado();
            System.Console.WriteLine("Ingrese dni");
            int dni = tp3.LectorDeDatos.NumeroPorTeclado();
            System.Console.WriteLine("Ingrese legajo");
            tp1.Numero legajo = new Numero(tp3.LectorDeDatos.NumeroPorTeclado());
            System.Console.WriteLine("Ingrese promedio");
            tp1.Numero promedio = new Numero(tp3.LectorDeDatos.NumeroPorTeclado());
            tp1.IComparable alumno = new Alumno(nombre, dni, legajo, promedio, tp3.LectorDeDatos.NumeroPorTeclado());
            return alumno;
        }
    }
}