namespace tp1.tp2
{
    public class compararAlumnoPromedio : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((tp4.IDecoradorAlumnos)actual).getPromedio() == (((tp4.IDecoradorAlumnos)comparable).getPromedio()))
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
            if ((((tp4.IDecoradorAlumnos)actual).getPromedio()).getValor() > ((((tp4.IDecoradorAlumnos)comparable).getPromedio())).getValor())
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
            if ((((tp4.IDecoradorAlumnos)actual).getPromedio()).getValor() < ((((tp4.IDecoradorAlumnos)comparable).getPromedio())).getValor())
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