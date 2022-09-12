using System.Collections.Generic;
namespace tp1
{
    public class Pila<T> : IColeccionable
    {
        private IColeccionable coleccionable;

        private List<IComparable> comparables;

        public Pila()
        {
            comparables = new List<IComparable>();
        }

        private void apilar(IComparable elemento)
        {
            comparables.Add(elemento);
        }
        private IComparable desapilar()
        {
            IComparable elemento = comparables[comparables.Count - 1];
            comparables.RemoveAt(comparables.Count - 1);
            return elemento;
        }
        public int tamaño()
        {
            return comparables.Count;
        }

        public int cuantos()
        {
            return comparables.Count;
        }

        public IComparable minimo()
        {
            IComparable aux = comparables[0];
            for (int i = 0; i < comparables.Count; i++)
            {
                if (comparables[i].esMenor(aux))
                {
                    aux = comparables[i];
                }
            }
            return aux;
        }
        public IComparable maximo()
        {
            IComparable aux = comparables[0];
            for (int i = 0; i < comparables.Count; i++)
            {
                if (comparables[i].esMayor(aux))
                {
                    aux = comparables[i];
                }
            }
            return aux;
        }

        public void agregar(IComparable comparable)
        {
            apilar(comparable);
        }

        public bool contiene(IComparable comparable)
        {
            bool aux =false;
            for (int i = 0; i < comparables.Count; i++)
            {
                if (comparables[i].sosIgual(comparable))
                {
                    aux =true;
                }
            }
            return aux;
        }
    }
}