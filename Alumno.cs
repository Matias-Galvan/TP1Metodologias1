namespace tp1
{
    public class Alumno : Persona
    {
        private Numero legajo;
        private Numero promedio;
        private IComparable comparable;
        private IStrategy estrategia;

        public Alumno(string n, int d, Numero legajo, Numero promedio) : base(n, d)
        {
            this.legajo = new Numero(legajo.getValor());
            this.promedio = new Numero(promedio.getValor());
            estrategia = new tp1.tp2.compararAlumnoLegajo(); //Para acceder a la subcarpeta se coloca el namespace correspondiente
        }

        public Type obtenerEstrategia()
        { //Declaro método para obtener la interfaz con la estrategia seleccionada, con el uso de Type
            return estrategia.GetType();
        }

        public void setearEstrategia(string estrategia)
        {
            switch (estrategia)
            {
                case "Nombre":
                    this.estrategia = new tp1.tp2.compararAlumnoNombre();
                    break;
                case "DNI":
                    this.estrategia = new tp1.tp2.compararAlumnoDNI();
                    break;
                case "Legajo":
                    this.estrategia = new tp1.tp2.compararAlumnoLegajo();
                    break;
                case "Promedio":
                    this.estrategia = new tp1.tp2.compararAlumnoPromedio();
                    break;

            }
        }

        public Numero getLegajo()
        {
            return legajo;
        }

        public Numero getPromedio()
        {
            return promedio;
        }

        public override bool esMayor(IComparable comparable)
        {
            return estrategia.esMayor(this, comparable);
        }
        public override bool esMenor(IComparable comparable)
        {
            return estrategia.esMenor(this,comparable);
        }
        public override bool sosIgual(IComparable comparable)
        {
            return estrategia.sosIgual(this, comparable);
        }


    }
}