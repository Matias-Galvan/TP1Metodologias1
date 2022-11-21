namespace tp1.tp5
{
    public interface IProxyAlumno
    {
        public Numero getLegajo();
        public Numero getPromedio();
        public string getNombre();
        public void setCalificacion(double numero);
        public string mostrarCalificacion();



    }
}