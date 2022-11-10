namespace tp1.tp2
{
    public class compararAlumnoLegajo : IStrategy
    {
        public bool sosIgual(IComparable actual, IComparable comparable)
        {
            if (((tp4.IDecoradorAlumnos)actual).getLegajo().getValor() == (((tp4.IDecoradorAlumnos)comparable).getLegajo().getValor()))
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
            if ((((tp4.IDecoradorAlumnos)actual).getLegajo()).getValor() > ((((tp4.IDecoradorAlumnos)comparable).getLegajo())).getValor())
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
            if ((((tp4.IDecoradorAlumnos)actual).getLegajo()).getValor() < ((((tp4.IDecoradorAlumnos)comparable).getLegajo())).getValor())
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