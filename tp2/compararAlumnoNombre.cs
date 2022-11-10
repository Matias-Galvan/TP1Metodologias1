namespace tp1.tp2
{
    public class compararAlumnoNombre : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((tp4.IDecoradorAlumnos)actual).getNombre() == (((tp4.IDecoradorAlumnos)comparable).getNombre()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool esMayor(IComparable actual, IComparable comparable)
        {
            if (((tp4.IDecoradorAlumnos)actual).getNombre().Length > (((tp4.IDecoradorAlumnos)comparable).getNombre().Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool esMenor(IComparable actual, IComparable comparable)
        {
            if (((tp4.IDecoradorAlumnos)actual).getNombre().Length < (((tp4.IDecoradorAlumnos)comparable).getNombre().Length))
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