namespace tp1.tp2
{
    public class compararAlumnoNombre : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((Alumno)actual).getNombre() == (((Alumno)comparable).getNombre()))
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
            if (((Alumno)actual).getNombre().Length > (((Alumno)comparable).getNombre().Length))
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
            if (((Alumno)actual).getNombre().Length < (((Alumno)comparable).getNombre().Length))
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