namespace tp1
{
    public class Cola<T> : IColeccionable, tp1.tp2.Iterable
    {
        private List<IComparable> datos;

        public Cola()
        {
            datos = new List<IComparable>();
        }

        public void encolar(IComparable elem)
        {
            this.datos.Add(elem);
        }

        public IComparable desencolar()
        {
            IComparable temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }

        public IComparable tope()
        {
            return this.datos[0];
        }

        public bool esVacia()
        {
            return this.datos.Count == 0;
        }

		public int cuantos(){
			return datos.Count();
		}

		public IComparable minimo(){
			IComparable aux = datos[0];

			for (int i = 0; i < datos.Count; i++)
			{
				if (datos[i].esMenor(aux))
				{
					aux = datos[i];
				}
			}
			return aux;
		}

		public IComparable maximo(){
			IComparable aux = datos[0];

			for (int i = 0; i < datos.Count; i++)
			{
				if (datos[i].esMayor(aux))
				{
					aux = datos[i];
				}
			}
			return aux;
		}

		public void agregar(IComparable elemento){
			encolar(elemento);
		}

		public bool contiene(IComparable elemento){
			bool aux =false;
			for (int i = 0; i < datos.Count; i++)
			{
				if (datos[i].sosIgual(elemento))
				{
					aux = true;
				}
			}

			return aux;
		}

		//Metodo iterador

		public tp1.tp2.IteradorComparables crearIterador(){
			tp1.tp2.IteradorComparables iterador = new tp1.tp2.iteradorPilaConjuntoCola(datos);
			return iterador;
		}
    }
}
