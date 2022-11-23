namespace tp1.tp5
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(IComparable alumno)
        {
            tp4.AdaptadorAlumnos alumnoAdapter = new tp4.AdaptadorAlumnos(alumno);
            aula.nuevoAlumno(alumnoAdapter);
        }
    }
}