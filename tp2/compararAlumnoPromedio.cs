namespace tp1.tp2
{
    public class compararAlumnoPromedio : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((Alumno)actual).getPromedio() == (((Alumno)comparable).getPromedio()))
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
            if ((((Alumno)actual).getPromedio()).getValor() > ((((Alumno)comparable).getPromedio())).getValor())
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
            if ((((Alumno)actual).getPromedio()).getValor() < ((((Alumno)comparable).getPromedio())).getValor())
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