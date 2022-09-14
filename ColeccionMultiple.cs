using System.Collections.Generic;
namespace tp1
{
    public class ColeccionMultiple : IColeccionable
    {
        Pila<IComparable> pila;
        Cola<IComparable> cola;

        public ColeccionMultiple(Pila<IComparable> pila, Cola<IComparable> cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable minimo()
        {
            IComparable num1 = pila.minimo();
            IComparable num2 = cola.minimo();
            if (num1.esMenor(num2))
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public IComparable maximo()
        {
            IComparable num1 = pila.maximo();
            IComparable num2 = cola.maximo();
            if (num1.esMayor(num2))
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public void agregar(IComparable elemento)
        {
            System.Console.WriteLine("Funcion agregar sin logica");
        }

        public bool contiene(IComparable elemento)
        {
            if (pila.contiene(elemento) || cola.contiene(elemento))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}