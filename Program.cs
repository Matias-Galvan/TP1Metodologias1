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
            //main();
            //main2();
            //main3();
            //main4();
            //main5();
            //main6();
            //main7();
            mainAdaptador();


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
        // static public void informarAlumnos(IColeccionable personas)
        // {
        //     IComparable maximo = personas.maximo();
        //     IComparable minimo = personas.minimo();
        //     Random num = new Random();
        //     System.Console.WriteLine("La estrategia seleccionada es {0}", ((Alumno)maximo).obtenerEstrategia());
        //     System.Console.WriteLine("El legajo mas chico es {0}", ((Alumno)minimo).getLegajo());
        //     System.Console.WriteLine("El legajo mas grande es {0}", ((Alumno)maximo).getLegajo());
        //     System.Console.WriteLine("Ingrese un legajo para verificar si existe en la lista");
        //     int legajo = int.Parse(Console.ReadLine());
        //     Numero numeroLegajo = new Numero(legajo);
        //     Numero promedio = new Numero(num.Next(0, 9));
        //     IComparable persona1 = new Alumno("null", 0, numeroLegajo, promedio);
        //     bool existe = personas.contiene(persona1);
        //     if (existe)
        //     {
        //         System.Console.WriteLine("El legajo está en la lista");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("El legajo no está en la lista");
        //     }
        // }

        //Ejercicio 2 TP2
        // static public void informarAlumnos(IColeccionable personas)
        // {
        //     IComparable maximo = personas.maximo();
        //     IComparable minimo = personas.minimo();
        //     System.Console.WriteLine("El legajo mas chico es {0}", ((Alumno)minimo).getLegajo());
        //     System.Console.WriteLine("El legajo mas grande es {0}", ((Alumno)maximo).getLegajo());
        //     Random num = new Random();
        //     System.Console.WriteLine("La estrategia seleccionada es {0}", ((Alumno)maximo).obtenerEstrategia());
        //     if (((Alumno)maximo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoLegajo))
        //     {
        //         System.Console.WriteLine("Ingrese un legajo para verificar si existe en la lista");
        //         int legajo = int.Parse(Console.ReadLine());
        //         Numero numeroLegajo = new Numero(legajo);
        //         Numero promedio = new Numero(num.Next(0, 9));
        //         IComparable persona1 = new Alumno("null", 0, numeroLegajo, promedio);
        //         bool existe = personas.contiene(persona1);
        //         if (existe)
        //         {
        //             System.Console.WriteLine("El legajo está en la lista");
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("El legajo no está en la lista");
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Estrategia no implementada");
        //     }



        // }

        static public void informarAlumnos(IColeccionable personas)
        {
            IComparable maximo = personas.maximo();
            IComparable minimo = personas.minimo();
            Random num = new Random();
            System.Console.WriteLine("La estrategia seleccionada es {0}", ((Alumno)maximo).obtenerEstrategia());
            if (((Alumno)maximo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoLegajo) && ((Alumno)minimo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoLegajo))
            {
                System.Console.WriteLine("El legajo mas chico es {0}", ((Alumno)minimo).getLegajo());
                System.Console.WriteLine("El legajo mas grande es {0}", ((Alumno)maximo).getLegajo());
            }
            else if (((Alumno)maximo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoDNI) && ((Alumno)minimo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoDNI))
            {
                System.Console.WriteLine("El DNI mas chico es {0}", ((Alumno)minimo).getDNI());
                System.Console.WriteLine("El DNI mas grande es {0}", ((Alumno)maximo).getDNI());
            }
            else if (((Alumno)maximo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoNombre) && ((Alumno)minimo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoNombre))
            {
                System.Console.WriteLine("El nombre mas chico es {0}", ((Alumno)minimo).getNombre());
                System.Console.WriteLine("El nombre mas grande es {0}", ((Alumno)maximo).getNombre());
            }
            else if (((Alumno)maximo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoPromedio) && ((Alumno)minimo).obtenerEstrategia() == typeof(tp1.tp2.compararAlumnoPromedio))
            {
                System.Console.WriteLine("El promedio mas chico es {0}", ((Alumno)minimo).getPromedio());
                System.Console.WriteLine("El promedio mas grande es {0}", ((Alumno)maximo).getPromedio());
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

        // static void llenarAlumnos(IColeccionable coleccionAlumnos)
        // {
        //     for (int i = 0; i < 20; i++)
        //     {
        //         Random numeroAleatorio = new Random();
        //         string[] nombres = {"Warren F. Zayas",
        //         "Lonnie L. Jones", "Sean H. Chavez" ,"Júlia Costa Barbosa",
        //         "Joao Ribeiro Barbosa", "Tomás Cunha Araujo",
        //         "Tânia Ribeiro Alves", "Isabela Pereira Carvalho",
        //         "Aline Goncalves Melo", "Xiuxiu Ch'eng", "Kuan-Yin Kê"};
        //         string nombreCompleto = nombres[(numeroAleatorio.Next(10))];
        //         Numero legajo = new Numero(numeroAleatorio.Next(0, 9999));
        //         Numero promedio = new Numero(numeroAleatorio.Next(1, 10));

        //         IComparable comparable = new Alumno(nombreCompleto, numeroAleatorio.Next(30000000, 50000000), legajo, promedio);
        //         coleccionAlumnos.agregar(comparable);


        //     }
        // }

        //Ejercicio 7 tp2

        public static void imprimirElementos(IColeccionable elementos)
        {

            tp1.tp2.IteradorComparables iterador = ((tp2.Iterable)elementos).crearIterador();

            while (iterador.fin() == false)
            {
                System.Console.WriteLine(iterador.actual().ToString());
                iterador.siguiente();
            }

            System.Console.WriteLine("-----------------------------------");
        }

        //Ejercicio 9 tp2
        public static void cambiarEstrategia(IColeccionable lista, string estrategia)
        {
            tp2.IteradorComparables iterador = ((tp2.Iterable)lista).crearIterador(); //tener en cuenta los casteos sino tira error
            while (iterador.fin() == false)
            {
                ((Alumno)iterador.actual()).setearEstrategia(estrategia);
                iterador.siguiente();
            }
        }

        public static void llenarGeneral(IColeccionable lista_entrada, string tipoCreacion)
        {
            for (int i = 0; i < 20; i++)
            {
                lista_entrada.agregar(tp3.FabricaDeComparables.crear_Comparable(tipoCreacion));
            }
        }




        public static void informarGeneral(IColeccionable lista_entrada, string tipoAInformar)
        {
            IComparable comparable = tp3.FabricaDeComparables.crear_Comparable(tipoAInformar);

            System.Console.WriteLine("La cantidad de {0} del coleccionable es {1}", tipoAInformar, lista_entrada.cuantos());
            System.Console.WriteLine("El {0} más grande es {1}", tipoAInformar, lista_entrada.maximo());
            System.Console.WriteLine("El {0} más chico es {1}", tipoAInformar, lista_entrada.minimo());

            //System.Console.WriteLine("Ingrese un valor para ver si está en la lista: ");
            if (lista_entrada.contiene(comparable))
            {
                System.Console.WriteLine("El {0} leído está en la colección", tipoAInformar);
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("El {0} leído no está en la colección", tipoAInformar);
                Console.ReadKey();

            }

        }

        //Ejercicio 7 , 9, 13
        // static public void main()
        // {
        //     Pila<IComparable> pila = new Pila<IComparable>();
        //     Cola<IComparable> cola = new Cola<IComparable>();
        //     ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        //     // llenar(cola);
        //     // llenar(pila);
        //     // llenarPersonas(pila);
        //     // llenarPersonas(cola);
        //     llenarAlumnos(pila);
        //     llenarAlumnos(cola);
        //     // informar(cola);
        //     // informar(pila);
        //     //informar(multiple);
        //     // informarPersonas(multiple);
        //     informarAlumnos(multiple);
        // }

        //Ejercicio 8 tp2

        // static public void main()
        // {
        //     Pila<IComparable> pila = new Pila<IComparable>();
        //     Cola<IComparable> cola = new Cola<IComparable>();
        //     tp1.tp2.Conjunto conjunto = new tp2.Conjunto();
        //     tp2.Diccionario diccionario = new tp2.Diccionario();
        //     llenarAlumnos(pila);
        //     llenarAlumnos(cola);
        //     llenarAlumnos(conjunto);
        //     llenarAlumnos(diccionario);
        //     imprimirElementos(pila);
        //     imprimirElementos(cola);
        //     imprimirElementos(conjunto);
        //     imprimirElementos(diccionario);
        // }

        //Ejercicio 10 tp2
        // static public void main2()
        // {
        //     Cola<IComparable> cola = new Cola<IComparable>();
        //     llenarAlumnos(cola);
        //     cambiarEstrategia(cola, "Nombre");
        //     informarAlumnos(cola);
        //     cambiarEstrategia(cola, "Legajo");
        //     informarAlumnos(cola);
        //     cambiarEstrategia(cola, "Promedio");
        //     informarAlumnos(cola);
        //     cambiarEstrategia(cola, "DNI");
        //     informarAlumnos(cola);
        // }

        //TP 3 ej 2
        static public void main3()
        {
            int cantidad = 10;
            int pruebaNumero = tp3.generadorDatosAleatorio.numeroAleatorio(cantidad);
            string pruebaStrings = tp3.generadorDatosAleatorio.stringAleatorio(cantidad);
            System.Console.WriteLine("El numero es {0} y el string es {1}", pruebaNumero, pruebaStrings);
            Console.ReadKey();

        }
        //TP 3 ej 3, 4, 5
        static public void main4()
        {
            tp3.FabricaDeComparables fabricaComparables = new tp3.FabricaDeNumeros();
            IComparable alumno = fabricaComparables.crearAleatorio();
            System.Console.WriteLine(((Numero)alumno).getValor());
            Console.ReadKey();
        }

        //TP 3 ej 6
        static public void main5()
        {
            Cola<IComparable> cola = new tp1.Cola<IComparable>();
            tp2.Diccionario diccionario = new tp2.Diccionario();
            //cambiarEstrategia(diccionario, "DNI");


            llenarGeneral(diccionario, "AlumnoRandom");
            informarGeneral(diccionario, "AlumnoSeleccionable");
        }

        //TP 3 ej 8 y 9
        static public void main6()
        {
            Cola<IComparable> cola = new tp1.Cola<IComparable>();
            tp2.Diccionario diccionario = new tp2.Diccionario();
            llenarGeneral(diccionario, "VendedorRandom");
            informarGeneral(diccionario, "VendedorSeleccionable");
        }

        static public void main7()
        {
            tp2.Diccionario diccionario = new tp2.Diccionario();
            llenarGeneral(diccionario, "VendedorRandom");
            tp3.Gerente gerente = new tp3.Gerente();

            void agregarGerenteColeccion(IColeccionable vendedores, tp3.Gerente gerente)
            {
                tp2.IteradorComparables iterador = ((tp2.Iterable)vendedores).crearIterador();

                while (iterador.fin() == false)
                {
                    ((tp3.Vendedor)iterador.actual()).agregarObservador(gerente);
                    iterador.siguiente();
                }
            }

            void JornadaDeVentas(IColeccionable vendedores)
            {
                for (int i = 0; i < 20; i++)
                {
                    tp2.IteradorComparables iterador = ((tp2.Iterable)vendedores).crearIterador();

                    while (iterador.fin() == false)
                    {
                        int monto = tp3.generadorDatosAleatorio.numeroAleatorio(7000);
                        ((tp3.Vendedor)iterador.actual()).ventaVendedor(monto);
                        ((tp3.Vendedor)iterador.actual()).notificar();
                        iterador.siguiente();
                    }
                }

            }

            agregarGerenteColeccion(diccionario, gerente);
            JornadaDeVentas(diccionario);
            gerente.cerrar();
            Console.ReadKey();
        }

        //TP4 -> metodos para ejercicio 4

        public static void llenarHasta10Alumnos(IColeccionable lista_entrada, string tipoCreacion)
        {
            for (int i = 0; i < 10; i++)
            {
                lista_entrada.agregar(tp3.FabricaDeComparables.crear_Comparable(tipoCreacion));

            }
        }

        static public void mainAdaptador()
        {
            tp4.Teacher profesor = new tp4.Teacher();
            tp2.Diccionario diccionario = new tp2.Diccionario();
            llenarGeneral(diccionario, "AlumnoRandom");
            // llenarHasta10Alumnos(diccionario, "AlumnoRandomEstudioso");
            // llenarHasta10Alumnos(diccionario, "AlumnoRandom");

            for (int i = 0; i < 10; i++)
            {
                tp3.FabricaDeComparables fabricaAlumnos = new tp3.FabricaDeAlumnos();
                tp4.IDecoradorAlumnos alumnoDecorado = new tp4.DecoradorLegajo((Alumno)fabricaAlumnos.crearAleatorio());
                alumnoDecorado = new tp4.DecoradorEnLetras(alumnoDecorado);
                alumnoDecorado = new tp4.DecoradorPromocion(alumnoDecorado);
                alumnoDecorado = new tp4.DecoradorAsteriscos(alumnoDecorado);

                tp4.AdaptadorAlumnos alumnoAdaptado = new tp4.AdaptadorAlumnos(alumnoDecorado);
                profesor.goToClass(alumnoAdaptado);
            }

            for (int i = 0; i < 10; i++)
            {
                tp3.FabricaDeComparables fabricaAlumnos1 = new tp4.FabricaAlumnosEstudiosos();
                tp4.IDecoradorAlumnos alumnoDecorado = new tp4.DecoradorLegajo((Alumno)fabricaAlumnos1.crearAleatorio());

                alumnoDecorado = new tp4.DecoradorEnLetras(alumnoDecorado);
                alumnoDecorado = new tp4.DecoradorPromocion(alumnoDecorado);
                alumnoDecorado = new tp4.DecoradorAsteriscos(alumnoDecorado);

                tp4.AdaptadorAlumnos alumnoAdaptado = new tp4.AdaptadorAlumnos(alumnoDecorado);
                profesor.goToClass(alumnoAdaptado);

            }

            profesor.teachingAClass();
        }
    }
}