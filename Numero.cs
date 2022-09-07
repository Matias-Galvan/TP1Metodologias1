namespace tp1
{
    public class Numero : IComparable
    {
        //Declaraciones de variables
        int valor;
        private IComparable comparable;
        //Constructores
        public Numero(int valor)
        {
            this.valor = valor;
        }

        //Métodos

        public int getValor()
        {
            return valor;
        }

        public bool esMayor(IComparable comparable)
        {
            //Casteo de la interfaz con la clase, sino da error
            Numero numero = (Numero) comparable;
            return true;
        }
        public bool esMenor(IComparable comparable)
        {
            Numero numero = (Numero) comparable;
            return true;
        }

        public bool sosIgual(IComparable comparable)
        {
            Numero numero = (Numero) comparable;
            return true;
        }
    }
}