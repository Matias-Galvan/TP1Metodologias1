using System.Collections.Generic;
namespace tp1
{
    public class Pila<T> : IColeccionable, tp1.tp2.Iterable, tp5.IOrdenable
    {
        private IColeccionable coleccionable;

        private List<IComparable> comparables;

        //TP5
        tp5.OrdenEnAula1 ordenInicio;
        tp5.OrdenEnAula2 ordenLlegaAlumno;
        tp5.OrdenEnAula1 ordenAulaLlena;

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
            //TP5 Ejercicio 9
            if (comparables.Count == 0)
            {
                ordenInicio.ejecutar();
            }
            ordenLlegaAlumno.ejecutar(comparable);
            apilar(comparable);
            if (comparables.Count == 40)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public bool contiene(IComparable comparable)
        {
            bool aux = false;
            for (int i = 0; i < comparables.Count; i++)
            {
                if (comparables[i].sosIgual(comparable))
                {
                    aux = true;
                }
            }
            return aux;
        }

        public tp1.tp2.IteradorComparables crearIterador()
        {

            tp2.IteradorComparables iterador = new tp1.tp2.iteradorPilaConjuntoCola(comparables);
            return iterador;

        }

        //TP5 Command

        public void setOrdenInicio(tp5.OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }
        public void setOrdenLlegaAlumno(tp5.OrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }
        public void setOrdenAulaLlena(tp5.OrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }
    }
}