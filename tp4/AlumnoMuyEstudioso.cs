namespace tp1.tp4
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, Numero promedio, Numero legajo, double calificacion) : base(nombre, dni, promedio, legajo, calificacion)
        {

        }

        public override double responderPregunta(double pregunta)
        {
            return pregunta % 3;
        }
    }
}