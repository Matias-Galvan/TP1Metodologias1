using System;
using System.Collections.Generic;

namespace tp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numero numero1 = new Numero(5);
            Numero numero2 = new Numero(2);

            Pila<IComparable> pila = new Pila<IComparable>();

            // System.Console.WriteLine("Es mayor?", numero1.esMayor(numero2));
            // if (numero1.esMenor(numero2))
            // {
            //     System.Console.WriteLine("Es menor");
            // }
            llenar(pila);


        }
        //Ejercicio 5
        static public void llenar(IColeccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Random numeroAleatorio = new Random();
                IComparable comparable = new Numero(numeroAleatorio.Next(50));
                coleccionable.agregar(comparable);

            }
        }

        //Ejercicio 6
        static public void informar(IColeccionable coleccionable){
            IComparable maximo = coleccionable.maximo();
            IComparable minimo = coleccionable.minimo();
            System.Console.WriteLine("La cantidad de numeros en la coleccion es {0}", coleccionable.cuantos());
        }
    }
}