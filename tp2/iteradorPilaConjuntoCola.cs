namespace tp1.tp2
{
    public class iteradorPilaConjuntoCola:IteradorComparables //no olvidarse la herencia sino rompe todo
    {
        List<IComparable> listaComparables_pila;

        private int indice, indice_apuntador_finalLista;

        //Constructor

        public iteradorPilaConjuntoCola(List<IComparable> comparables){
            this.listaComparables_pila = comparables;
            indice = 0;
            indice_apuntador_finalLista = this.listaComparables_pila.Count;
        }

        //Metodos iterador

        public IComparable actual(){
            return listaComparables_pila[indice];
        }

        public bool fin(){
            if (indice >= indice_apuntador_finalLista){
                return true;
            }else{
                return false;
            }
        }

        public void primero(){
            indice = 0;
        }

        public void siguiente(){
            indice = indice + 1;
        }
    }
}