namespace tp1.tp2
{
    public class compararAlumnoDNI: IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((Alumno)actual).getDNI() == (((Alumno)comparable).getDNI()))
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
            if (((Alumno)actual).getDNI() > (((Alumno)comparable).getDNI()))
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
            if (((Alumno)actual).getDNI() < (((Alumno)comparable).getDNI()))
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