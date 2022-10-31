namespace tp1.tp4
{
    public interface IDecoradorAlumnos : IComparable
    {
        public double getCalificacion();
        public Numero getLegajo();
        public Numero getPromedio();
        public string getNombre();
        public double getDNI();
        public double responderPregunta(double pregunta);
        public void setCalificacion(double numero);
        public string mostrarCalificacion();
    }
}