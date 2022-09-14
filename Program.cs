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
            // llenar(pila);
            // informar(pila);
            main();


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
        static public void informar(IColeccionable coleccionable)
        {
            IComparable maximo = coleccionable.maximo();
            IComparable minimo = coleccionable.minimo();
            System.Console.WriteLine("Ingrese un número para verificar si está en la coleccion");
            IComparable numeroContenedor = new Numero(int.Parse(Console.ReadLine()));
            bool verificar = coleccionable.contiene(numeroContenedor);
            System.Console.WriteLine("La cantidad de numeros en la coleccion es {0}", coleccionable.cuantos());
            System.Console.WriteLine("El número más grande de la coleccion es {0}", ((Numero)maximo).getValor());
            System.Console.WriteLine("El número más chico de la coleccion es {0}", ((Numero)minimo).getValor());
            if (verificar)
            {
                System.Console.WriteLine("El número está en la colección");
            }
            else
            {
                System.Console.WriteLine("El número no está en la colección");
            }

        }

        // static public void informarPersonas(IColeccionable personas)
        // {
        //     IComparable maximo = personas.maximo();
        //     IComparable minimo = personas.minimo();
        //     System.Console.WriteLine("El documento mas chico es {0}", ((Persona)minimo).getDNI());
        //     System.Console.WriteLine("El documento mas grande es {0}", ((Persona)maximo).getDNI());
        //     System.Console.WriteLine("Ingrese un documento para verificar si existe en la lista");
        //     int documento = int.Parse(Console.ReadLine());
        //     IComparable persona1 = new Persona("null", documento);
        //     bool existe = personas.contiene(persona1);
        //     if (existe)
        //     {
        //         System.Console.WriteLine("El documento está en la lista");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("El documento no está en la lista");
        //     }
        // }
        static public void informarAlumnos(IColeccionable personas)
        {
            IComparable maximo = personas.maximo();
            IComparable minimo = personas.minimo();
            Random num = new Random();
            System.Console.WriteLine("El legajo mas chico es {0}", ((Alumno)minimo).getLegajo());
            System.Console.WriteLine("El legajo mas grande es {0}", ((Alumno)maximo).getLegajo());
            System.Console.WriteLine("Ingrese un legajo para verificar si existe en la lista");
            int legajo = int.Parse(Console.ReadLine());
            Numero numeroLegajo = new Numero(legajo);
            Numero promedio = new Numero(num.Next(0, 9));
            IComparable persona1 = new Alumno("null", 0, numeroLegajo, promedio);
            bool existe = personas.contiene(persona1);
            if (existe)
            {
                System.Console.WriteLine("El legajo está en la lista");
            }
            else
            {
                System.Console.WriteLine("El legajo no está en la lista");
            }
        }

        //Ejercicio 11
        // static void llenarPersonas(IColeccionable coleccionPersonas)
        // {
        //     for (int i = 0; i < 20; i++)
        //     {
        //         Random numeroAleatorio = new Random();
        //         string[] nombres = {"Warren F. Zayas",
        //         "Lonnie L. Jones", "Sean H. Chavez" ,"Júlia Costa Barbosa",
        //         "Joao Ribeiro Barbosa", "Tomás Cunha Araujo",
        //         "Tânia Ribeiro Alves", "Isabela Pereira Carvalho",
        //         "Aline Goncalves Melo", "Xiuxiu Ch'eng", "Kuan-Yin Kê"};
        //         string nombreCompleto = nombres[(numeroAleatorio.Next(2))];

        //        // IComparable comparable = new Persona(nombreCompleto, numeroAleatorio.Next(30000000, 50000000));
        //         coleccionPersonas.agregar(comparable);

        //     }
        // }

        static void llenarAlumnos(IColeccionable coleccionAlumnos)
        {
            for (int i = 0; i < 20; i++)
            {
                Random numeroAleatorio = new Random();
                string[] nombres = {"Warren F. Zayas",
                "Lonnie L. Jones", "Sean H. Chavez" ,"Júlia Costa Barbosa",
                "Joao Ribeiro Barbosa", "Tomás Cunha Araujo",
                "Tânia Ribeiro Alves", "Isabela Pereira Carvalho",
                "Aline Goncalves Melo", "Xiuxiu Ch'eng", "Kuan-Yin Kê"};
                string nombreCompleto = nombres[(numeroAleatorio.Next(2))];
                Numero legajo = new Numero(numeroAleatorio.Next(0, 9999));
                Numero promedio = new Numero(numeroAleatorio.Next(1, 10));

                IComparable comparable = new Alumno(nombreCompleto, numeroAleatorio.Next(30000000, 50000000), legajo, promedio);
                coleccionAlumnos.agregar(comparable);

            }
        }

        //Ejercicio 7 , 9, 13
        static public void main()
        {
            Pila<IComparable> pila = new Pila<IComparable>();
            Cola<IComparable> cola = new Cola<IComparable>();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            // llenar(cola);
            // llenar(pila);
            // llenarPersonas(pila);
            // llenarPersonas(cola);
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            // informar(cola);
            // informar(pila);
            //informar(multiple);
            // informarPersonas(multiple);
            informarAlumnos(multiple);
        }
    }
}