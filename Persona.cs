namespace tp1
{
    public class Persona //Aca se implementaba IComparable, esta implementado en Alumno para entregar el ej 18
    {
        private string nombre;
        private Numero dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = new Numero(d);
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDNI()
        {
            return dni.getValor();
        }

        // public bool esMayor(IComparable persona)
        // {
        //     if (dni.getValor() > ((Persona)persona).getDNI())
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        // public bool esMenor(IComparable persona)
        // {
        //     if (dni.getValor() < ((Persona)persona).getDNI())
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        // public bool sosIgual(IComparable persona)
        // {
        //     if (dni.getValor() == ((Persona)persona).getDNI())
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
    }
}