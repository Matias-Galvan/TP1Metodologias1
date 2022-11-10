namespace tp1.tp4
{
    public class DecoradorEnLetras : Decorador
    {
        public DecoradorEnLetras(IDecoradorAlumnos componente) : base(componente)
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
            string calificacion;

            switch (getCalificacion().ToString())
            {
                case "0":
                    calificacion = "CERO";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "1":
                    calificacion = "UNO";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "2":
                    calificacion = "DOS";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "3":
                    calificacion = "TRES";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "4":
                    calificacion = "CUATRO";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "5":
                    calificacion = "CINCO";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "6":
                    calificacion = "SEIS";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "7":
                    calificacion = "SIETE";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "8":
                    calificacion = "OCHO";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "9":
                    calificacion = "NUEVE";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                case "10":
                    calificacion = "DIEZ";
                    return componente.mostrarCalificacion() + "(" + calificacion + ")";

                default:

                    return componente.mostrarCalificacion() + "(Sin calificación)";


            }
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