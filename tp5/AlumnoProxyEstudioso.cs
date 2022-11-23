namespace tp1.tp5
{
    public class AlumnoProxyEstudioso : AlumnoProxy
    {
        tp4.AlumnoMuyEstudioso alumno;
        public AlumnoProxyEstudioso(string nombre, int dni, Numero promedio, Numero legajo, double calificacion) : base(nombre, dni, promedio, legajo, calificacion)
        {

        }
        public override double responderPregunta(double pregunta)
        {
            if (alumno == null)
            {
                alumno = new tp4.AlumnoMuyEstudioso(getNombre(), (int)getDNI(), getLegajo(), getPromedio(), getCalificacion());
                System.Console.WriteLine("Nueva instancia de alumno real estudioso");
            }
            return alumno.responderPregunta(pregunta);
        }
    }
}