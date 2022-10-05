namespace tp1.tp2
{
    public class ClaveValor
    {
        IComparable clave;
        IComparable valor;

        //Constructor
        public ClaveValor(IComparable clave, IComparable valor){
            this.clave = clave;
            this.valor = valor;
        }

        //Metodos
        public IComparable getClave(){
            return clave;
        }

        public IComparable getValor(){
            return valor;
        }
    }
}