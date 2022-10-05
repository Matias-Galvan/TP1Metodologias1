namespace tp1.tp2
{
    public class iteradorDiccionarios: IteradorComparables
    {
        List<ClaveValor> lista_claveValor;

        private int indice, indice_apuntador_finalLista;

        //Constructor

        public iteradorDiccionarios(List<ClaveValor> lista_claveValor){
            this.lista_claveValor = lista_claveValor;
            indice = 0;
            indice_apuntador_finalLista = this.lista_claveValor.Count;
        }

        //Metodos iterador

        public IComparable actual(){
            return lista_claveValor[indice].getValor();
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