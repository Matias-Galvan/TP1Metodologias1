namespace tp1
{
    public class Persona : IComparable //Aca se implementaba IComparable, esta implementado en Alumno para entregar el ej 18
    {
        private string nombre;
        private Numero dni;

        public Persona(string n, double d)
        {
            this.nombre = n;
            this.dni = new Numero(d);
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getDNI()
        {
            return dni.getValor();
        }

        public virtual bool esMayor(IComparable persona)
        {
            if (dni.getValor() > ((tp4.IDecoradorAlumnos)persona).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool esMenor(IComparable persona)
        {
            if (dni.getValor() < ((tp4.IDecoradorAlumnos)persona).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool sosIgual(IComparable persona)
        {
            if (dni.getValor() == ((tp4.IDecoradorAlumnos)persona).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}