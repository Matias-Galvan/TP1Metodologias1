namespace tp1.tp4
{
    public abstract class Decorador : IDecoradorAlumnos
    {
        //Declaración de componente
        protected IDecoradorAlumnos componente;

        //Constructor

        public Decorador(IDecoradorAlumnos componente)
        {
            this.componente = componente;
        }

        //Métodos

        abstract public double getDNI();
        abstract public Numero getLegajo();
        abstract public string getNombre();
        abstract public Numero getPromedio();
        abstract public double getCalificacion();

        abstract public string mostrarCalificacion();
        abstract public void setCalificacion(double numero);
        abstract public double responderPregunta(double pregunta);
        abstract public bool sosIgual(IComparable comparable);
        abstract public bool esMenor(IComparable comparable);
        abstract public bool esMayor(IComparable comparable);
    }
}