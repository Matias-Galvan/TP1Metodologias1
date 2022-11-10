namespace tp1.tp4
{
    public class DecoradorAsteriscos : Decorador
    {
        //Constructor
        public DecoradorAsteriscos(IDecoradorAlumnos componente) : base(componente)
        {

        }

        public override double getDNI()
        {
            return componente.getDNI();
        }
        public override Numero getLegajo()
        {
            return componente.getLegajo();
        }
        public override Numero getPromedio()
        {
            return componente.getPromedio();
        }
        public override double getCalificacion()
        {
            return componente.getCalificacion();
        }
        public override string getNombre()
        {
            return componente.getNombre();
        }
        public override string mostrarCalificacion()
        {
            int longitud = componente.mostrarCalificacion().Length;
            string lineaAsteriscos = "*";
            for (int i = 0; i < longitud; i++)
            {
                lineaAsteriscos = lineaAsteriscos + "*";
            }

            return lineaAsteriscos + "\n" + "*" + componente.mostrarCalificacion() + "*" + "\n" + lineaAsteriscos;
        }

        public override bool esMayor(IComparable comparable)
        {
            return componente.esMayor(comparable);
        }
        public override bool esMenor(IComparable comparable)
        {
            return componente.esMenor(comparable);
        }
        public override void setCalificacion(double numero)
        {
            componente.setCalificacion(numero);
        }
        public override bool sosIgual(IComparable comparable)
        {
            return componente.sosIgual(comparable);
        }
        public override double responderPregunta(double pregunta)
        {
            return componente.responderPregunta(pregunta);
        }
    }
}