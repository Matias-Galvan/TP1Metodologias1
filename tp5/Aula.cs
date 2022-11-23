namespace tp1.tp5
{
    public class Aula
    {
        tp4.Teacher profesor;
        OrdenEnAula1 ordenEnAula1;

        public Aula()
        {

        }
        public void comenzar()
        {
            profesor = new tp4.Teacher();
        }
        public void nuevoAlumno(tp4.Student alumno)
        {
            profesor.goToClass(alumno);
        }
        public void claseLista()
        {
            profesor.teachingAClass();
        }
        public void setOrdenAula1()
        {
            this.ordenEnAula1 = ordenEnAula1;
        }
    }
}