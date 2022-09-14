namespace tp1
{
    public class Alumno : Persona
    {
        private Numero legajo;
        private Numero promedio;
        private IComparable comparable;

        public Alumno(string n, int d, Numero legajo, Numero promedio) : base(n, d)
        {
            this.legajo = new Numero(legajo.getValor());
            this.promedio = new Numero(promedio.getValor());
        }

        public Numero getLegajo()
        {
            return legajo;
        }

        public Numero getPromedio()
        {
            return promedio;
        }

        public override bool esMayor(IComparable comparable)
        {
            Alumno legajoAlumno = (Alumno)comparable;
            if (this.getLegajo().getValor() > legajoAlumno.getLegajo().getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool esMenor(IComparable comparable)
        {
            Alumno legajoAlumno = (Alumno)comparable;
            if (this.getLegajo().getValor() < legajoAlumno.getLegajo().getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool sosIgual(IComparable comparable)
        {
            Alumno legajoAlumno = (Alumno)comparable;
            if (this.getLegajo().getValor() == legajoAlumno.getLegajo().getValor())
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