namespace tp1.tp2
{
    public class Diccionario : IColeccionable, Iterable, tp5.IOrdenable
    {
        List<ClaveValor> lista_claveValor; //Guardo las claves en una lista
        //TP5
        tp5.OrdenEnAula1 ordenInicio;
        tp5.OrdenEnAula2 ordenLlegaAlumno;
        tp5.OrdenEnAula1 ordenAulaLlena;
        //Constructor
        public Diccionario()
        {
            lista_claveValor = new List<ClaveValor>(); //Nuevas instancias de lista tipo ClaveValor
        }

        //Metodos

        public void agregar(ClaveValor entrada)
        {
            bool aux = true;
            for (int i = 1; i < lista_claveValor.Count; i++)
            {
                if (lista_claveValor[i].getClave() == entrada.getClave())
                {
                    lista_claveValor[i] = entrada;
                    aux = false;
                }
            }
            if (aux)
            {
                lista_claveValor.Add(entrada);
            }
        }

        public IComparable valorDe(IComparable key)
        {

            for (int i = 0; i < lista_claveValor.Count; i++)
            {
                if (lista_claveValor[i].getClave().sosIgual(key))
                {
                    return ((ClaveValor)lista_claveValor[i]).getValor(); //Tener cuidado con los casteos, revisar muy bien
                }
            }
            return null;
        }

        //Metodos interfaz coleccionable

        public void agregar(IComparable entrada)
        {
            bool llave_existe = false;
            bool continuar = true;

            while (continuar)
            {
                Random aleatorio = new Random();
                IComparable clave_nueva = new Numero(aleatorio.Next(0, 1000));

                for (int i = 0; i < lista_claveValor.Count; i++)
                {
                    if (lista_claveValor[i].getClave() == clave_nueva)
                    {
                        llave_existe = true;
                    }
                }
                if (llave_existe == false)
                {
                    ClaveValor nueva = new ClaveValor(clave_nueva, entrada);

                    //TP5 Ej 9
                    if (lista_claveValor.Count == 0)
                    {
                        ordenInicio.ejecutar();
                    }
                    ordenLlegaAlumno.ejecutar(entrada);
                    lista_claveValor.Add(nueva);
                    if (lista_claveValor.Count == 40)
                    {
                        ordenAulaLlena.ejecutar();
                    }
                    continuar = false;
                }
            }
        }

        public bool contiene(IComparable entrada)
        {
            for (int i = 0; i < lista_claveValor.Count; i++)
            {
                if (lista_claveValor[i].getValor().sosIgual(entrada))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return lista_claveValor.Count;
        }

        public IComparable maximo()
        {
            IComparable aux = lista_claveValor[0].getValor();

            for (int i = 1; i < lista_claveValor.Count; i++)
            {
                if (lista_claveValor[i].getValor().esMayor(aux))
                {
                    aux = lista_claveValor[i].getValor();
                }
            }

            return aux;
        }

        public IComparable minimo()
        {
            IComparable aux = lista_claveValor[0].getValor();

            for (int i = 1; i < lista_claveValor.Count; i++)
            {
                if (lista_claveValor[i].getValor().esMenor(aux))
                {
                    aux = lista_claveValor[i].getValor();
                }
            }

            return aux;
        }

        //Metodo interfaz Iterador

        public IteradorComparables crearIterador()
        {
            IteradorComparables iterador = new iteradorDiccionarios(lista_claveValor);
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