namespace tp1
{
    public class Numero : IComparable
    {
        //Declaraciones de variables
        double valor;
        private IComparable comparable;
        //Constructores
        public Numero(double valor)
        {
            this.valor = valor;
        }

        //Métodos

        public double getValor()
        {
            return valor;
        }

        public void setValor(double numero){
            valor = numero;
        }

        public bool esMayor(IComparable comparable)
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
        public bool esMenor(IComparable comparable)
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