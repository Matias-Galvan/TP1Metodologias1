namespace tp1.tp4
{
    public class DecoradorPromocion : Decorador
    {
        public DecoradorPromocion(IDecoradorAlumnos componente) : base(componente)
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
            string calificacion = null;
            if (getCalificacion() >= 7)
            {
                calificacion = "PROMOCIÓN";
            }
            if (getCalificacion() < 7)
            {
                calificacion = "APROBADO";
            }
            if (getCalificacion() <= 4)
            {
                calificacion = "DESAPROBADO";
            }
            return componente.mostrarCalificacion() + "(" + calificacion + ")";
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