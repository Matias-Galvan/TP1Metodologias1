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
            Numero numero = (Numero)comparable;
            if (numero.getValor() > this.getValor())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool esMenor(IComparable comparable)
        {
            //Casteo de la interfaz con la clase, sino da error
            Numero numero = (Numero)comparable;
            if (numero.getValor() < this.getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosIgual(IComparable comparable)
        {
            //Casteo de la interfaz con la clase, sino da error
            Numero numero = (Numero)comparable;
            if (numero.getValor() == this.getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}