namespace tp1.tp5
{
    public class AlumnoProxy : Persona, IProxyAlumno, tp4.IDecoradorAlumnos
    {
        private Numero legajo;
        private Numero promedio;

        private Numero calificacion;
        Alumno alumno = null;
        //Alumno alumno;

        public AlumnoProxy(string nombre, double dni, Numero legajo, Numero promedio, double calificacion) : base(nombre, dni)
        {
            this.legajo = new Numero(legajo.getValor());
            this.promedio = new Numero(promedio.getValor());
            this.calificacion = new Numero(calificacion);

        }

        public Numero getLegajo()
        {
            return legajo;
        }
        public Numero getPromedio()
        {
            return promedio;
        }

        public double getCalificacion()
        {
            return calificacion.getValor();
        }

        public void setCalificacion(double numero)
        {
            calificacion.setValor(numero);
        }

        public string mostrarCalificacion()
        {
            return this.getNombre() + " " + calificacion.getValor().ToString();
        }

        public virtual double responderPregunta(double pregunta)
        {
            if (alumno == null)
            {
                alumno = new Alumno(getNombre(), (int)getDNI(), getLegajo(), getPromedio(), getCalificacion());
                System.Console.WriteLine("Nueva instancia de alumno real");
            }
            return alumno.responderPregunta(pregunta);
        }
    }
}