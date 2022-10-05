namespace tp1.tp2
{
    public class compararAlumnoPromedio : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((Alumno)actual).getLegajo() == (((Alumno)comparable).getLegajo()))
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
            if (((((Alumno)comparable).getLegajo())).getValor() > (((Alumno)actual).getLegajo()).getValor())
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
            if (((((Alumno)comparable).getLegajo())).getValor() < (((Alumno)actual).getLegajo()).getValor())
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